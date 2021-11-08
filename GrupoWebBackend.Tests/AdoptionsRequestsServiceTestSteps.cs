using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using GrupoWebBackend.DomainAdoptionsRequests.Resources;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;
using SpecFlow.Internal.Json;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
namespace GrupoWebBackend.Tests
{
    [Binding]
    public class AdoptionsRequestsServiceTestSteps:WebApplicationFactory<Startup>
    {
        public AdoptionsRequestsServiceTestSteps(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        private readonly WebApplicationFactory<Startup> _factory;
        private HttpClient _client;
        private Uri _baseUri;

       

        private ConfiguredTaskAwaitable<HttpResponseMessage> Response
        {
            get;
            set;
        }

    
        
        [Given(@"the endpoint https://localhost:(.*)/api/v(.*)/AdoptionsRequests is available")]
        public void GivenTheEndpointHttpsLocalhostApiVAdoptionsRequestsIsAvailable(int port, int version)
        {
            _baseUri = new Uri($"https://localhost:{port}/api/v{version}/publications");
            _client = _factory.CreateClient(new WebApplicationFactoryClientOptions{BaseAddress = _baseUri});
        }

        [When(@"A adoptionsrequests is sent")]
        public void WhenAAdoptionsrequestsIsSent(Table savePostResource)
        {
            var resource = savePostResource.CreateSet<SaveAdoptionsRequestsResource>().First();
            var content = new StringContent(resource.ToJson(), Encoding.UTF8, "application/json");
            Response = _client.PostAsync(_baseUri, content).ConfigureAwait(false);
        }

        [Then(@"A response with status (.*) is received")]
        public void ThenAResponseWithStatusIsReceived(int expectedStatus)
        {
            HttpStatusCode statusCode = (HttpStatusCode) expectedStatus;
            //Assert.AreEqual(statusCode.ToString(), Response.GetAwaiter().GetResult().StatusCode.ToString());

        }
    }
}