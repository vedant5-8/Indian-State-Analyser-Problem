
namespace Indian_State_Census_Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Indian State Census analyser problem\n");

            StateCensusAnalyser analyser = new StateCensusAnalyser();

            try
            {
                string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\Indian-State-Census-Data.csv";

                Console.WriteLine("\nTotal number of Indian State Census records are {0}.", analyser.ReadAndCountStateCensusData(FilePath));
            }
            catch (IndianStateCensusCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Welcome to Indian State Code analyser problem\n");

            StateCodeAnalyser stateCodeAnalyser = new StateCodeAnalyser();

            try
            {
                string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\StateCode.csv";

                Console.WriteLine("\nTotal number of Indian State Census records are {0}.", stateCodeAnalyser.ReadAndCountStateCodeData(FilePath));
            }
            catch (IndianStateCensusCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}