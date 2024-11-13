using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos.Repositorios
{
    public abstract class Repositorio
    {
        private readonly string ConnectionString;

        public Repositorio() 
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["ConeccionHistorial"].ToString();
        }
        protected SqlConnection GetConnection() 
        {
         return new SqlConnection(ConnectionString);
        }

    }
}
