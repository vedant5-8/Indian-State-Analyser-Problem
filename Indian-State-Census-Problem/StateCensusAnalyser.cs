
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

            var csvfile = File.ReadAllLines(fileName);
            string actualHeader = "State,Population,AreaInSqKm,DensityPerSqKm";
            string header = csvfile[0];

            if (!header.Equals(actualHeader))
            {
                throw new IndianStateCensusCustomException(IndianStateCensusCustomException.StateCensusExceptionType.INCORRECT_HEADER, "Incorrect Header");
            }

            foreach (string line in csvfile)
            {
                if (!line.Contains(','))
                {
                    throw new IndianStateCensusCustomException(IndianStateCensusCustomException.StateCensusExceptionType.INCORRECT_DELIMITER, "Incorrect Delimiter");
                }
            }

            using (var reader = new StreamReader(fileName))
            using (var CSV = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var Records = CSV.GetRecords<StateCensusAnalyserModel>().ToList();

                Console.WriteLine("+------------------+-----------+-------------+-----------------+");
                Console.WriteLine("|" + "State".PadLeft(18) + "|" + "Population".PadLeft(11) + "|" + "Area In SQKM".PadLeft(13) + "|" + "Density Per SQKM".PadLeft(17) + "|");
                Console.WriteLine("+------------------+-----------+-------------+-----------------+");


                foreach (var Record in Records)
                {
                    Console.WriteLine("|" + Record.State.ToString().PadLeft(18) + "|" + Record.Population.ToString().PadLeft(11) + "|" + Record.AreaInSqKm.ToString().PadLeft(13) + "|" + Record.DensityPerSqKm.ToString().PadLeft(17) + "|");
                    Console.WriteLine("+------------------+-----------+-------------+-----------------+");
                }

                return Records.Count;
            }
        }
    }
}
