using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentsController : ControllerBase
    {
       

        // GET: api/<EjerciciosController>
        [HttpGet] 
        public IEnumerable<string> Get()
        {
            return InstrumentRepository.Instruments;
        }

        // GET api/<EjerciciosController>/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < InstrumentRepository.Instruments.Count) {
                return BadRequest("No existe un instrumento con ese ID");
            }
            else
            {
                return Ok(InstrumentRepository.Instruments[id]);
            }
            
            
        }

        // POST api/<EjerciciosController>
        [HttpPost] 
        public ActionResult<string> AddInstrument([FromBody] string newInstrument)

        {
            InstrumentRepository.Instruments.Add(newInstrument);
            return Ok("Instrumento agregado: {newInstrument}");
        }

        // PUT api/<EjerciciosController>/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] string updatedInstrument)
        {
            if (id >= InstrumentRepository.Instruments.Count) {
                InstrumentRepository.Instruments[id] = updatedInstrument;
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
            if (id<= InstrumentRepository.Instruments.Count)
            {
                var eliminado = InstrumentRepository.Instruments[id];
                InstrumentRepository.Instruments.RemoveAt(id);
                return Ok($"Instrumento eliminado: {eliminado}");

            }
            else
            {
                return BadRequest("No existe el id ingresado");
            }

        }

    }
}
