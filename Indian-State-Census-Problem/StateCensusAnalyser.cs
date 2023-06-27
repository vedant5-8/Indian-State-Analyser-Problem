
using CsvHelper;
using System.Globalization;

namespace Indian_State_Census_Problem
{
    public class StateCensusAnalyser
    {
        public void ReadCensusData(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            using (var CSV = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var Records = CSV.GetRecords<StateCensusAnalyserModel>().ToList();

                foreach (var Record in Records)
                {
                    Console.WriteLine("{0} {1} {2} {3}", Record.State, Record.Population, Record.AreaInSqKm, Record.DensityPerSqKm);
                }
            }
        }

        public int CountCSVData(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            using (var CSV = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var Records = CSV.GetRecords<StateCensusAnalyserModel>().ToList();

                return Records.Count;
            }
        }

    }
}
