using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string texto1 = "Bienvenidos ";
            //string texto2 = "a C#";

            //texto1 += texto2;

            //Console.WriteLine(texto1);

            //int num1 = 5;
            //int num2 = 10;

            //num1 += num2;

            //Console.WriteLine(num1);

            //Random num = new Random();
            //int numAleatorio = num.Next(1, 101);

            //Console.WriteLine($"El numero aleatorio es: {numAleatorio}");

            //if (numAleatorio==30)
            //{
            //    Console.WriteLine("Ganaste");
            //} else {
            //    Console.WriteLine("Segui participando");
            //} 

            // Vectores o Array, forma 1

            int[] numeros = new int[4]; //defino lugares y el vector

            numeros[0] = 12; //asigno cada una de las posiciones
            numeros[1] = -23; //con sus respectivos valores
            numeros[2] = 56;
            numeros[3] = -10;

            // forma 2

            int[] numeros2 = new int[5] {10,80,-5,-57,56};

            // forma 3 - forma implicita

            int[] numeros3 = {42,-12,84,75};

            //----------------------------------------

            string[] nombres = { "Ricado", "Mirta", "Alvaro", "Diego", "Josefina" };

            bool[] estados = { true, false, false, false, true };

            Console.WriteLine("Nuestro amigo/a se llama: "+nombres[3]);


             //for para itetar o recorrer un vector:

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}

            //-------------------------------------------

            //foreach ({Para cada} uno):

            //foreach (int numero in numeros2)
            //{
            //    Console.WriteLine(numero);
            //}

            Console.ReadKey();
        }
    }
}
