using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using GrupoWebBackend.Resources;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using SpecFlow.Internal.Json;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace GrupoWebBackend.Tests
{
    [Binding]
    public class PetServiceTestSteps: WebApplicationFactory<Startup>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private HttpClient _client;
        private Uri _baseUri;
        private ConfiguredTaskAwaitable<HttpResponseMessage> Response { get; set; }

        public PetServiceTestSteps(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }
        
        [Given(@"The Endpoint https://localhost:(.*)/api/v(.*)/Pets is available")]
        public void GivenTheEndpointHttpLocalhostApiVPetsIsAvailable(int port, int version)
        {
            _baseUri = new Uri($"https://localhost:{port}/api/v{version}/Pets");
            _client = _factory.CreateClient(new WebApplicationFactoryClientOptions {BaseAddress = _baseUri});
        }
        
        [When(@"A Post Request is sent")]
        public void WhenAPostRequestIsSent(Table savePetResource)
        {
            var resource = savePetResource.CreateSet<SavePetResource>().First();
            var content = new StringContent(resource.ToJson(), Encoding.UTF8, "application/json");
            Response = _client.PostAsync(_baseUri, content).ConfigureAwait(false);
        }

        [Then(@"A Response with Status (.*) is received")]
        public void ThenAResponseWithStatusIsReceived(int expectedStatus)
        {
            HttpStatusCode statusCode = (HttpStatusCode)expectedStatus;
            Assert.AreEqual(statusCode.ToString(), Response.GetAwaiter().GetResult().StatusCode.ToString());
        }

    
    }
}