using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabajosEntity;
using System.Data;
using System.Data.SqlClient;

namespace TrabajosDao
{
    public class DaoCliente
    {
        private Conexion conexion = new Conexion();
        public List<Cliente> listarCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(conexion.strConexion());
            conn.Open();
            SqlCommand cmd = new SqlCommand("");

        }
    }
}
