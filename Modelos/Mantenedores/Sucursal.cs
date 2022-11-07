using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Mantenedores
{
    internal class Sucursal
    {
        public int cod_sucursal { get; set; }
        public string nombre { get; set; }
        public Region region { get; set; }
        public string direccion { get; set; }

        public Sucursal(int cod_sucursal, string nombre, Region region, string direccion)
        {
            this.cod_sucursal = cod_sucursal;
            this.nombre = nombre;
            this.region = region;
            this.direccion = direccion;
        }

        public Sucursal()
        {

        }
    }
}
