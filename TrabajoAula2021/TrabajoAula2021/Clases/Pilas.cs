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
            string palabra;
            Stack<string> MiPila = new Stack<string>();
            MiPila.Push("LP2");
            MiPila.Push("BuenosDias");
            MiPila.Push("Hola");

            for(byte i = 3; i < 0; i--)
            {
                palabra = (string)MiPila.Pop();
                Console.WriteLine(palabra);
            }
        }
        
    }
}
