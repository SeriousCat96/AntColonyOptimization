using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntAlgorithm
{
	public partial class MainForm : Form
	{

		Stopwatch Timer { get; }

		double Alpha
		{
			set
			{
				AntColonyOptimization.Alpha = value;
				_tboxAlpha.Text = value.ToString();
			}
		}
		double Beta
		{
			set
			{
				AntColonyOptimization.Beta = value;
				_tboxBeta.Text = value.ToString();
			}
		}
		int Q
		{
			set
			{
				AntColonyOptimization.Q = value;
				_tboxQ.Text = value.ToString();
			}
		}
		double P
		{
			set
			{
				AntColonyOptimization.P = value;
				_tboxP.Text = value.ToString();
			}
		}
		int IterationsCount
		{
			set
			{
				AntColonyOptimization.IterationsCount = value;
				_tboxIterationsCount.Text = value.ToString();
			}
		}

		public MainForm()
		{
			InitializeComponent();

			Timer = new Stopwatch();
		}

		private void SetParameters()
		{
			Alpha			= AntColonyOptimization.Alpha;
			Beta			= AntColonyOptimization.Beta;
			Q				= AntColonyOptimization.Q;
			P				= AntColonyOptimization.P;
			IterationsCount = AntColonyOptimization.IterationsCount;
		}

		private void Parse()
		{
			Alpha			= double.Parse(_tboxAlpha.Text);
			Beta			= double.Parse(_tboxBeta.Text);
			Q				= int.Parse(_tboxQ.Text);
			P				= double.Parse(_tboxP.Text);
			IterationsCount = int.Parse(_tboxIterationsCount.Text);
		}

		private bool Checkparameters()
		{
			try
			{
				Parse();
				return true;
			}
			catch(FormatException)
			{
				MessageBox.Show(this, "Неверный формат параметров", "Format error", MessageBoxButtons.OK);
				return false;
			}
		}

		private void OnButtonCalculateClick(object sender, EventArgs e)
		{
			switch(comboBox1.SelectedIndex)
			{
				case 0:
					{
						AntColonyOptimization.ResetAlgorithm();

						if(Checkparameters())
						{
							Timer.Restart();
							var path = AntColonyOptimization.Calculate();
							Timer.Stop();

							textBox1.Text = AntColonyOptimization.ToString();

							_lblMinLengthValue.Text = AntColonyOptimization
								.BestLength
								.ToString();

							_lblTime.Text = Timer
								.Elapsed
								.TotalSeconds
								.ToString() + " сек";
						}

						break;
					}

					case 1:
					{
						BruteForce.SetDefaults();

						Timer.Restart();
						var path = BruteForce.Calculate();
						Timer.Stop();

						textBox1.Text = BruteForce.ToString();

						_lblMinLengthValue.Text = BruteForce
							.BestLength
							.ToString();

						_lblTime.Text = Timer
							.Elapsed
							.TotalSeconds
							.ToString() + " сек";

						break;
					}
			}
		}

		private void OnEditGraphButtonClick(object sender, EventArgs e)
		{
			Process.Start(AntColonyOptimization.DefaultGraphFileName);
		}

		private void OnComboboxSelectedIndexChanged(object sender, EventArgs e)
		{
			switch(comboBox1.SelectedIndex)
			{
				default:
					groupBox1.Enabled = false;
					break;
				case 0:
					groupBox1.Enabled = true;
					SetParameters();
					break;
			}
		}
	}
}
