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

            StateCodeAnalyser analyser = new StateCodeAnalyser();
            
            var exception = Assert.ThrowsException<IndianStateCensusCustomException>(() => analyser.ReadAndCountStateCodeData(FilePath));

            Assert.AreEqual("Incorrect File Path", exception.Message);
        }

        [TestMethod]
        public void TestCase3()
        {
            string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\StateCode.json";

            StateCodeAnalyser analyser = new StateCodeAnalyser();

            var exception = Assert.ThrowsException<IndianStateCensusCustomException>(() => analyser.ReadAndCountStateCodeData(FilePath));

            Assert.AreEqual("Incorrect File Type", exception.Message);
        }

        [TestMethod]
        public void TestCase4()
        {
            string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\StateCode - Copy.csv";

            StateCodeAnalyser analyser = new StateCodeAnalyser();

            var exception = Assert.ThrowsException<IndianStateCensusCustomException>(() => analyser.ReadAndCountStateCodeData(FilePath));

            Assert.AreEqual("Incorrect Delimiter", exception.Message);
        }
        
        [TestMethod]
        public void TestCase5()
        {
            string FilePath = @"D:\Courses\C#\Indian State Census Project\Indian-State-Census-Problem\StateCode - Incorrect-Header.csv";

            StateCodeAnalyser analyser = new StateCodeAnalyser();

            var exception = Assert.ThrowsException<IndianStateCensusCustomException>(() => analyser.ReadAndCountStateCodeData(FilePath));

            Assert.AreEqual("Incorrect Header", exception.Message);
        }

    }
}
