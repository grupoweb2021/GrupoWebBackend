Feature: AdoptionsRequestsServiceTests
As a Developer
I want to add new Adoption Requests through API
So that it is available when the user make a adoption requests
	Background: 
		Given The Endpoint https://localhost:5001/api/v1/AdoptionsRequests is available
		And A User is already stored for AdoptionsRequests
		  | Id | Type | UserNick | Pass     | Ruc      | Dni      | Phone     | Email             | Name      | LastName | DistrictId |
		  | 1  | VET  | Frank    | Password | A12345rf | 70258688 | 946401234 | frank@outlook.com | Francisco | Voularte | 1          |
@adoptionsrequests-adding
Scenario: A AdoptionsRequests is sent 
	When A adoption request is sent
	| Message | Status  | UserIdFrom | UserId | PublicationId |
	| hello   | pending | 2           |1        |1            |
	Then A Response with Status 200 is received
Scenario: Add Adoption Request with empty data
	When A post adoption request is sent
	  | Message | Status  |
	  | hello   |  	      |
	Then AAdoptionRequests With Status 400 is received
Scenario: Add Adoption Request with same data
	When A post adoption request is sent
	  | Message | Status  | UserIdFrom | UserId | PublicationId |
	  | hello   | pending | 2          |1       |1              |
	Then AAdoptionRequests With Status 200 is received