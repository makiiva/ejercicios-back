namespace WebApplication1.EjemploDYEmail
{
    public class UsuarioService
    {
        private readonly IEmailService _emailService;
        public UsuarioService(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public void RegistrarUsuario(string email)
        {
           
            _emailService.Enviar(email, "Enviado");
        }
    }
}
