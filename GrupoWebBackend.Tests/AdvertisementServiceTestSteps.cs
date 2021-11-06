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
    public class AdvertisementServiceTestSteps:WebApplicationFactory<Startup>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private HttpClient _client;
        private Uri _baseUri;
        private ConfiguredTaskAwaitable<HttpResponseMessage> Response
        {
            get;
            set;
        }
        public AdvertisementServiceTestSteps(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }
        [Given(@"the endpoint https://localhost:(.*)/api/v(.*)/Advertisements is available")]
        public void GivenTheEndpointHttpsLocalhostApiVAdvertisementsIsAvailable(int port, int version)
        {
            _baseUri = new Uri($"https://localhost:{port}/api/v{version}/Advertisements");
            _client = _factory.CreateClient(new WebApplicationFactoryClientOptions{BaseAddress = _baseUri});
        }

        [When(@"an advertisement is sent")]
        public void WhenAnAdvertisementIsSent(Table savePostResource)
        {
            var resource = savePostResource.CreateSet<SaveAdvertisementResource>().First();
            var content = new StringContent(resource.ToJson(), Encoding.UTF8, "application/json");
            Response = _client.PostAsync(_baseUri, content).ConfigureAwait(false);
        }

        [Then(@"a response with status (.*) is recieved")]
        public void ThenAResponseWithStatusIsRecieved(int expectedStatus)
        {
            HttpStatusCode statusCode = (HttpStatusCode) expectedStatus;
            Assert.AreEqual(statusCode.ToString(), Response.GetAwaiter().GetResult().StatusCode.ToString());
        }
    }
}