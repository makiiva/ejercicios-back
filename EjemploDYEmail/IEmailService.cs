namespace WebApplication1.EjemploDYEmail
{
    public interface IEmailService
    {
        void Enviar(string destinatario, string mensaje);
    }
}
