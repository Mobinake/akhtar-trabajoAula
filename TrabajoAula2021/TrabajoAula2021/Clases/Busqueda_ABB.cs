using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAula2021.Clases
{
    class Nodo
    {
        public int info;
        public Nodo izq;
        public Nodo der;
    }
    class Busqueda_ABB //Arbol binario de busqueda --> binary search tree
    {
        
        Nodo raiz;

        public Busqueda_ABB()
        {
            raiz = null;
        }
        /*Creamos un nodo y disponemos los punteros izq y der a null, guardamos la información 
         * que llega al método en el nodo.*/

        public void Insertar(int info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null) //Si el árbol está vacío, apuntamos raíz al nodo creado;
                raiz = nuevo;
            else //en caso de no estar vacío, dentro de una estructura repetitiva vamos comparando info con la información del nodo, 
            {
                Nodo anterior = null, reco;
                reco = raiz;
                //si info es mayor a la del nodo descendemos por el subárbol derecho en caso contrario 
                //descendemos por el subárbol izquierdo.
                //Cuando se encuentra un subárbol vacío insertar el nodo en dicho subárbol. 
                //Para esto llevamos un puntero anterior dentro del while.
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.info)
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }

        public void Busqueda_ABB_Mobin(Nodo reco, int info)
        {
            if (reco.info < raiz.info)
            {
                if (raiz.izq == null)
                {
                    Console.WriteLine("El valor no se encuentra en el arbol. ");
                }
                else
                {
                    Busqueda_ABB_Mobin(reco, reco.info);
                }
            }
            else
            {
                if (reco.info > raiz.info)
                {
                    if (reco.der == null)
                    {
                        Console.WriteLine("El nodo no tiene ese valor. ");
                    }
                    else
                    {
                        Busqueda_ABB_Mobin(reco, reco.info);
                    }
                }
                else
                {
                    Console.WriteLine("El dato se encuentra en el arbol. ");
                }
            }
        }

        /*
        El método ImprimirPre(), es decir el no recursivo se encarga de llamar al método recursivo pasando la dirección del nodo raiz.
        El método recursivo void ImprimirPre (Nodo reco) lo primero que verifica con un if si reco está apuntando a un nodo 
        (esto es verdad si reco es distinto a null), en caso afirmativo ingresa al bloque del if y realiza:

        - Visitar la raiz --> imprimo el valor del nodo.
        - Recorrer el subárbol izquierdo en pre-orden (recursivo)
        - Recorrer el subárbol derecho en pre-orden (recursivo)
         
        La visita en este caso es la impresión de la información del nodo y los recorridos son las llamadas recursivas pasando las 
        direcciones de los subárboles izquierdo y derecho.
         */
        private void ImprimirPre(Nodo reco) //RECORRIDO
        {
            if (reco != null)
            {
                Console.Write(reco.info + " "); //--> muestro el valor en consola
                if (reco.info == 1000) // INFOR = 1000
                    Console.Write("Encontre el nodo buscado");

                ImprimirPre(reco.izq);  //--> le llamo recursivamente imprimirPre(reco.izq)
                ImprimirPre(reco.der);
            }
        }

        public void ImprimirPre()
        {
            ImprimirPre(raiz);
            Console.WriteLine();
        }

        //Los algoritmos de los recorridos en entreorden-inorden y postorden son similares. 
        //La diferencia es que la visita la realizamos entre las llamadas recursivas en el recorrido en entre orden:
        private void ImprimirEntre(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.info + " ");
                ImprimirEntre(reco.der);
            }
        }

        public void ImprimirEntre()
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }

        //y por último en el recorrido en postorden la visita la realizamos luego de las dos llamadas recursivas:
        private void ImprimirPost(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirPost(reco.izq);
                ImprimirPost(reco.der);
                Console.Write(reco.info + " ");
            }
        }


        public void ImprimirPost()
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }
    }
}
