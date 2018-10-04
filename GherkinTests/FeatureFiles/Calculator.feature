Feature: Calculator

Scenario: Add two numbers
	Given I enter 50 into the calculator
	And  I press Add
	And then I enter 70 into the calculator
	When I press Equals
	Then the result should be 120


Scenario: Add three numbers
	Given I enter 50 into the calculator
	And  I press Add
	And  I enter 70 into the calculator
	And  I press Add
	And then I enter 80 into the calculator
	When I press Equals
	Then the result should be 200


Scenario: Substract two numbers
	Given I enter 70 into the calculator
	And  I press Substract
	And  I enter 50 into the calculator
	When I press Equals
	Then the result should be 20


Scenario: Clear the results
	Given I enter 50 into the calculator
	And  I press Add
	And then I enter 70 into the calculator
	And I press Equals
	When I press Clear
	Then the result should be 0