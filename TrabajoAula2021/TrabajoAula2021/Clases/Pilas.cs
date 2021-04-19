using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAula2021.Clases
{
    public class Pilas
    {
        public Pilas()
        {

        }

        public void ImprimirPilas()
        {
            Stack<string> MiPila = new Stack<string>();
            MiPila.Push("Hola");
            MiPila.Push("Buendia");
            MiPila.Push("Atun");
            while (MiPila.Count > 0)
            {
                Console.WriteLine(MiPila.Pop());
            }
        }
        
    }
}
