Feature: AddFeature
	I want to see, if i can add regex
	And then find it.
@find
Scenario: Find added expression
	Given I have added '.com' to the expression
	Then it should be found in "google.com" expression
	Then it also shouldn't be found in "googlecom" expression

