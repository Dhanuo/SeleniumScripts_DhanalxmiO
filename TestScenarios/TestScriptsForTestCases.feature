Feature: TestScriptsForTestCases

A short summary of the feature:
Go to joinassembly.com and perform the following
1.Verify the number of lists available under the Integrations > SSO & HRIS Sync and print at-least 2 Integrations. (Integrations > Categories)A short summary of the feature
2.Verify different pricing section and print billing price of each plans (Pricing) 


Scenario: The number of lists available under the Integrations
	Given I go to joinassembly.com 
	When Navigate to the Integrations > SSO & HRIS Sync webpage
	Then Verify the number of lists available under the Integrations and Print atleast two Integrations

Scenario: Verify different pricing section and print billing price of each plans (Pricing) 
	Given I go to joinassemblydotcom
	When Navigate to Pricing webpage
	Then Verify different pricing sections and Print billing Price of each plan
