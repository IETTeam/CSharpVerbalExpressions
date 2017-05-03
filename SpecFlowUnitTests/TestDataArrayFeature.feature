Feature: TestDataArrayFeature
	Test for multiple possibilities

@mytag
Scenario Outline: Test for multiple expressions and inputs
	Given I have added "<expr>" to the expression
	Then searching in "<searched>" , the result should be '<res>'

	Examples:
	| expr | searched   | res   |
	| .com | googlecom  | false |
	| .com | google.com | true  |