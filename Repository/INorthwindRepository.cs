using ejercicioORM.Modelo;
using ejercicioORM.Query;
using Microsoft.AspNetCore.Mvc;

namespace ejercicioORM.Repository
{
    public interface INorthwindRepository

    {
        Task<List<Employee>> ObtenerTodosLosEmpleados();

        Task<int> ObtenerlaCantidadDeEmpleados();

        Task<Employee> ObtenerEmpleadoporNombre(string nombre);

        Task<Employee> ObtenerEmpleadoporId(int id);

        Task<int> ObtenerEmpleadoPorTitulo(string titulo);

        Task<Employee> ObtenerEmpleadoporCountry(string country);

        Task<List<Employee>> ObtenerEmpleadoPorTitulos(string titulo);

        Task<Employee> ObtenerEmpleadoMasGrande();

        Task<List<Products>> ObtenerProductosQueContienen(string palabra);

        Task<ActionResult<List<ProductWithCategoryDTO>>> ObtenerProductosConCategoria();

    }

}
