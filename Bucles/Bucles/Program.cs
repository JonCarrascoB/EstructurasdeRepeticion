using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Ejemplo1: inserta un numero y que de la tabla de multiplicar hasta el 10
            //int i = 0; //la "i" es la variable para iterar y la iniciaremos desde 0
            //int num1;
            //Console.WriteLine("Introducir un numero");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //while (i < 11)  //introducimos el bucle
            //{
            //    Console.WriteLine(num1 + " x " + i + " = " + (num1 * i));
            //    i++; // aqui se indica que la i va subiendo de valor
            //}

            // Ejercicio 1 Programa que muestre los numeros del 1 al 100 con bucle while
            //int i = 1;
            //while (i <101)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            ////Ejemplo 2 con do while del ejercicio 1
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i <= 100);


            ////Ejercicio 2: Pedir numeros hasta que se meta uno negativo

            //int num1;
            //Console.WriteLine("introduzca numero");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //while (num1 >= -1)
            //{

            //    Console.WriteLine("introduzca otro numero");
            //    num1 = Convert.ToInt32(Console.ReadLine());
            //}

            // con do while para un ejercicio como este es más util este tipo de repetición, ya que no hay
            // que repetir las sentencias al introducir la variable num1 y tras while
            //int num1;
            //do
            //{
            //    Console.WriteLine("introduzca un numero");
            //    num1 = Convert.ToInt32(Console.ReadLine());
            //}
            //while (num1 > 0);
            //Console.WriteLine("El numero introducido es negativo");


            //// Ejemplo FOR (bucle) Sacar los numeros hasta el 10
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            // Ejercicio 3: Con For, pedir 4 numeros y escribir la suma total
            int suma = 0;
            int num;
            for (int i = 0; i < 4; i++) //i<4 nos dice que se van a meter 4 numeros
            {
                Console.WriteLine("pedir un numero");
                num = Convert.ToInt32(Console.ReadLine());
                suma = suma + num; // el valor suma se guarda con la suma anterior en cada bucle
            }
            Console.WriteLine("total: " + suma);
            Console.ReadLine();
        }
    }
}
