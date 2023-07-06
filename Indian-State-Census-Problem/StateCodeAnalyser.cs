using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Indian_State_Census_Problem
{
    public class StateCodeAnalyser
    {
        public int ReadAndCountStateCodeData(string fileName)
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
                    var Records = CSV.GetRecords<StateCodeAnalyserModel>().ToList();

                    Console.WriteLine("+--------+------------------------------+------+----------+");
                    Console.WriteLine("|" + "Sr. No.".PadLeft(8) + "|" + "State Name".PadLeft(30) + "|" + "TIN".PadLeft(6) + "|" + "State Code".PadLeft(10) + "|");
                    Console.WriteLine("+--------+------------------------------+------+----------+");

                    foreach (var Record in Records)
                    {
                        Console.WriteLine("|" + Record.SrNo.ToString().PadLeft(8) + "|" + Record.StateName.PadLeft(30) + "|" + Record.TIN.PadLeft(6) + "|" + Record.StateCode.PadLeft(10) + "|");
                        Console.WriteLine("+--------+------------------------------+------+----------+");
                    }

                    return Records.Count;
                }
            }

        }
    }
}
