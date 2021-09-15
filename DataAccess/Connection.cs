using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Connection
    {
        public static string StringConnection = ConfigurationManager.ConnectionStrings["Connection"].ToString();
    }
}
