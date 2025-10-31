using ejercicioORM.Modelo;

namespace ejercicioORM.Repository
{
    public interface INorthwindRepository

    {
        Task<List<Employee>> ObtenerTodosLosEmpleados();

        Task<int> ObtenerlaCantidadDeEmpleados();

    }

}
