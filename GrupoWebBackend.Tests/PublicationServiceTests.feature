Feature: PublicationServiceTests
As a Developer
I wan to add a new Publication through API
So that it is available when wanting to see my publications.
    Background: 
        Given the endpoint https://localhost:5001/api/v1/publications is available
       # And A User is already stored    
       #   | Id | Type | UserNick | Pass       | Ruc   | Dni   | Phone     | Email          | Name    | LastName | DistrictId |
       #   | 1  | VET  | Frank    | Don't know | 74544 | 65454 | 951083038 | ricaordo@gmail | Ricardo | Yalico   | 1          |

    @publication-adding
    Scenario: Post a publication 
        When A publication is sent
        | PetId | UserId | DateTime         | Comment                |
        | 1     | 1      | 29/09/2021 16:20 | This is a test comment |    
        Then a response with status 200 is received
      
    Scenario: Post a publication go wrong
        When A publication is sent
          | petId | userId | dateTime         | conment                |
          | 1     | 1      | 29/09/2021 16:20 | This is a test comment |    
        Then a response with status 400 is received
