using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAula2021.Clases
{
    class Colas
    {
        public Colas()
        {

        }

        public void ImprimirColas()
        {
            Queue<string> MiCola = new Queue<string>();
            //cargando y ultimo elimina uno
            MiCola.Enqueue("Jose");
            MiCola.Enqueue("Paul");
            MiCola.Enqueue("Facu");

            while (MiCola.Count() > 0)
            {
                Console.WriteLine(MiCola.Dequeue());
            }
        }
}
}
