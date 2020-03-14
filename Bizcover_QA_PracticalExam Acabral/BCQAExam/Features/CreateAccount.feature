Feature: CreateAccount
	In order to use the system
	As a new user of the system
	I want to be able to create a new account in the system

Scenario: Create Account
	Given I am in the sign-in page of the system
	When I enter my email address
	Then I should be redirected to Register Account Page
