using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntAlgorithm
{
	static class BruteForce
	{
		public const string DefaultGraphFileName = "input.txt";


		// Количество городов
		public static int CitiesCount { get; set; }
		// Граф городов
		public static Graph Cities { get; set; }
		// Длина лучшего пути
		public static int BestLength { get; set; }
		// Лучший путь
		public static int[] BestPath { get; set; }

		static BruteForce()
		{
			SetDefaults();
		}

		// Задаёт значения по умолчанию
		public static void SetDefaults()
		{
			Cities = new Graph(DefaultGraphFileName);
			CitiesCount = Cities.Count;

			BestPath = new int[CitiesCount];
			BestLength = int.MaxValue;
		}

		public static int[] Calculate()
		{
			int[] counter = new int[CitiesCount + 2];

			do
			{
				var path = new int[CitiesCount + 1];

				Array.Copy(counter, path, path.Length);

				if(Check(path))
				{
					int length = GetLength(path);
					if(length < BestLength)
					{
						BestLength = length;
						BestPath = path;
					}
					
				}

				int i = 0;         // Переход к следующей комбинации
				while(counter[i] == CitiesCount - 1)
				{
					counter[i] = 0;
					i++;
				}
				counter[i]++;
			} while(counter[counter.Length - 1] != 1);

			return BestPath;
		}

		static bool Check(int[] path)
		{
			bool[] check = new bool[path.Length];

			if(path[0] != path[path.Length - 1]) return false;

			for(int i = 0; i < CitiesCount; i++)
			{
				if(Cities[path[i], path[i + 1]] == 0) return false;
			}

			for(int i = 0; i < path.Length; i++)
			{
				if(!check[path[i]])
				{
					check[path[i]] = true;
				}
				else if(i == 0 || i == path.Length - 1) continue;
				else return false;
			}

			return true;
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
	}
}
