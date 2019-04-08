Feature: HomepageTest
	
@test
Scenario Outline: submit homepage with empty field(s)
	Given I go to url: https://buyer-stg.guidantfinancial.com/
	When I submit form with: <firstname> , <lastname> , <email> , <phone>
	Then I see error message displays
	Examples: 
	| firstname | lastname | email              | phone |
	|           |          |                    |       |
	| Firstname |          |                    |       |
	| Firstname | Lastname |                    |       |
	| Firstname | Lastname | sample@testing.com |       |

Scenario Outline: submit homepage with valid info
	Given I go to url: https://buyer-stg.guidantfinancial.com/
	When I submit form with: <firstname> , <lastname> , <email> , <phone>
	Then I see Survey page displays
	Examples: 
		| firstname | lastname | email              | phone      |
		| Firstname | Lastname | sample@testing.com | 0988777666 | 
