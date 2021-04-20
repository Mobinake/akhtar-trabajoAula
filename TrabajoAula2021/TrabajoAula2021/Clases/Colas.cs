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
            while (MiCola.Count() > 0)
            {
                Console.WriteLine(MiCola.Dequeue());
            }
        }

        public void InsertarCola(int valor)
        {
            MiCola.Enqueue(valor);
        }

        //variables
        Queue<int> MiCola = new Queue<int>();

    }
}

/*
3. Defina la clase COLA (en lenguaje C o C#) y defina también el método InsertaCola(), que
inserta elementos enteros a la cola.
Luego implemente el método ImprimeCola(), que imprime todos los elementos
contenidos en la cola para visualizarlos.
Tenga en cuenta todos los casos posibles. Si desea, puede utilizar su código ya
implementado en la tarea del 6 de abril, en su repositorio personal (trabajoAula)
Commitear en el repositorio trabajoAula del alumno. (4 ptos)
Agregar en la entrega del classroom cualquier información útil para el docente de modo a
que pueda ejecutar la solución sin inconvenientes. 
*/
