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
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormLogin());

            //Pilas en C#
            Console.WriteLine("Pilas: ");
            Pilas MiPila = new Pilas();
            MiPila.ImprimirPilas();

            //Colas en C#
            Console.WriteLine("Colas: ");



            //Listas en C#
            Lista ListaAlumnos = new Lista();
            ListaAlumnos.ImprimirLista();
            

        }
    }
}
