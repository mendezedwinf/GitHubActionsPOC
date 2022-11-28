using Microsoft.AspNetCore.Mvc.Testing;
using System.Diagnostics.CodeAnalysis;
using WebApplication1;

namespace IntegrationTestHome;

public sealed class HomeTest
{
    //Integration Test of the HTTP home resource
    [Fact]
    [SuppressMessage("Usage", "CA2234: Pass system uri objects instead of strings", Justification = "URL isn't passed as variable, but as literal.")]
    public async Task HomeReturnsJson()
    {
        //ARRANGE
        await using var factory = new WebApplicationFactory<Startup>();
        var client = factory.CreateClient();

        //ACT
        using var request = new HttpRequestMessage(HttpMethod.Get, "");
        request.Headers.Accept.ParseAdd("application/json");
        var response = await client.SendAsync(request);

        //ASSERT
        Assert.True(response.IsSuccessStatusCode, $"Actual status code: {response.StatusCode}.");
        Assert.Equal("application/json", response.Content.Headers.ContentType?.MediaType);
    }
}