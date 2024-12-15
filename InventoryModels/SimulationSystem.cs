using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DemandDistribution = new List<Distribution>();
            LeadDaysDistribution = new List<Distribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }

        ///////////// INPUTS /////////////

        public int OrderUpTo { get; set; }
        public int ReviewPeriod { get; set; }
        public int NumberOfDays { get; set; }
        public int StartInventoryQuantity { get; set; }
        public int StartLeadDays { get; set; }
        public int StartOrderQuantity { get; set; }
        public List<Distribution> DemandDistribution { get; set; }
        public List<Distribution> LeadDaysDistribution { get; set; }

        ///////////// OUTPUTS /////////////

        public List<SimulationCase> SimulationTable { get; set; }

		public PerformanceMeasures PerformanceMeasures { get; set; }
		decimal tot_end = 0, tot_shortage = 0;

		public void StartProgram(string[] TextLines)
		{
			DemandDistribution.Clear();
			LeadDaysDistribution.Clear();

			OrderUpTo = Convert.ToInt32(TextLines[1]);

			ReviewPeriod = Convert.ToInt32(TextLines[4]);

			StartInventoryQuantity = Convert.ToInt32(TextLines[7]);

			StartLeadDays = Convert.ToInt32(TextLines[10]);

			StartOrderQuantity = Convert.ToInt32(TextLines[13]);

			NumberOfDays = Convert.ToInt32(TextLines[16]);

			int currentLine = 19;
			while (TextLines[currentLine] != "\r")
			{
				string[] separator = { ", " };
				string[] values = TextLines[currentLine].Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
				Distribution timeDistribution = new Distribution();
				timeDistribution.Value = Convert.ToInt32(values[0]);
				timeDistribution.Probability = Convert.ToDecimal(values[1]);
				DemandDistribution.Add(timeDistribution);
				currentLine++;
			}

			currentLine += 2;
			while (currentLine < TextLines.Length && TextLines[currentLine] != "\r")
			{
				string[] separator = { ", " };
				string[] values = TextLines[currentLine].Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
				Distribution timeDistribution = new Distribution();
				timeDistribution.Value = Convert.ToInt32(values[0]);
				timeDistribution.Probability = Convert.ToDecimal(values[1]);
				LeadDaysDistribution.Add(timeDistribution);
				currentLine++;
			}
			DemandDistribution = CalcTableTimeDistripution(DemandDistribution);
			LeadDaysDistribution = CalcTableTimeDistripution(LeadDaysDistribution);
		}
		public List<Distribution> CalcTableTimeDistripution(List<Distribution> table)
		{
			decimal cummulativeProbability = 0;
			int minRange = 1;

			foreach (Distribution item in table)
			{
				cummulativeProbability += item.Probability;
				item.CummProbability = cummulativeProbability;
				item.MinRange = minRange;
				item.MaxRange = (int)(cummulativeProbability * 100);
				minRange = item.MaxRange + 1;
			}
			return table;

		}
		public void CreateTableWithFields()
		{

			int cycle = 1, startUp = StartLeadDays + 1;
			int demand = 0, sh = 0 ;

			Dictionary<int, int> up_day = new Dictionary<int, int>();
			Random R = new Random();

			for (int i = 0; i < NumberOfDays; i++)
			{
				SimulationCase customerCase = new SimulationCase();
				customerCase.Day = i + 1;
				customerCase.Cycle = cycle;

				customerCase.DayWithinCycle = (i + 1) % ReviewPeriod;
				if (customerCase.DayWithinCycle == 0)
				{
					customerCase.DayWithinCycle = ReviewPeriod;
					cycle++;
				}

				customerCase.BeginningInventory = StartInventoryQuantity;
				if (i + 1 == startUp)
					customerCase.BeginningInventory += StartOrderQuantity;
				try
				{
					customerCase.BeginningInventory += up_day[i + 1];
				}
				catch (Exception)
				{
					customerCase.BeginningInventory += 0;
				}

				int rand = R.Next(1, 101);
				customerCase.RandomDemand = rand;
				for (int j = 0; j < DemandDistribution.Count; j++)
				{
					if (DemandDistribution[j].MinRange <= rand && DemandDistribution[j].MaxRange >= rand)
					{
						customerCase.Demand = DemandDistribution[j].Value;
						demand = DemandDistribution[j].Value;
						break;
					}
				}

				demand += sh;
				customerCase.EndingInventory = Math.Max(0, customerCase.BeginningInventory - demand);

				if (customerCase.BeginningInventory >= demand)
					customerCase.ShortageQuantity = 0;
				else
					customerCase.ShortageQuantity = demand - customerCase.BeginningInventory;

				if (customerCase.DayWithinCycle == ReviewPeriod)
				{
					customerCase.OrderQuantity = OrderUpTo - customerCase.EndingInventory + customerCase.ShortageQuantity;
					customerCase.RandomLeadDays = R.Next(1, 101);
					for (int j = 0; j < LeadDaysDistribution.Count; j++)
					{
						if (LeadDaysDistribution[j].MinRange <= customerCase.RandomLeadDays && LeadDaysDistribution[j].MaxRange >= customerCase.RandomLeadDays)
						{
							customerCase.LeadDays = LeadDaysDistribution[j].Value;
							break;
						}
					}

					try
					{
						up_day[(i + 1) + customerCase.LeadDays + 1] += customerCase.OrderQuantity;
					}
					catch (Exception)
					{
						up_day[(i + 1) + customerCase.LeadDays + 1] = customerCase.OrderQuantity;
					}

				}
				else
				{
					customerCase.OrderQuantity = 0;
					customerCase.RandomLeadDays = 0;
					customerCase.LeadDays = 0;
				}

				tot_shortage += customerCase.ShortageQuantity;
				tot_end += customerCase.EndingInventory;
				StartInventoryQuantity = customerCase.EndingInventory;
				sh = customerCase.ShortageQuantity;
				SimulationTable.Add(customerCase);
			}

		}
		public void get_perfomances()
		{
			PerformanceMeasures.ShortageQuantityAverage = (decimal)(tot_shortage / NumberOfDays);
			PerformanceMeasures.EndingInventoryAverage = (decimal)(tot_end / NumberOfDays);
		}
	}
}
