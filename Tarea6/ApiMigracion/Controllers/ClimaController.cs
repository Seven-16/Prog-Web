using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ClimaController : ControllerBase {
    [HttpGet]
    public async Task<IActionResult> ObtenerClima(double latitud, double longitud) {
        using var client = new HttpClient();
        var response = await client.GetStringAsync($"https://api.open-meteo.com/v1/forecast?latitude={latitud}&longitude={longitud}&daily=temperature_2m_max,temperature_2m_min");
        return Content(response, "application/json");
    }
}
