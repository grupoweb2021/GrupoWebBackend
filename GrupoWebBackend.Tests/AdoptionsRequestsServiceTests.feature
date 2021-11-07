Feature: AdoptionsRequestsServiceTests
As a Developer 
I want to add a new AdoptionsRequests through API
So that it is available whe wanting to see my adoptionrequests.

@adoptionsrequests-adding
Scenario: Post a adoptionsrequests 
	Given the endpoint https://localhost:5001/api/v1/AdoptionsRequests is available
	When A adoptionsrequests is sent
	  | Message | Status  |
	  | hola    | pending |
   Then A response with status 200 is received
