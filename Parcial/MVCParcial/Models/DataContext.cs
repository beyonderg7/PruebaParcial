using System.Data.Entity;

namespace MVCParcial.Models
{
    public class DataContext:DbContext
    {


        public DataContext():base("DefaultConnection")
        {



        }

        public System.Data.Entity.DbSet<MVCParcial.Model.Product> Products { get; set; }
    }
}