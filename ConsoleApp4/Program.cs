using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int nodo = 0;
                
Console.WriteLine("Escribe la cantidad de nodos");
                int nodes = int.Parse(Console.ReadLine());
                Metodos miGrafo = new Metodos(nodes);
                miGrafo.AdicionaArista(0, 1);
                miGrafo.AdicionaArista(0, 2);
                miGrafo.AdicionaArista(0, 3);
                miGrafo.AdicionaArista(1, 3);
                miGrafo.AdicionaArista(1, 4);
                miGrafo.AdicionaArista(2, 5);
                miGrafo.AdicionaArista(3, 2);
                miGrafo.AdicionaArista(3, 5);
                miGrafo.AdicionaArista(3, 6);
                miGrafo.AdicionaArista(4, 3);
                miGrafo.AdicionaArista(4, 6);
                miGrafo.AdicionaArista(6, 5);
            miGrafo.MuestraAdyacencia();
            miGrafo.CalcularIndegree();
            miGrafo.MostrarIndegree();

            Console.ForegroundColor = ConsoleColor.Cyan;
            do
            {
                // Encontramos el nodo con el indegree e
                nodo = miGrafo.Encuentraļ0();
                if (nodo != -1)
                {
                    // Imprimimos el nodo
                    Console.WriteLine("-> "+ nodo);
                    // Decrementamos los indegrees
                    miGrafo.DecrementaIndigree(nodo);
                }
            } while (nodo != -1) ;
                Console.WriteLine();



            Console.ReadKey();
            }
        }
}


