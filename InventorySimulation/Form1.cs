using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryModels;
using InventoryTesting;

namespace InventorySimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		SimulationSystem simulationSystem = new SimulationSystem();
		private string fileName;


		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{

						richTextBox1.Clear();
						string filePath = openFileDialog.FileName;
						fileName = openFileDialog.SafeFileName;
						string fileContents = File.ReadAllText(filePath);
						string[] TextLines = fileContents.Split('\n');
						richTextBox1.Text = fileContents;
						simulationSystem.StartProgram(TextLines);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error reading the file: " + ex.Message);
					}



				}
		}

		private void serverComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			serviceTimeDistributionDataTable.Rows.Clear();
			for (int i = 0; i < simulationSystem.DemandDistribution.Count; i++)
			{
				int serviceTime = simulationSystem.DemandDistribution[i].Value;
				decimal Probability = simulationSystem.DemandDistribution[i].Probability;
				decimal CumProp = simulationSystem.DemandDistribution[i].CummProbability;
				int MinRange = simulationSystem.DemandDistribution[i].MinRange;
				int MaxRange = simulationSystem.DemandDistribution[i].MaxRange;

				serviceTimeDistributionDataTable.Rows.Add(serviceTime, Probability, CumProp, MinRange, MaxRange);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			serviceTimeDistributionDataTable.Rows.Clear();
			for (int i = 0; i < simulationSystem.LeadDaysDistribution.Count; i++)
			{
				int serviceTime = simulationSystem.LeadDaysDistribution[i].Value;
				decimal Probability = simulationSystem.LeadDaysDistribution[i].Probability;
				decimal CumProp = simulationSystem.LeadDaysDistribution[i].CummProbability;
				int MinRange = simulationSystem.LeadDaysDistribution[i].MinRange;
				int MaxRange = simulationSystem.LeadDaysDistribution[i].MaxRange;

				serviceTimeDistributionDataTable.Rows.Add(serviceTime, Probability, CumProp, MinRange, MaxRange);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{

			if (simulationSystem != null)
			{

				simulationSystem.CreateTableWithFields();
				simulationSystem.get_perfomances();
				TableOfData tableOfData = new TableOfData(simulationSystem);
				tableOfData.Show();


				string result = TestingManager.Test(simulationSystem, fileName);
				MessageBox.Show(result);
			}
			else
				MessageBox.Show("Please Choose Test Case");
		}
	}
}
