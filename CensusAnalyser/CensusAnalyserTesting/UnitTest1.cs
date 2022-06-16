namespace CensusAnalyserTesting
{
    public class Tests
    {
        /*[Test]
        public void GivenStatesCensusCSVFile_CheckNumberOfRecordsMatches()
        {
            int expected = 29;
            string filePath = @"D:\BridgeLabs\CensusAnalyser\CensusAnalyser\CensusAnalyser\StateCensusData.csv";
            CensusAnalyser.StateAnalyser value = new CensusAnalyser.StateAnalyser();
            int actual = value.DataAnalyser(filePath);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenInvalidFile_ShouldThrowInvalidFileException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabs\CensusAnalyser\CensusAnalyser\CensusAnalyser\StateCode.csv";
                CensusAnalyser.StateAnalyser data = new CensusAnalyser.StateAnalyser();
                int actual = data.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidFileType_ShouldThrowInvalidFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabs\CensusAnalyser\CensusAnalyser\CensusAnalyser\StateCensusData.txt";
                CensusAnalyser.StateAnalyser example = new CensusAnalyser.StateAnalyser();
                int actual = example.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File Type", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidDelimiterFile_ShouldThrowInvalidDelimiterFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabs\CensusAnalyser\CensusAnalyser\CensusAnalyser\InvalidDelimeterStateCensusData.csv";
                CensusAnalyser.StateAnalyser name = new CensusAnalyser.StateAnalyser();
                int actual = name.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidHeaderFile_ShouldThrowInvalidHeaderFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabs\CensusAnalyser\CensusAnalyser\CensusAnalyser\InvalidHeaderCensusData.csv";
                CensusAnalyser.StateAnalyser value = new CensusAnalyser.StateAnalyser();
                int actual = value.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }*/
        [Test]
        public void GivenStatesCodeCSVFile_CheckNumberOfRecordsMatches()
        {
            int expected = 37;
            string filePath = @"D:\BridgeLabs\CensusAnalyser\CensusAnalyser\CensusAnalyser\StateCode.csv";
            CensusAnalyser.StateAnalyser exa = new CensusAnalyser.StateAnalyser();
            int actual = exa.StateCodeAnalyser(filePath);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenInvalidCodeFile_ShouldThrowInvalidFileException()
        {
            try
            {
                int expected = 37;
                string filePath = @"D:\BridgeLabs\CensusAnalyser\CensusAnalyser\CensusAnalyser\StateCensusData.csv";
                CensusAnalyser.StateAnalyser data = new CensusAnalyser.StateAnalyser();
                int actual = data.StateCodeAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidCodeFileType_ShouldThrowInvalidFileTypeException()
        {
            try
            {
                int expected = 37;
                string filePath = @"D:\BridgeLabs\CensusAnalyser\CensusAnalyser\CensusAnalyser\StateCensusData.txt";
                CensusAnalyser.StateAnalyser value = new CensusAnalyser.StateAnalyser();
                int actual = value.StateCodeAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File Type", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidDelimiterFile_ShouldThrowIncorrectDelimiterException()
        {
            try
            {
                int expected = 37;
                string filePath = @"D:\BridgeLabs\CensusAnalyser\CensusAnalyser\CensusAnalyser\InvaliDelimeterStateCode.csv";
                CensusAnalyser.StateAnalyser data = new CensusAnalyser.StateAnalyser();
                int actual = data.StateCodeAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidHeaderFile_ShouldThrowIncorrectHeaderException()
        {
            try
            {
                int expected = 37;
                string filePath = @"D:\BridgeLabs\CensusAnalyser\CensusAnalyser\CensusAnalyser\InvalidHeaderStateCode.csv";
                CensusAnalyser.StateAnalyser value = new CensusAnalyser.StateAnalyser();
                int actual = value.StateCodeAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }
    }
}