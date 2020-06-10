Feature: 3Profile
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add Education in Profile
	Given User Navigates to Education Tab
	When User adds Educations
	Then Verify if Education is added


@mytag
Scenario: Edit Education in profile
	Given User Navigates to Education Tab
	When User edits Educations
	Then Verify if Education is Edited


@mytag
Scenario: Delete Education in profile
	Given User Navigates to Education Tab
	When User Deletes Education
	Then Verify if Education is Deleted


@mytag
Scenario: Add Certification in Profile
	Given User Navigates to Certificate Tab
	When User adds Certificate
	Then Verify if Certificate is added


@mytag
Scenario: Edit Certification in profile
	Given User Navigates to Certificate Tab
	When User edits Certificate
	Then Verify if Certificate is Edited


@mytag
Scenario: Delete Certification in profile
	Given User Navigates to Certificate Tab
	When User Deletes Certificate
	Then Verify if Certificate is Deleted