using System.ComponentModel.DataAnnotations;

namespace ejercicioORM.Modelo
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }
    }
}
