Feature: CaptureFeature
	Lets see if the captures work properly

@mytag
Scenario: Create a capture
	Given I have addded "Misi" to the expressions
	And I have also added "Peti" in the same capture
	Then there should be a match for "GyoriMisi"
	Then there should also be a match for 'TothPetiAladar'
	Then there souldn't be a match for "Geza"
