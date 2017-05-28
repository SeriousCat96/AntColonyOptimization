using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntAlgorithm
{
	public class Graph
	{
		// матрицы смежности
		private int[,] _adj;
		// количество вершин
		public int Count;

		public Graph(int count)
		{
			_adj   = new int[count, count];
			Count = count;
		}

		// Индексатор
		public int this[int i, int j]
		{
			get { return _adj[i, j]; }
			set { _adj[i, j] = value; }
		}

		public Graph(string path)
		{
			Load(path);
		}

		// Загрузка из файла
		public void Load(string path)
		{
			int[] mass = File
				.ReadAllText(path)
				.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(n => int.Parse(n))
				.ToArray();

				Count = mass[0];
				_adj   = new int[Count, Count];

			int count = 1;
			for(int i = 0; i < Count; i++)
			{
				for(int j = 0; j < Count; j++)
				{
					_adj[i, j] = mass[count++];				
				}
			}
		}
	}
}
