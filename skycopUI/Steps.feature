Feature: SkycopSteps

Scenario: Open Skycop claim homepage
	Given I navigate to claims
	Then I set Kaunas as departure airport
	And I set London Gatwick as arrival airport
	Then I select airlines
	Then I select flight number
	Then I select flight date
	Then I select flight problem
	Then I select delay duration
	Then I choose reason provided by airlines
	Then I choose where did I hear about them
	Then I select next step
	Then I describe situation
	Then I enter reservation number
	Then I enter travellers details
	Then I enter name
	Then I enter surname
	Then I enter birthdate
	Then I enter e-mail
	Then I re-enter e-mail
	Then I enter mobile phone
	Then I enter adress
	Then I enter city
	Then I enter postcode
	Then I choose country
	Then I choose language
	Then I choose trevellers number
