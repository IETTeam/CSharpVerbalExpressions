Feature: ComplexTest
	Testing a complex scenario

@mytag
Scenario: Complex scenario
	Given I add 'szo' to the expressions
	And I add 'es' 3 times then anything can follow
	And I end the expression 'halas'
	Then the result should match 'szoesesesadjkfjdsfkhalas'
