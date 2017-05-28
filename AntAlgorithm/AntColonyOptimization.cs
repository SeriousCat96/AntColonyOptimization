using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntAlgorithm
{
	static class AntColonyOptimization
	{
		// Минимальное значение феромона
		public const double MinPheromoneValue = double.Epsilon;

		public const string DefaultGraphFileName = "input.txt";

		// Коэффициент альфа
		public static double Alpha { get; set; }
		// Коэффициент бета
		public static double Beta { get; set; }
		// Коэффициент Q
		public static int Q { get; set; }
		// Коэффициент высыхания феромонов
		public static double P { get; set; }
		// Количество итераций алгоритма
		public static int IterationsCount { get; set; }
		// Количество городов
		public static int CitiesCount { get; set; }
		// Граф городов
		public static Graph Cities { get; set; }
		// Матрица феромонов
		public static double[,] Pheromones { get; set; }
		// Длина лучшего пути
		public static int BestLength { get; set;}
		// Лучший путь
		public static int[] BestPath { get; set; }

		static AntColonyOptimization()
		{
			SetDefaults();
		}

		// Задаёт значения по умолчанию
		public static void SetDefaults()
		{
			Alpha			= 1;
			Beta			= 1;
			Q				= 10;
			P				= 0.00005;
			IterationsCount = 50000;
			Cities		    = new Graph(DefaultGraphFileName);
			CitiesCount	    = Cities.Count;

			BestPath		= new int[CitiesCount];
			BestLength		= int.MaxValue;

			Pheromones		= new double[CitiesCount, CitiesCount];
			SetDefaultPheromones();
		}

		// Вычисление оптимального пути
		public static int[] Calculate()
		{
			for(int i = 0; i < IterationsCount; i++)
			{
				var path = BuildRoute();
				var length = GetLength(path);

				if(length < BestLength)
				{
					BestLength = length;
					BestPath = path;
				}

				UpdatePheromones(path, length);
			}

			return BestPath;
		}

		// Построение пути
		static int[] BuildRoute()
		{
			var visited = new bool[CitiesCount];
			var city = new Random().Next(0, CitiesCount);

			int[] path = new int[CitiesCount + 1];
			path[0] = city;
			visited[city] = true;

			for(int i = 1; i < CitiesCount; i++)
			{
				var neighbourCities = new List<int>(GetNeighbourCities(city))
					.Where((e) => !visited[e])
					.ToArray();

				var probabilities = GetProbabilities(city, neighbourCities);
				var distribution = GetDistributionVector(probabilities);

				city = ChooseNextCity(distribution, neighbourCities);
				path[i] = city;
				visited[city] = true;
			}

			if(Cities[city, path[0]] != 0)
			{
				path[CitiesCount] = path[0];
				return path;
			}
			else return null;
		}

		// Получения списка вероятностей
		static double[] GetProbabilities(int city, int[] neighbourCities)
		{
			var probabilities = new double[neighbourCities.Length];
			var sum = GetSum(city, neighbourCities);

			for(int j = 0; j < probabilities.Length; j++)
			{
				var distance = Cities[city, neighbourCities[j]];
				var pheromone = Pheromones[city, neighbourCities[j]];

				probabilities[j] = GetProbability(distance, pheromone, sum);
			}

			return probabilities;
		}

		// Обновление феромонов
		static void UpdatePheromones(int[] path, int length)
		{
			// Отмечаем рёбра пути
			var visited = new bool[CitiesCount, CitiesCount];

			for(int i = 0; i < CitiesCount; i++)
			{
				visited[path[i], path[i + 1]] = true;
			}

			for(int i = 0; i < CitiesCount; i++)
			{
				for(int j = 0; j < CitiesCount; j++)
				{
					double delta = 0;

					// Если ребро входит в путь, то увеличивается кол-во феромонов на этом ребре
					// Иначе по-тихоньку кол-во феромоноа "высыхает"
					if(visited[i, j])
					{
						delta = (double)Q / length;
					}

					Pheromones[i, j] = (1 - P) * Pheromones[i, j] + delta;

					if(Pheromones[i, j] < MinPheromoneValue && i != j)
					{
						Pheromones[i, j] = MinPheromoneValue;
					}
				}
			}
		}

		// Выбор следующего города
		static int ChooseNextCity(double[] distribution, int[] neighbourCities)
		{
			double randomValue = new Random().Next(0, 10000) / 100.0;
			double prev = 0;

			for(int i = 0; i < distribution.Length; i++)
			{
				if(randomValue >= prev && randomValue < distribution[i])
				{
					return neighbourCities[i];
				}
				else prev = distribution[i];
			}

			return -1;
		}

		// Получает вектор распределения вероятностей для выбора следующего города
		static double[] GetDistributionVector(double[] probabilities)
		{
			var distribution = new double[probabilities.Length];
			double prev = 0;

			for(int j = 0; j < distribution.Length; j++)
			{
				distribution[j] += probabilities[j] + prev;
				prev = distribution[j];
			}

			return distribution;
		}

		// Подсчёт вероятности муравья пойти в этот город
		static double GetProbability(int distance, double pheromone, double sum)
		{
			var a = Math.Pow((1.0 / distance), Beta) * Math.Pow(pheromone, Alpha);
			return 100 * (a / sum);
		}

		// Подсчёт суммы в знаменателе формулы вероятности
		static double GetSum(int city, int[] neighbourCities)
		{
			double sum = 0.0;

			foreach(var neighbourCity in neighbourCities)
			{
				var n = 1.0 / Cities[city, neighbourCity];
				sum += Math.Pow(n, Beta) * Math.Pow(Pheromones[city, neighbourCity], Alpha);
			}

			return sum;
		}

		// Получает список соседних городов
		static int[] GetNeighbourCities(int city)
		{
			var citiesList = new List<int>();

			for(int i = 0; i < CitiesCount; i++)
			{
				if (Cities[city, i] != 0)
				{
					citiesList.Add(i);
				}
			}

			return citiesList.ToArray();
		}

		// Подсчёт длины пути
		static int GetLength(int[] path)
		{
			int sum = 0;
			for(int i = 0; i < CitiesCount; i++)
			{
				sum += Cities[path[i], path[i + 1]];
			}

			return sum;
		}

		// Задаёт минимальные значения феромонов
		static void SetDefaultPheromones()
		{
			for(int i = 0; i < CitiesCount; i++)
			{
				for(int j = 0; j < CitiesCount; j++)
				{
					if(i != j)
						Pheromones[i, j] = 1;
					else Pheromones[i, j] = 0;
				}
			}
		}
	}
}
