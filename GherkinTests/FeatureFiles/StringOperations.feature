Feature: String Operations

Scenario: Concatenate two words
	Given I have entered "Hello" as the first word
	And I have entered "World" as the second word
	When I want to concatenate them
	Then the concatenated result should be "HelloWorld"

Scenario: Concatenate two words with a space in between
	Given I have entered "Hello" as the first word
	And I have entered "World" as the second word
	When I want to concatenate them with a space in between
	Then the concatenated result should be "Hello World"