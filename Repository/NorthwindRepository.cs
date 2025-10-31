using ejercicioORM.Data;
using ejercicioORM.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ejercicioORM.Repository


{
    public class NorthwindRepository : INorthwindRepository
    {
        private readonly DataContext _context;

        public NorthwindRepository(DataContext context)
        {
            this._context = context;
        }
        public async Task<List<Employee>> ObtenerTodosLosEmpleados()
        {
            return await this._context.Employees.ToListAsync();
        }

        public async Task<int> ObtenerlaCantidadDeEmpleados()
        {
            return await this._context.Employees.CountAsync();
        }

    }
}
