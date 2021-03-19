using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARBOGRES_SAS
{
    public class Material
    {
        
        
            
        public string Fecha { get; set; }
        public string Hora { get; set; }

        public string Materiales { get; set; }
        public int Cantidad { get; set; }

        public string Vehiculo { get; set; }
        public string Observaciones { get; set; }



        public Material() { }

        public Material(string pFecha, string pHora, string pMateriales, int pCantidad, string pVehiculo, string pObservaciones)
        {
            this.Fecha = pFecha;
            this.Hora = pHora;
            this.Materiales = pMateriales;
            this.Cantidad = pCantidad;
            this.Vehiculo = pVehiculo;
            this.Observaciones = pObservaciones;

        }
    }
}



    