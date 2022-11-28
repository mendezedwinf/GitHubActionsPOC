using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1;

namespace IntegrationTestHome
{
    public sealed class ReservationsTests
    {

    //    [Fact]
    //    public async Task PostValidReservation() 
    //    {
    //        var response = await PostReservation(new { 
    //            date = "2023-03-10 19:00",
    //            email = "edwin@example.com",
    //            name = "Edwin Mendez",
    //            quantity = 2
    //        });

    //        Assert.True(response.IsSuccessStatusCode, $"Actual status code: {response.StatusCode}.");
    //    }

    //    [SuppressMessage("Usage", "CA2234: Pass system uri objects instead of strings", Justification = "URL isn't passed as variable, but as literal.")]
    //    private async Task<HttpResponseMessage> PostReservation(object reservation)
    //    {
    //        using var factory = new WebApplicationFactory<Startup>();
    //        var client = factory.CreateClient();

    //        string json = JsonSerializer.Serialize(reservation);
    //        using var content = new StringContent(json);
    //        content.Headers.ContentType.MediaType = "applicaiton/json";
    //        return await client.PostAsync("reservations", content);
    //    }    
    //}
}
