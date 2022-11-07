using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Mantenedores
{
    public class Departamento
    {
        public int cod_departamento { get; set; }
        public string nombre { get; set; }

        public Departamento(int cod_departamento, string nombre)
        {
            this.cod_departamento = cod_departamento;
            this.nombre = nombre;
        }

        public Departamento()
        {

        }
    }
}
