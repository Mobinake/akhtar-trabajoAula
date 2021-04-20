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

        public void Cargar(Stack<int> PilaParcial)
        {
            //cargar valores en la pila
            PilaParcial.Push(1);
            PilaParcial.Push(2);
            PilaParcial.Push(3);
            PilaParcial.Push(4);
            PilaParcial.Push(5);
            PilaParcial.Push(9);
            PilaParcial.Push(10);

        }

        public int CantValores(Stack<int> pila, int tope)
        {
            //pila.last devuelve el ultimo elemento, y pila.count devuelve la cantidad de elementos de la pila
            if (pila.Last() > pila.Count())
            {
                return 1;
            }
            else if (pila.Last() == pila.Count())
            {
                return 0;
            }
            else if (pila.Last() < pila.Count())
            {
                return -1;
            }
            else
            {
                Console.WriteLine("Error");
                return 2;
            }    
        }
    }
}
/*
 4. Dada la pila P de números enteros, escribir una función o método (en lenguaje C o C#)
que reciba como parámetros: la pila P y el tope. La función debe calcular la cantidad de
valores que hay en la pila y retornar los siguientes valores:

a. 1 si el último número dentro de la pila es mayor que la cantidad de
elementos de la pila.
b. 0 si el último número dentro de la pila es igual a la cantidad de
elementos de la pila.
c. -1 si el último número dentro de la pila es menor que la cantidad de
elementos de la pila.
Tenga en cuenta todos los casos posibles. Si desea, puede utilizar su código ya
implementado en la tarea del 23 de marzo, en su repositorio personal (trabajoAula)
Commitear en el repositorio trabajoAula del alumno. (4 ptos)
Agregar en la entrega del classroom cualquier información útil para el docente de modo a
que pueda ejecutar la solución sin inconvenientes.
 */
