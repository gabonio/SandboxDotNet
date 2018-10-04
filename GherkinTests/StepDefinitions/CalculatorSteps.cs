using SandBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace GherkinTests.StepDefinitions
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator calculator = new Calculator();

        #region Data entry

        [Given(@"I enter (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.InputNumber = number;
        }

        [Given(@"then I enter (.*) into the calculator")]
        public void GivenThenIEnterIntoTheCalculator(int number)
        {
            calculator.InputNumber = number;
        }

        #endregion

        #region Math Operations

        [Given(@"I press Add")]
        public void GivenIPressAdd()
        {
            calculator.Add();
        }

        [When(@"I press Equals")]
        public void WhenIPressEquals()
        {
            calculator.Equals();
        }

        [Given(@"I press Equals")]
        public void GivenIPressEquals()
        {
            calculator.Equals();
        }

        [Given(@"I press Substract")]
        public void GivenIPressSubstract()
        {
            calculator.Substract();
        }

        [When(@"I press Clear")]
        public void WhenIPressClear()
        {
            calculator.Clear();
        }


        #endregion

        #region results    

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, calculator.Result);
        }

        #endregion

    }
}
