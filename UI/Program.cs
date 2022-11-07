using Datos;
using Modelos.Mantenedores;
using Negocio.Mantenedores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BIENVENIDO AL MANTENEDOR PARA CARGOS");
            Console.WriteLine();
            Console.WriteLine("INGRESE UNA OPCIÓN DEL MENÚ");
            Console.WriteLine();
            Console.WriteLine("1. INGRESAR UN CARGO");
            Console.WriteLine("2. LISTAR LOS CARGOS");
            
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.Clear();
                Console.WriteLine("INGRESANDO NUEVO CARGO");
                Console.WriteLine();

                Cargo ncargo = new Cargo();

                Console.WriteLine("ID DEL CARGO: ");
                ncargo.codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("NOMBRE DEL CARGO: ");
                ncargo.nombre = Console.ReadLine();

                CargoBL cargosql = new CargoBL();

                string res = cargosql.Create(ncargo).mensaje;

                Console.WriteLine();
                Console.WriteLine("MENSAJE DEL SISTEMA: ");
                Console.WriteLine(res);
                
            }
            else if (op == 2)
            {
                Console.Clear();
                Console.WriteLine("LISTADO DE CARGOS");
                Console.WriteLine();


                CargoBL cargosql = new CargoBL();

                foreach (DataRow row in cargosql.getCargos().Rows)
                {
                    Console.WriteLine(row["codigo"].ToString() + " -> " + row["nombre"].ToString());
                }

            }
            else
            {
                Console.WriteLine("NO existe esa opción. Hasta luego");
            }


            Console.ReadKey();
            
            
            
            
            
            
            
            


            
            
        }
    }
}
