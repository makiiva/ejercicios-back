using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjerciciosController : ControllerBase
    {
        private static List<string> instruments = new() { "Guitarra", "Batería", "Piano" };
        // GET: api/<EjerciciosController>

        
        [HttpGet] 
        public IEnumerable<string> Get()
        {
            return instruments;
        }

        // GET api/<EjerciciosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EjerciciosController>
        [HttpPost] 
        public ActionResult<string> AddInstrument([FromBody] string newInstrument)

        {
            instruments.Add(newInstrument);
            return Ok("Instrumento agregado: {newInstrument}");
        }

        // PUT api/<EjerciciosController>/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] string updatedInstrument)
        {
            if (id <= instruments.Count) {
                instruments[id] = updatedInstrument;
                return Ok($"Instrumento en la posicion {id} actualizado a {updatedInstrument}");
            }

            else
            {
                return BadRequest("No existe un instrumento con ese id");
            }
            

        }

        // DELETE api/<EjerciciosController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id<= instruments.Count)
            {
                var eliminado = instruments[id];
                instruments.RemoveAt(id);
                return Ok($"Instrumento eliminado: {eliminado}");

            }
            else
            {
                return BadRequest("No existe el id ingresado");
            }

        }

    }
}
