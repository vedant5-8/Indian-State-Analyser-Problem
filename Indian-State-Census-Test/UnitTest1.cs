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

            int actual = analyser.CountCSVData(FilePath);

            int expected = 29;

            Assert.AreEqual(expected, actual);

        }
    }
}