Feature: CustomerCanGetQuoteForACar
	In order to buy a car policy 
	As a customer
	I want to ability to get a quote for a car


Scenario: Customer can buy car policy
	Given Am on policywise homepage
	When I click on get quote buttton
	And I click on select make fileld
	And I click on select model field
	And I enter the cubic capacity as 1998cc
	And I enter postcode as sk4 1tb
	And I enter house number as 13
	And I click on find
	And I select overnight park location as Garaged(steel) from dropdown
    And I enter year of make as 2017
	And I enter date first registered as 10/11/2017
	And I enter date of purchase as 14/06/2018
	And I select vehicle type as saloon from dropdown
	And I select vehicle owner as company director from dropdown
	And I select registered keeper as company director from dropdown
	And I select transmission as automatic from dropdown
	And I select fuel type as petrol from dropdown
	And I enter vehicle colour as black 
	And I click No on radio q-plated button
	And I click No on Imported radio button 
	And I select number of seats as 5 from dropdown
	And I click Yes on Is the Vehicle Right Hand Drive radio button
	And I enter Estimated annual millage as 10000
	And I enter Estimated business millage as 4000
	And I enter Current Vehicle millage as 33000
	And I enter value as £18000
	And I click No on Is modified radio button
	And I enter Purchase Price as £16500
	And I enter Chasis Number as 3HGBH45JKMN106434
	And I select alarm Type as Thatcham Catergory 1 Device from dropdown
	And I select Fitted Tracker as None from dropdown
	And I click on next button
    Then quote and Buy page is displayed




