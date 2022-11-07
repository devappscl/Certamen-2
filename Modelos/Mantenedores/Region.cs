using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Mantenedores
{
    internal class Region
    {
        public int numero_region { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }

        public Region(int numero_region, string nombre, string ubicacion)
        {
            this.numero_region = numero_region;
            this.nombre = nombre;
            this.ubicacion = ubicacion;
        }

        public Region()
        {

        }
    }
}
