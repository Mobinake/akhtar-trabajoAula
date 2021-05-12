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

        public void InsertarInt()
        {
            int suma = 0; float prom;

            Lista ListaNum = new Lista();
            //insertar enteros
            for (int i = 0; i < 25; i++)
            {
                Random random = new Random(DateTime.Now.Millisecond);
                int value = random.Next(100);
                suma = suma + value;
                Console.WriteLine("El numero a cargar es" + value);
            }
            prom = suma / 25;
            Console.WriteLine("\nLa suma es: " + suma);
            Console.WriteLine("El promedio es de: " + prom);
        }

        public string ListaLigada(int largo)
        {
            //generar lista de caracteres
            Random random = new Random();
            const string pal = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //cantidad devuelta definida por largo, 
            return new string(Enumerable.Repeat(pal, largo).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
