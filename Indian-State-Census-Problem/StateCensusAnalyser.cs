
using CsvHelper;
using System.Globalization;

namespace Indian_State_Census_Problem
{
    public class StateCensusAnalyser
    {
        public int ReadAndCountStateCensusData(string fileName)
        {
            if (!fileName.EndsWith(".csv"))
            {
                throw new IndianStateCensusCustomException(IndianStateCensusCustomException.StateCensusExceptionType.INCORRECT_TYPE, "Incorrect File Type");
            }
            else if (!File.Exists(fileName))
            {
                throw new IndianStateCensusCustomException(IndianStateCensusCustomException.StateCensusExceptionType.INCORRECT_FILE, "Incorrect File Path");
            }
            else
            {
                using (var reader = new StreamReader(fileName))
                using (var CSV = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var Records = CSV.GetRecords<StateCensusAnalyserModel>().ToList();

                    foreach (var Record in Records)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", Record.State, Record.Population, Record.AreaInSqKm, Record.DensityPerSqKm);
                    }

                    return Records.Count;
                }
            }
        }

    }
}
