Feature: AddServiceTestsSteps
	As a developer
	I want to publish adds through API
	So that I can get buyers
Background: 
	Given the endpoint https://localhost:5001/api/v1/Advertisements is available.
	And A User is already stored for Advertisement
	  | Id | Type | UserNick | Pass     | Ruc      | Dni      | Phone     | Email             | Name      | LastName | DistrictId |
	  | 1  | VET  | Frank    | Password | A12345rf | 70258688 | 946401234 | frank@outlook.com | Francisco | Voularte | 1          |
@advertisement2-adding
Scenario: Add An Advertisement
	When A Post Request of Advertisement is sent
	  | DateTime         | Title           | Description     | Discount | UrlToImage                                                           | Promoted | UserId |
	  | 29/09/2021 16:20 | this is a title | add description | 10       | https://www.lasamarillasdezipaquira.com/oc-content/uploads/1/352.jpg | true     | 1  |
	Then An Advertisement response with status 200 is received
	
	Scenario: Add An Advertisement with empty data
		When A Post Request of Advertisement is sent
		  | DateTime         | Title           | Description     | Discount | UrlToImage                                                           | Promoted | UserId |
		  | 29/09/2021 16:20 |                | add description | 10       | https://www.lasamarillasdezipaquira.com/oc-content/uploads/1/352.jpg | true     | 1      |
		Then An Advertisement response with status 400 is received
		
		Scenario: Add an Advertisement with the same Title
			Given An advertisement is already stored
			  | DateTime         | Title | Description     | Discount | UrlToImage                                                           | Promoted | UserId |
			  | 29/09/2021 16:20 |hola| add description | 10       | https://www.lasamarillasdezipaquira.com/oc-content/uploads/1/352.jpg | true     | 1      | 
			When A Post Request of Advertisement is sent
			  | DateTime         | Title          | Description     | Discount | UrlToImage                                                           | Promoted | UserId |
			  | 29/09/2021 16:20 |hola| add description | 10       | https://www.lasamarillasdezipaquira.com/oc-content/uploads/1/352.jpg | true     | 2      |
			Then An Advertisement response with status 200 is received

		