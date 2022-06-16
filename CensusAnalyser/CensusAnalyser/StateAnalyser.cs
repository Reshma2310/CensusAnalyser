using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace CensusAnalyser
{
    public class StateAnalyser
    {
        public int DataAnalyser(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var details = csv.GetRecords<StateModelClass>().ToList();
                var numberOfRecords = details.Count();
                foreach (var data in details)
                {
                    Console.WriteLine("State: " + data.State + "\nPopulation: " + data.Population + "\nAreaInSqKm: " + data.AreaInSqKm
                        + "\nDensityPerSqKm: " + data.DensityPerSqKm + "\n");
                }
                return numberOfRecords;
            }
        }
    }
}
