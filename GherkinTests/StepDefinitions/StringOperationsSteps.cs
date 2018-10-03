using SandBox;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GherkinTests.StepDefinitions
{
    [Binding]
    public class StringOperationsSteps
    {
        public string FirstWord { get; set; }
        public string SecondWord { get; set; }

        public string ResultString { get; set; }

        private StringOperations _stringOperations = new StringOperations();

        [Given(@"I have entered ""(.*)"" as the first word")]
        public void GivenIHaveEnteredAsTheFirstWord(string word)
        {
            FirstWord = word;
        }
        
        [Given(@"I have entered ""(.*)"" as the second word")]
        public void GivenIHaveEnteredAsTheSecondWord(string word)
        {
            SecondWord = word;
        }
        
        [When(@"I want to concatenate them")]
        public void WhenIWantToConcatenateThem()
        {
            ResultString = _stringOperations.Concatenate(FirstWord, SecondWord);
        }

        [When(@"I want to concatenate them with a space in between")]
        public void WhenIWantToConcatenateThemWithASpaceInBetween()
        {
            ResultString = _stringOperations.ConcatenateWithSpace(FirstWord, SecondWord);
        }

        [Then(@"the concatenated result should be ""(.*)""")]
        public void ThenTheConcatenatedResultShouldBe(string expectedResult)
        {
            Assert.AreEqual(expectedResult, ResultString);
        }
    }
}
