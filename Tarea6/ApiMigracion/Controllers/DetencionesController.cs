using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class DetencionesController : ControllerBase {
    [HttpPost]
    public IActionResult RegistrarDetencion([FromBody] Detencion detencion) {
        var numeroConfirmacion = new Random().Next(1000, 9999); // Generación de ID aleatorio
        return Ok(new { IdConfirmacion = numeroConfirmacion });
    }
}
