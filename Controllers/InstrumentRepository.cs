namespace WebApplication1.Controllers
{
    public class InstrumentRepository
    {
        public static List<string> Instruments { get; set; }
        static InstrumentRepository()
        {
            Instruments = new List<string>
            {
                "Guitarra",
                "Bateria",
                "Piano"
            };
        }
    }
}
