using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARBOGRES_SAS
{
    public class Personal
    {
        
            
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Cedula { get; set; }
        public string Cargo { get; set; }


        public Personal() { }

        public Personal(string pNombre, string pApellido, string pCedula, string pCargo)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Cedula = pCedula;
            this.Cargo = pCargo;

        }
    }
}


