using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoAula2021.Login;
using TrabajoAula2021.Clases;

namespace TrabajoAula2021
{
    public class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login.Login());
            
        //Pilas en C#
            Console.WriteLine("Pilas:");
            Pilas MiPila = new Pilas();
            MiPila.ImprimirPilas();
           
        //Colas en C#
            Console.WriteLine("Colas: ");
            Colas MiCola = new Colas();
            MiCola.ImprimirColas();
            
        //Listas en C#
            Console.WriteLine("Listas: ");
            Lista ListaAlumnos = new Lista();
            ListaAlumnos.ImprimirLista();
            */

            //Primera parcial LP2, colas
            Console.WriteLine("Cola parcial:");
            Colas ColaParcial = new Colas();
            Console.WriteLine("Elementos a cargar:5 ");
            //carga los elementos y luego los imprime con la funcion imprimir
            for (int i = 0; i < 5; i++)
            {
                int valor = i;
                ColaParcial.InsertarCola(valor);
            }
            ColaParcial.ImprimirColas();

            //Primera parcial LP2, pilas
            Console.WriteLine("Pila Parcial: ");
            Pilas PilaParcial = new Pilas();
            Stack<int> PilaOriginal = new Stack<int>();
            //primero creamos la pila y la cargamos de elementos a comprobar
            PilaParcial.Cargar(PilaOriginal);
            Console.WriteLine("Cantidad de elementos de la pila: " + PilaOriginal.Count());
            Console.WriteLine("Ultimo elemento de la Pila: " + PilaOriginal.Last());
            Console.WriteLine("El valor devuelto por la funcion creada es:" + PilaParcial.CantValores(PilaOriginal, PilaOriginal.Count()));
            
            Console.WriteLine("final");//aqui poner un punto de interrupcion y ver la salida

            
        }
    }
}
