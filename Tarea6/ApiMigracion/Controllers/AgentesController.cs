using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AgentesController : ControllerBase {
    [HttpPost("registro")]
    public IActionResult RegistrarAgente([FromBody] Agente agente) {
        // Código para registrar al agente (simulado)
        return Ok("Agente registrado exitosamente");
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel login) {
        // Código para validar el login (simulado)
        return Ok("Login exitoso");
    }
}
