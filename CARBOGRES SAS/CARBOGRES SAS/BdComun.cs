using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CARBOGRES_SAS
{
    class BdComun
    {
        public static SqlConnection Obtenerconexion()
        {
            SqlConnection conn = new SqlConnection("data source = LAPTOP-R48K33BI\\SQLEXPRESS01 ; Initial catalog = CARBOGRES; integrated Security = true ");
            conn.Open();


            return conn;
        }
    }
}

