using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyzerUnitTest
{
    [TestClass]
    public class MoodAnalyzerUnitTestCase
    {

        //given mood shoud return sad
        public void GivenMood_ShouldReturn_Sad()
        {
            //expected string will be sad
            string expected = "Sad";
            //create a object of cass moodanalyzer with i am sad
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am Sad");
            //assertion is a boolean expression at a specific point in a program 
            Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        }
        [TestMethod]
        //given mood shoud return happy
        public void GivenMood_ShouldReturn_Happy()
        {
            //expected string will be happy
            string expected = "Happy";
            //create a object of cass moodanalyzer with i am happy
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am Happy");
            //assertion is a boolean expression at a specific point in a program 
            Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        }

        [TestMethod]
        // Given Null Mood Should Return Happy
        public void GivenNullMoodShouldReturnHappy()
        {
            //expected string will be happy
            string expected = "Happy";
            //create a object of cass moodanalyzer with Null value
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(null);
            //assertion is a boolean expression at a specific point in a program 
            Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        }

    }
}