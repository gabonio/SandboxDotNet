using SandBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace GherkinTests.StepDefinitions
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator calculator = new Calculator();
        private Table sumatoryTable;

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

        [Given(@"I add a new number")]
        public void GivenIAddANewNumber()
        {
            ScenarioContext.Current.Pending();
        }


        #endregion

        #region results    

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, calculator.Result);
        }

        [Given(@"the following table numbers and their sumatory results")]
        public void GivenTheFollowingTableNumbersAndTheirSumatoryResults(Table table)
        {
            sumatoryTable = table;

        }

        [Then(@"the result of all the summs must be correct")]
        public void ThenTheResultOfAllTheSummsMustBeCorrect()
        {
            foreach (TableRow row in sumatoryTable.Rows)
            {
                calculator.Clear();
                calculator.InputNumber = int.Parse(row[0]);
                calculator.Add();
                calculator.InputNumber = int.Parse(row[1]);
                calculator.Equals();
                Assert.AreEqual(int.Parse(row[2]), calculator.Result);

            }
        }


        #endregion

    }
}
