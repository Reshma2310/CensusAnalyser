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
            if (Path.GetExtension(filePath) == ".csv")
            {
                try
                {
                    if (filePath.Contains("CensusData.csv"))
                    {
                        int numberOfRecords;
                        using (var reader = new StreamReader(filePath))
                        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                        {
                            var details = csv.GetRecords<StateModelClass>().ToList();
                            numberOfRecords = details.Count();
                            foreach (var data in details)
                            {
                                Console.WriteLine("State: " + data.State + "\nPopulation: " + data.Population + "\nAreaInSqKm: " + data.AreaInSqKm
                                    + "\nDensityPerSqKm: " + data.DensityPerSqKm + "\n");
                            }
                        }
                        return numberOfRecords;
                    }
                    throw new CensusExceptions(CensusExceptions.ExceptionType.INVALID_FILE, "Invalid File");
                }
                catch (CsvHelper.MissingFieldException)
                {
                    throw new CensusExceptions(CensusExceptions.ExceptionType.INCORRECT_DELIMITER, "Incorrect Delimiter");
                }
                catch (CsvHelper.HeaderValidationException)
                {
                    throw new CensusExceptions(CensusExceptions.ExceptionType.INCORRECT_HEADER, "Incorrect Header");
                }
            }
            throw new CensusExceptions(CensusExceptions.ExceptionType.INVALID_FILE_TYPE, "Invalid File Type");
        }
        public int StateCodeAnalyser(string fileofPath)
        {
            int numberOfRecords;
            using (var reader = new StreamReader(fileofPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var details = csv.GetRecords<StatesCode>().ToList();
                numberOfRecords = details.Count();
                foreach (var data in details)
                {
                    Console.WriteLine("SrNo: " + data.SrNo + "\nState: " + data.State + "\nName: " + data.Name
                        + "\nTIN: " + data.TIN + "\nStateCode: " + data.StateCode + "\n");
                }
            }
            return numberOfRecords;
        }
    }
}
