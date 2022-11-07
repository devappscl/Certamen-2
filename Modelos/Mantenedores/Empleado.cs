using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Mantenedores
{
    public class Empleado
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public Cargo cargo { get; set; }
        public Departamento departamento { get; set; }
        public Jefe jefe { get; set; }

        public Empleado(string rut, string nombre, string apellidos, string direccion, string telefono, Jefe jefe)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
            cargo = new Cargo();
            departamento = new Departamento();
            this.jefe = jefe;
        }
        public void asignaCargo(Cargo cargo)
        {

            this.cargo = cargo;
        }


        public void asignaDepartamento(Departamento departamento)
        {

            this.departamento = departamento;
        }

        public void asignaJefe(Jefe jefe)
        {

            this.jefe = jefe;

        }

        public Empleado()
        {
        }
    }
}
