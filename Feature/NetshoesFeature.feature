Feature: NetshoesFeature

	Background: 
		Given I have opened browser to access website
		Then close browser
		


	Scenario Outline: Search Product on WebSite
	
	When search the shoes for '<name>' open the shoes
	And when shoes opened compare if is the same '<value>'

	Examples: 
	| name                      | value     |
	| Nike Downshifter 9        | R$ 189,99 |
	| Nike Nightgazer           | R$ 189,99 |
	| Nike Flex Experience Rn 8 | R$ 239,99 |
	