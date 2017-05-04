Feature: ModifierFeature
	Lets's test the modifiers


Scenario Outline: Using modifier
	Given I have added "<expr>" to the expressions
	Then with "<modifier>" modifier, it should match "<res>"

	Examples:
	| expr        | modifier | res                  |
	| teststring  | i        | TESTSTRING           |
	| test string | x        | test string #comment |
