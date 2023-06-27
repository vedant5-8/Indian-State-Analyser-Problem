
namespace Indian_State_Census_Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Indian State Census analyser problem\n");

            string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\Indian-State-Census-Data.csv";

            StateCensusAnalyser analyser = new StateCensusAnalyser();

            analyser.ReadCensusData(FilePath);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTotal number of Indian State Census records are {0}.", analyser.CountCSVData(FilePath));
            Console.ResetColor();

        }
    }
}