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
   public class dbAutomivil
    {
        private string ConStr = Connection.StringConnection;

        public List<Automovil> Getlist()
        {
            List<Automovil> list = new List<Automovil>();
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConStr;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SP_Automovil_GETALL";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Automovil au = new Automovil();
                    au.Id = int.Parse(dr["Id"].ToString());
                    au.Marca = dr["Marca"].ToString();
                    au.SubMarca = dr["SubMarca"].ToString();
                    au.NumeroMotor = float.Parse(dr["NumeroMotor"].ToString());
                    au.NumeroSerie = int.Parse(dr["NumeroSerie"].ToString());
                    au.Color = dr["Color"].ToString();
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


