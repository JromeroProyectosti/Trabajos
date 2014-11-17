using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data;


namespace TrabajosDao
{
    class Conexion
    {
        public SqlConnection strConexion()
        {
         
            SqlConnection conn = new SqlConnection("Data Source=localhost;User ID=sa;Password=955763;Initial Catalog=Soporte");
           return conn;
        }

        public ArrayList QuerySql(String sql)
        {
            SqlCommand cmd;
            SqlConnection conn = strConexion();
            ArrayList arrConexion = new ArrayList();
            SqlDataReader drRegistros;

            conn.Open();
           
            cmd = new SqlCommand(sql, conn);
            drRegistros = cmd.ExecuteReader();
            arrConexion.Add(drRegistros);
            arrConexion.Add(conn);
            return arrConexion;

        }
        public int InsertUpdateSql(SqlCommand cmd, bool retornarId=false)
        {
            SqlConnection conn = strConexion();
            int id = 0;
            try
            {
                conn.Open();
                if (retornarId)
                {
                    id = (Int32) cmd.ExecuteScalar();
                }
                else
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return id;
        }
    }
}
