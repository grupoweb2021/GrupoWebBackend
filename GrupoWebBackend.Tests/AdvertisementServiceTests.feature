Feature: AdvertisementServiceTests
As a vet
I want to promote mi vet clinic
So that I get more clients

    @advertisement-adding
    Scenario: Publish a vet clinic into the app
        Given the endpoint https://localhost:5001/api/v1/Advertisements is available
        When an advertisement is sent
          | DateTime         | Title           | Description     | Discount | UrlToImage                                                           | Promoted |
          | 29/09/2021 16:20 | this is a title | add description | 10       | https://www.lasamarillasdezipaquira.com/oc-content/uploads/1/352.jpg | true     |
        Then a response with status 200 is recieved