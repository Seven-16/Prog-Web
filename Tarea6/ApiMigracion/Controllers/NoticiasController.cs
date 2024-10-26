using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class NoticiasController : ControllerBase {
    [HttpGet]
    public async Task<IActionResult> ObtenerNoticias() {
        using var client = new HttpClient();
        var response = await client.GetStringAsync("https://remolacha.net/wp-json/wp/v2/posts?search=migraci%C3%B3n&_fields=title,excerpt");
        return Content(response, "application/json");
    }
}
