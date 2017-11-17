using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EJ1
{   
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class AgendaContext : DbContext
    {
       public  DbSet<Persona> Personas { get; set; }
       public DbSet <Telefono> Telefonos { get; set; }

       public AgendaContext():base("MyContext") { }
    }
}
