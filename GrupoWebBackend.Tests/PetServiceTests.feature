Feature: PetServiceTest
As a Developer
I wan to add new Pet through API
So that it is available when wanting to make publications.
    
    Background: 
        Given The Endpoint https://localhost:5001/api/v1/Pets is available
        And A User is already stored    
          | Id | Type | UserNick | Pass       | Ruc   | Dni   | Phone     | Email          | Name    | LastName | DistrictId |
          | 1  | VET  | Frank    | Don't know | 74544 | 65454 | 951083038 | ricaordo@gmail | Ricardo | Yalico   | 1          |

@pet-adding
Scenario: Add Pet
    When A Post Request is sent
      | Type | Name | Attention | Race    | Age | IsAdopted | UserId |
      | Can  | Lolo | Yes       | Pitbull | 2   | false     | 1      |
    Then A Response with Status 200 is received
    And A Pet Resource is incluided in Response Body
      | Type | Name | Attention | Race    | Age | IsAdopted | UserId |
      | Can  | Lolo | Yes       | Pitbull | 2   | false     | 1      |
    
