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
    }
}
