Feature: PetServiceTest
    As a Developer
    I wan to add new Pet through API
    So that it is available when wanting to make publications.

@pet-adding
Scenario: Add Pet
    Given The Endpoint https://localhost:5001/api/v1/Pets is available
    When A Post Request is sent
      | Type | Name | Attention | Race    | Age | IsAdopted | UserId |
      | Can  | Lolo | Yes       | Pitbull | 2   | false     | 1      |
    Then A Response with Status 200 is received