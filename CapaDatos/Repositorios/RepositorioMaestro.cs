using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public abstract class RepositorioMaestro:Repositorio
    {
        protected List<SqlParameter> Parametros;

        protected int ExecuteNonQuery(string transactSql) 
        {
            using (var conexion = GetConnection()) 
            {
                conexion.Open();
             using (var comando = new SqlCommand())
             {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter item in Parametros) 
                    {
                        comando.Parameters.Add(item);
                    }
                    int result = comando.ExecuteNonQuery();
                    Parametros.Clear();
                    return result;

             }
             
            }
        }
        protected DataTable ExecuteReader(string transactSql) 
        {
            using (var conexion = GetConnection()) 
            {
                conexion.Open();
                using (var comando = new SqlCommand()) 
                {
                 comando.Connection = conexion;
                 comando.CommandText = transactSql;
                 comando.CommandType = CommandType.Text;
                 SqlDataReader reader = comando.ExecuteReader();
                    using (var tabla = new DataTable()) 
                    {
                     tabla.Load(reader);
                     reader.Dispose();
                     return tabla;
                    }
                 
                }
            }
        }

        protected DataTable ExecuteReaderParam(string transactSql)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter iten in Parametros) 
                    {
                     comando.Parameters.Add(iten);
                    }

                    SqlDataReader reader = comando.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(reader);
                        reader.Dispose();
                        return tabla;
                    }

                }
            }
        }

    }
}
