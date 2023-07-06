using Indian_State_Census_Problem;

namespace Indian_State_Census_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1()
        {
            string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\Indian-State-Census-Data.csv";

            StateCensusAnalyser analyser = new StateCensusAnalyser();

            int actual = analyser.ReadAndCountStateCensusData(FilePath);

            int expected = 29;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase2()
        {

            string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problems\Indian-State-Census-Data.csv";

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
            string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\Indian-State-Census-Data.json";

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

        [TestMethod]
        public void TestCase4()
        {
            string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\Indian-State-Census-Data - Copy.csv";

            StateCensusAnalyser analyser = new StateCensusAnalyser();

            try
            {
                analyser.ReadAndCountStateCensusData(FilePath);
            }
            catch (IndianStateCensusCustomException ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }

        [TestMethod]
        public void TestCase5()
        {
            string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\Indian-State-Census-Data - Incorrect-Header.csv";

            StateCensusAnalyser analyser = new StateCensusAnalyser();

            var exception = Assert.ThrowsException<IndianStateCensusCustomException>(() => analyser.ReadAndCountStateCensusData(FilePath));

            Assert.AreEqual("Incorrect Header", exception.Message);
        }

    }
}