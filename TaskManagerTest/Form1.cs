using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			Progress<string> p = new Progress<string>();
			

			await Task.Run(() =>
			{
				string Hello = "Hello";

				Console.WriteLine(Hello);

			});

			IProgress<string> progress = new Progress<string>();

			int Index = -1;







			Action a = new Action(() =>
			{
				//LongRunningTask("");
			});

			TaskManager.TaskManager t = new TaskManager.TaskManager();

			(Index, progress) = t.Start(a);
		}

		private async void LongRunningTask(IProgress<string> Progress)
		{
			Progress.Report("Starting task");

			for (int i = 1; i < 11; i++)
			{
				Thread.Sleep(10000);
				Progress.Report("Part " + i.ToString() + " complete");
			}
		}
	}
}
