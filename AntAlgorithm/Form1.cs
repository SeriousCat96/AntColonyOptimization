using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntAlgorithm
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();

			var best = AntColonyOptimization.Calculate();
		}

		//public double GetProbability(int i, int j, double length)
		//{
		//	double n = 1 / length;


		//	return 0;
		//}
	}
}
