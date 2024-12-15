using InventoryModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySimulation
{
	public partial class TableOfData : Form
	{
		public TableOfData()
		{
			InitializeComponent();
		}
		private SimulationSystem simulationSystem;

		public TableOfData(SimulationSystem simulationSystem)
		{
			InitializeComponent();
			this.simulationSystem = simulationSystem;
		}

		private void outputDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void TableOfData_Load(object sender, EventArgs e)
		{
			populateDataView();

		}
		private void populateDataView()
		{

			foreach (var simulationCase in simulationSystem.SimulationTable)
			{
				int Day = simulationCase.Day;
				int Cycle = simulationCase.Cycle;
				int DayWithinCycle = simulationCase.DayWithinCycle;
				int BeginningInventory = simulationCase.BeginningInventory;
				int RandomDemand = simulationCase.RandomDemand;
				int Demand = simulationCase.Demand;
				int EndingInventory = simulationCase.EndingInventory;
				int ShortageQuantity = simulationCase.ShortageQuantity;
				int OrderQuantity = simulationCase.OrderQuantity;
				int RandomLeadDays = simulationCase.RandomLeadDays;
				int LeadDays = simulationCase.LeadDays;


				outputDataGridView.Rows.Add(Day, Cycle, DayWithinCycle, BeginningInventory,
					RandomDemand, Demand, EndingInventory, ShortageQuantity, OrderQuantity, RandomLeadDays, LeadDays);

			}
			DisplayDataPerformance();

		}
		public void DisplayDataPerformance()
		{
			textBox1.Text = simulationSystem.PerformanceMeasures.EndingInventoryAverage.ToString();
			textBox2.Text = simulationSystem.PerformanceMeasures.ShortageQuantityAverage.ToString();
		}

	}
}
