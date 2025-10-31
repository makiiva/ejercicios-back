using ejercicioORM.Modelo;
using ejercicioORM.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ejercicioORM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NorthwindController : ControllerBase
    {
        private readonly INorthwindRepository _repository;
        public NorthwindController(INorthwindRepository repository)
        {
            this._repository = repository;
        }


        [HttpGet]

        [Route("api/TodosLosEmpleados")]

        public async Task<List<Employee>> GetAll()
        {

            return await _repository.ObtenerTodosLosEmpleados();

        }

        [HttpGet]
        [Route("api/CantidadEmpleados")]
        public async Task<int> GetCount()
        {
            return await _repository.ObtenerlaCantidadDeEmpleados();
        }


    }
}
