using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CARBOGRES_SAS
{
    public class MaterialDAL
    {
        public static int Agregar1(Material pMaterial)
        {
            int retorno = 0;
            using (SqlConnection conn = BdComun.Obtenerconexion())
            {
                SqlCommand comando = new SqlCommand(String.Format("Insert into TblMaterial (Fecha,Hora,Materiales,Cantidad,Vehiculo,Observaciones) values ('{0}','{1}','{2}','{3}','{4}','{5}')", pMaterial.Fecha, pMaterial.Hora, pMaterial.Materiales, pMaterial.Cantidad, pMaterial.Vehiculo, pMaterial.Observaciones), conn);
                retorno = comando.ExecuteNonQuery();
            }
            return retorno;

        }

        public static List <Material> BuscarMaterial (string pVehiculo, string pFecha, string pMateriales)
        {
            List<Material> lista = new List<Material>();
            using (SqlConnection conn = BdComun.Obtenerconexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select Fecha,Hora,Materiales,Cantidad,Vehiculo,Observaciones  From TblMaterial  Where Vehiculo like '%{0}%' and Fecha like '%{1}%' and Materiales like '%{2}%' ", pVehiculo,pFecha,pMateriales), conn);
                SqlDataReader reader = comando.ExecuteReader();


                while (reader.Read())
                {
                    Material pMaterial = new Material();

                    pMaterial.Fecha = reader.GetString(0);
                    pMaterial.Hora = reader.GetString(1);
                    pMaterial.Materiales = reader.GetString (2);
                    pMaterial.Cantidad = reader.GetInt32 (3) ;
                    pMaterial.Vehiculo = reader.GetString(4);
                    pMaterial.Observaciones = reader.GetString(5);

                  

                    lista.Add(pMaterial);



                }
                conn.Close();
                return lista;
            }

        }
    }
}

