using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class dbAlumnos
    {
        private string ConStr = Connection.StringConnection;

        public List<Alumno> Getlist()
        {
            List<Alumno> list = new List<Alumno>();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConStr;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SP_Alumno_GETALL";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Alumno a = new Alumno();
                    a.Id = int.Parse(dr["Id"].ToString());
                    a.Nombre = dr["Nombre"].ToString();
                    a.ApellidoPaterno = dr["ApellidoPaterno"].ToString();
                    a.ApellidoMaterno = dr["ApellidoMaterno"].ToString();
                    a.NumeroDeControl = int.Parse(dr["NumeroDeControl"].ToString());
                    a.Carrera = dr["Carrera"].ToString();
                    a.Semestre = int.Parse(dr["Semestre"].ToString());
                    list.Add(a);
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                if(conn != null)
                {
                    conn.Close();
                }
            }
            return list;
        }
    }
}
