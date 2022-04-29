using Xunit;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace Shop.Test.API;

public class ShopApplicationTextCase : IClassFixture<ShopWebApplicationFactory<Program>>
{
    private readonly ShopWebApplicationFactory<Program> _factory;
    private readonly HttpClient _client;

    public ShopApplicationTextCase(ShopWebApplicationFactory<Program> factory)
    {
        _factory = factory;
        _client = _factory.CreateClient();
    }

    protected async Task AssertRequestWithBody(HttpMethod method, string endpoint,
        int expectedStatusCode)
    {
        using var request = new HttpRequestMessage
        {
            Method = method,
            RequestUri = new Uri(endpoint, UriKind.Relative),
        };

        var response = await _client.SendAsync(request);

        Assert.Equal(expectedStatusCode, (int)response.StatusCode);
    }

    protected async Task AssertResponse(HttpMethod method, string endpoint,
        int expectedStatusCode, string expectedResponse)
    {
        using var request = new HttpRequestMessage
        {
            Method = method,
            RequestUri = new Uri(endpoint, UriKind.Relative)
        };
        var response = await _client.SendAsync(request);
        var result = response.Content.ReadAsStringAsync().Result;
        Assert.Equal(expectedStatusCode, (int)response.StatusCode);
        Assert.Equal(expectedResponse, result);
    }
}