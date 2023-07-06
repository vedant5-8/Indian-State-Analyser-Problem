using Indian_State_Census_Problem;

namespace Indian_State_Census_Test
{
    [TestClass]
    public class UnitTestForStateCodeCSVFile
    {
        [TestMethod]
        public void TestCase1()
        {
            string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\StateCode.csv";

            StateCodeAnalyser analyser = new StateCodeAnalyser();

            int actual = analyser.ReadAndCountStateCodeData(FilePath);

            int expected = 37;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase2()
        {

            string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problems\StateCode.csv";

            StateCensusAnalyser analyser = new StateCensusAnalyser();

            try
            {
                analyser.ReadAndCountStateCensusData(FilePath);
            }
            catch (IndianStateCensusCustomException ex)
            {
                Assert.AreEqual("Incorrect File Path", ex.Message);
            }
        }

        [TestMethod]
        public void TestCase3()
        {
            string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\StateCode.json";

            StateCensusAnalyser analyser = new StateCensusAnalyser();

            try
            {
                analyser.ReadAndCountStateCensusData(FilePath);
            }
            catch (IndianStateCensusCustomException ex)
            {
                Assert.AreEqual("Incorrect File Type", ex.Message);
            }
        }
    }
}
