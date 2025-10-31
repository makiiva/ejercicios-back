using ejercicioORM.Data;
using ejercicioORM.Modelo;
using ejercicioORM.Query;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<Employee> ObtenerEmpleadoporId(int id)
        {
            return await this._context.Employees.FirstOrDefaultAsync(e => e.EmployeeID == id);
        }

        public async Task<Employee> ObtenerEmpleadoporNombre(string nombre)
        {
            return await this._context.Employees.FirstOrDefaultAsync(e => e.FirstName == nombre);
        }

        public async Task<int> ObtenerEmpleadoPorTitulo(string titulo) 
        {
            var result = from emp in _context.Employees
                         where emp.Title == titulo
                         select emp.EmployeeID;
            return await result.FirstOrDefaultAsync();
        }

        public async Task<Employee> ObtenerEmpleadoporCountry(string country)
        {
            var result = from emp in _context.Employees
                         where emp.Country == country
                         select new Employee
                         {
                             FirstName = emp.FirstName,
                             LastName = emp.LastName,
                             Country = emp.Country
                         };
            return await result.FirstOrDefaultAsync();
        }

        public async Task<List<Employee>> ObtenerEmpleadoPorTitulos(string titulo)
        {
            var result = from emp in _context.Employees
                         where emp.Title == titulo
                         orderby emp.FirstName                         
                         select emp;
            return await result.ToListAsync();
        }

        public async Task<Employee> ObtenerEmpleadoMasGrande()
        {
            var result = from emp in _context.Employees
                         orderby emp.BirthDate descending
                         select emp;
            return await result.FirstOrDefaultAsync();
        }

        public async Task<List<Products>> ObtenerProductosQueContienen(string palabra)
        {
            return await _context.Products
                .Where(p => p.ProductName.Contains(palabra))
                .ToListAsync();
        }
        public async Task<ActionResult<List<ProductWithCategoryDTO>>>ObtenerProductosConCategoria()
        {
            var result = await( from prod in _context.Products
                         join cat in _context.Categories
                         on prod.CategoryID equals cat.CategoryID
                         select new ProductWithCategoryDTO
                         {
                             ProductID = prod.ProductID,
                             ProductName = prod.ProductName,
                             CategoryName = cat.CategoryName
                         }).ToListAsync();
            return result;
        }


    }
}
