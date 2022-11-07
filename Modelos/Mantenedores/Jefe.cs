using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Mantenedores
{
    public class Jefe
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public Jefe(string rut, string nombre, string apellidos, string direccion, string telefono)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public Jefe()
        {


        }


    }
}
