using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAula2021.Clases
{
    public class Lista
    {
        public Lista()
        {
            
        }

        public void ImprimirLista()
        {

            string alumno = "Andres";
            List<string> ListaAlumnos = new List<string>();

            ListaAlumnos.Add("Edgar");
            ListaAlumnos.Add("Meli");
            ListaAlumnos.Add("Marcos");
            ListaAlumnos.Add("Mobin");
            ListaAlumnos.Add(alumno);

            foreach (string nombre in ListaAlumnos)
            {
                Console.WriteLine($"Nombre de alumnos: {nombre}");
            }
        }
    }
}
