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
		private int[,] _adj;
		private int _count;

		public Graph(int count)
		{
			_adj   = new int[count, count];
			_count = count;
		}

		public Graph(string path)
		{
			Load(path);
		}

		public void Load(string path)
		{
			int[] mass = File
				.ReadAllText(path)
				.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(n => int.Parse(n))
				.ToArray();

				_count = mass[0];
				_adj   = new int[_count, _count];

			int count = 1;
			for(int i = 0; i < _count; i++)
			{
				for(int j = 0; j < _count; j++)
				{
					_adj[i, j] = mass[count++];				
				}
			}
		}
	}
}
