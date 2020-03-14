Feature: RegisterUser
	In order to use the system
	As a new user of the system
	I want to be able to register as a new user of the system

Scenario: Register User
	Given I am in the registration page of the system
	When I enter my personal information and address
	Then I should be registered and able to login
