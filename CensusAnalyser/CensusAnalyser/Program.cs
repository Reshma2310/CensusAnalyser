using System;
namespace CensusAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"D:\BridgeLabs\CensusAnalyser\CensusAnalyser\CensusAnalyser\StateCensusData.csv";
            StateAnalyser getMethod = new StateAnalyser();
            getMethod.DataAnalyser(filePath);
        }
    }
}