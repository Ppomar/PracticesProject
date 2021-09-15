using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class daPersona
    {

        private string ConStr = Connection.StringConnection;

        public List<Persona> Getlist()
        {
            List<Persona> list = new List<Persona>();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConStr;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SP_Persona_GETALL";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Persona P = new Persona();
                    P.Id = int.Parse(dr["Id"].ToString());
                    P.Nombre = dr["Nombre"].ToString();
                    P.ApellidoPaterno = dr["ApellidoMaterno"].ToString();
                    P.ApellidoMaterno = dr["ApellidoMaterno"].ToString();
                    P.Edad = int.Parse(dr["Edad"].ToString());
                    P.FechaDNacimiento = dr["FechaDNacimiento"].ToString();
                    P.Nacionalidad = dr["Nacionalidad"].ToString();
                    list.Add(P);
                }
            }
            catch( Exception e)
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
