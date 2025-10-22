namespace WebApplication1.EjemploDYEmail
{
    public class EmailService: IEmailService
    {
        public void Enviar(string destinatario, string mensaje)
        {
            Console.WriteLine( $"Email enviado a {destinatario}: {mensaje}");
        }
    }
}
