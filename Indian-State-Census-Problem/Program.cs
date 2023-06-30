﻿
namespace Indian_State_Census_Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Indian State Census analyser problem\n");

            try
            {
                string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\Indian-State-Census-Data.csv";

                StateCensusAnalyser analyser = new StateCensusAnalyser();

                Console.WriteLine("\nTotal number of Indian State Census records are {0}.", analyser.ReadAndCountStateCensusData(FilePath));
            }
            catch (IndianStateCensusCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}