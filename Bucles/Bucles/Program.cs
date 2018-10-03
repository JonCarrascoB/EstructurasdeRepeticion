﻿using System;
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


            //// Ejercicio 3: Con For, pedir 4 numeros y escribir la suma total
            //int suma = 0;
            //int num;
            //for (int i = 0; i < 4; i++) //i<4 nos dice que se van a meter 4 numeros
            //{
            //    Console.WriteLine("pedir un numero");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    suma = suma + num; // el valor suma se guarda con la suma anterior en cada bucle
            //}
            //Console.WriteLine("total: " + suma);


            //Ejercicios bucles

            ////Escribe un programa que muestre en pantalla los números del 10 al 20 (incluidos los dos) con una línea vacía entre ellos.
            //int i = 10;
            //while (i <= 20)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine();
            //    i++;
            //}

            ////Escribe un programa que muestre en pantalla los números del 20 al 10 (incluidos los dos) con una línea vacía entre ellos.
            //int i = 20;
            //while (i >= 10)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine("\n");
            //    i--;


            ////Escribe un programa que pida 10 valores. Al final mostrar la media de esos valores.
            // int suma = 0;
            //    int media;
            //    int num;
            //    for (int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine("pedir numero");
            //        num = Convert.ToInt32(Console.ReadLine());
            //        suma = suma + num;
            //    }
            //    media = suma / 10;
            //    Console.WriteLine("la media total es: " + media);

            ////Ejercicio 4:
            ////Escribe un programa que pida valores hasta que el usuario introduzca un 0.
            ////Si introduce un valor negativo, mostrar un mensaje diciendo que se ignoran los valores negativos.
            ////Mostrar la suma de los valores introducidos.
            //int num;
            //int suma = 0;

            //do
            //{
            //    Console.WriteLine("pedir otro numero");
            //    num = Convert.ToInt32(Console.ReadLine());

            //    if (num < 0)
            //    {
            //        Console.WriteLine("se ignoran los valores negativos");
            //    }
            //    else

            //    suma = suma + num;
            //}
            //while (num != 0);
            //Console.WriteLine("la suma de los valores es: " + suma);


            ////Ejercicio 5:
            ////Escribe un programa que muestre todos los valores pares o impares entre 1 y 100 
            ////dependiendo de si el usuario introduce P o I.
            ////Si introduce otra cosa, decir que ese valor no es correcto y pedirle otra vez.

            //string respuesta = "";
            //while (respuesta != "P" && respuesta != "I")
            //{
            //    Console.WriteLine("Escribe P o I");
            //    respuesta = Console.ReadLine();
            //}
            //if (respuesta == "P")
            //{
            //    for (int i = 2; i < 101; i = i + 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    for (int i = 1; i < 101; i = i + 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            ////Ejercicio 6:
            ////Escribe un programa que pregunte al usuario su edad.
            ////Mostrar en pantalla “Feliz cumpleaños” repetido tantas veces como años tenga.
            //int edad;
            //Console.WriteLine("¿Cual es tu edad?");
            //edad = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i<edad; i++)
            //{
            //    Console.WriteLine("Feliz Cumpleaños");
            //}


            ////Ejercicio 7:
            ////Pedir al usuario un número. Mostrar en pantalla
            //// *
            //// **
            //// ***
            ////Con tantas líneas como el número que ha introducido
            //int num;
            //Console.WriteLine("introduce un numero");
            //num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //Ejercicio 8:
            //Escribe un programa que muestre los números de 1 a 12 en una columna.
            //En la columna de al lado de los números impares mostrar el cuadrado de ese valor y en la de los pares mostrar el cubo.

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine(i);
                if (i = i+2)
                {
                    Console.WriteLine("\t" + Math.Pow(i, 2));
                }
                else
                {
                    Console.WriteLine("\t" + Math.Pow(i, 3));
                }
            }

           Console.ReadLine();
        }
        
    }
}
