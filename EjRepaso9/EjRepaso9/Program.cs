using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjRepaso9
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Ejercicio IX
            //Crear una aplicación que pida al usuario su nombre e indique por pantalla “¡Hola,
            //*usuario * !” si ingresa su nombre, en caso contrario dirá “No te conozco”.
            //Por ejemplo, si el usuario es Suyai, e ingresa el nombre “Suyai” dirá “¡Hola, Suyai!”, si
            //no, “No te conozco”

            string usuario="Sabrina";
            string valor;

            Console.WriteLine("Ingrese su nombre");
            valor = Console.ReadLine();
            if (valor == usuario)
                Console.WriteLine("Hola "+ usuario+ "!");
            else
                Console.WriteLine("No te conozco");
            Console.ReadKey();
        }
    }
}
