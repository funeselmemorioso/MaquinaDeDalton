using System;
using System.Collections.Generic;

namespace maquinaGalton
{
    class Program
    {
        static Random nAleat = new Random();
        static int cantidadFilas = 10; // Filas que tendrá el triángulo
        static int cantidadBolitas = 10000;
        static int[] totales = new int[cantidadFilas];

        static void Main(string[] args)
        {
            for (int a = 0; a < cantidadBolitas; a++)
            {
                Dictionary<int, int> turnos = new Dictionary<int, int>();    
                int valor = 0; // Valor es la posición a la que la bolita se moverá
                int numeroAleatorio = 0;
                int posicionQueFinalizoLaBolita = 0;

                for (int fila = 0; fila < cantidadFilas; fila++)
                {
                    // La bolita sólo puede ir al mismo valor de posición de fila en que está o a dicho valor más uno
                    // este valor al que la bolita puede ir, viene de un random de 0 o 1
                    turnos.Add(fila, valor);
                    numeroAleatorio = nAleat.Next(0, 2);
                    valor += numeroAleatorio; 
                }
               
                posicionQueFinalizoLaBolita = turnos[turnos.Count - 1];
                totales[posicionQueFinalizoLaBolita]++;
            }

            mostrarResultado();
        }

        static void mostrarResultado()
        {
            for (int i = 0; i < totales.Length; i++){ Console.Write(totales[i].ToString() + " - "); }
            Console.ReadLine();
        }
    }
}
