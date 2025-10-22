using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.EjemploDYEmail;

namespace WebApplication1.Controllers
{
    public class UsuarioService : ControllerBase
    {
        private readonly EjemploDYEmail.IEmailService _emailService;
        public UsuarioService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        // GET: EmailController
        [HttpGet("notificar")]
        public IActionResult NotificarUsuario(string email)
        {
             _emailService.Enviar(email, "Notificacion enviada");
            return Ok($"Notificacion enviada a {email}");
        }
    }
}
