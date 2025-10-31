using ejercicioORM.Modelo;
using ejercicioORM.Query;
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

        [HttpGet]
        [Route("api/ObtenerEmpleadoPorNombre/{nombre}")]

        public async Task<Employee> ObtenerNombreEmpleado(string nombre)
        {
            return await _repository.ObtenerEmpleadoporNombre(nombre);
        }

        [HttpGet]
        [Route("api/ObtenerIdEmpleado/{id}")]

        public async Task<Employee> ObtenerIdEmpleado(int id)
        {
            return await _repository.ObtenerEmpleadoporId(id);
        }

        [HttpGet]
        [Route("api/EmpleadoPorTitulo/{titulo}")]
        public async Task<int> ObtenerEmpleadoPorTitulo(string titulo)
        {
            return await _repository.ObtenerEmpleadoPorTitulo(titulo);
        }


        [HttpGet]
        [Route("api/EmpleadoPorCountry/{country}")]
        public async Task<Employee> ObtenerEmpleadoPorPais(string country)
        {
            return await _repository.ObtenerEmpleadoporCountry(country);
        }

        [HttpGet]
        [Route("api/ObtenerEmpleadosPorTitulos/{titulo}")]
        public async Task<List<Employee>> ObtenerEmpleadosPorTitulos(string titulo)
        {
            return await _repository.ObtenerEmpleadoPorTitulos(titulo);
        }

        [HttpGet]
        [Route("api/EmpleadoMasGrande")]

        public async Task<Employee> ObtenerEmpleadoMasGrande()
        {
            return await _repository.ObtenerEmpleadoMasGrande();
        }

        [HttpGet]
        [Route("api/ProductosQueContienen/{palabra}")]
        public async Task<List<Products>> ObtenerProductosQueContienen(string palabra)
        {
            return await _repository.ObtenerProductosQueContienen(palabra);
        }

        [HttpGet]
        [Route("api/ProductosConCategoria")]
        public async Task<ActionResult<List<ProductWithCategoryDTO>>> ObtenerProductosConCategoria()
        {
            return await _repository.ObtenerProductosConCategoria();
        }

    }
}
