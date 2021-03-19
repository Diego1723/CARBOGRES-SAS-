using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CARBOGRES_SAS
{
    public class PersonalDAL
    {
        public static int Agregar1(Personal pPersonal)
        {
            int retorno = 0;
            using (SqlConnection conn = BdComun.Obtenerconexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("Insert into TblRPersonal (Nombre,Apellido,Cedula,Cargo) values ('{0}','{1}','{2}','{3}')", pPersonal.Nombre, pPersonal.Apellido, pPersonal.Cedula, pPersonal.Cargo), conn);
                retorno = comando.ExecuteNonQuery();
            }
            return retorno;

        }

        public static List<Personal> BuscarPersona(string pCedula)
        {
            List<Personal> lista = new List<Personal>();
            using (SqlConnection conn = BdComun.Obtenerconexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Nombre,Apellido,Cedula,Cargo From TblRPersonal Where Cedula like '%{0}%' ", pCedula), conn);
                SqlDataReader reader = comando.ExecuteReader();


                while (reader.Read())
                {
                    Personal pPersona = new Personal();

                    pPersona.Nombre = reader.GetString(0);
                    pPersona.Apellido = reader.GetString(1);
                    pPersona.Cedula = reader.GetString(2);
                    pPersona.Cargo = reader.GetString(3);


                    lista.Add(pPersona);



                }
                conn.Close();
                return lista;
            }
        }
    }
}

