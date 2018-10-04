using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_string
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Ejercicios STRING:
            ////Ejercicio 1:
            ////Escribe un programa que te calcule la largura de un string.
            //string palabra;
            //palabra = Console.ReadLine();
            //Console.WriteLine(palabra.Length);


            //Ejercicio 2:
            //Escribe un programa que te separe los caracteres de un string
            //string palabra;
            //palabra = Console.ReadLine();
            //for (int i = 0; i < palabra.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Ejercicio 3:
            //Escribe un programa que te calcule el total de palabras que hay en un string.
            //string frase;
            //int palabras = 1;

            //Console.WriteLine("escriba una frase");
            //frase = Console.ReadLine();

            //for (int i = 0; i < frase.Length; i++)
            //{
            //    if (frase[i] == ' ')
            //    {
            //        palabras++;
            //    }
            //}


            //Ejercicio 4:
            //Escribe un programa que copia un string a otro string.
            //string a = "La odisea de Homero es una burla";
            //string b = "  ";
            //Console.WriteLine(a.Replace("odisea","  "));

            //string frase = "Las flores rojas";
            //string frase1 = "Son rosas";
            //Console.WriteLine("frase es: '{0}'", frase);
            //Console.WriteLine("frase1 es: '{0}'", frase1);
            //Console.WriteLine("\n la frase copiada es: ");
            //frase = String.Copy(frase1);
            //Console.WriteLine("frase es: '{0}'", frase);
            //Console.WriteLine("frase1 es: '{0}'", frase1);



            ////Ejercicio 5:
            ////Escribe un programa que nos cuente el número de vocales en un string.
            //string palabra;
            //int vocales = 0;
            //Console.WriteLine("escribe una palabra");
            //palabra = Console.ReadLine();

            //for (int i = 0; i < palabra.Length; i++)
            //{
            //    if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
            //    {
            //        vocales++;
            //    }
            //}
            //Console.WriteLine("La palabra " + palabra + " tiene " + vocales + " vocales");


            //Ejercicio 6:
            //Escribe un programa que devuelva un string en minúsculas en mayúsculas y al revés.
            //string palabra;
            //Console.WriteLine("inserte Palabra");
            //palabra = Console.ReadLine();
            //Console.WriteLine(palabra.ToUpper());
            //Console.WriteLine("inserte Palabra");
            //palabra = Console.ReadLine();
            //Console.WriteLine(palabra.ToLower());
            //Console.ReadLine();

            ////Ejercicio 7:
            ////Escribe un programa que evalúe si un string contiene la letra ‘r’.
            //string palabra;
            //palabra = Console.ReadLine();
            //if (palabra.Contains("r"))
            //    {
            //    Console.WriteLine("SI");
            //    }
            //else
            //    {
            //    Console.WriteLine("NO");
            //    }

            //Ejercicio 8:
            //Escribe un programa el que dada una frase sacará su carácter central. Nota:
            //Si la largura de la frase es par deberá sacar los dos caracteres centrales correspondientes.
            //Si es impar deberá sacar su único carácter central.

            // string frase;
            // Console.WriteLine("escriba una frase");
            // frase = Console.ReadLine();
            // int media = frase.Length/2;

            //if (frase.Length % 2 != 0)
            //     {
            //     Console.WriteLine(frase.Substring(media,1));
            //     }
            // else
            //     {
            //     Console.WriteLine(frase.Substring((media - 1),2));
            // }


            //Ejercicio 9:
            //Escribe un programa el cual analizará si la contraseña introducida es correcta o no. 
            //Para que la contraseña sea correcta deberá cumplir estas directivas:
            //Debe tener 8 caracteres como mínimo.
            //La contraseña deberá contener números.
            //Deberá contener al menos dos dígitos.

            //string contraseña;
            //int caracter = 0;
            //Console.WriteLine("escriba una contraseña");
            //contraseña = Console.ReadLine();

            //if (contraseña.Length > 8)
            //{
            //    for (int i = 0; i < contraseña.Length; i++)
            //    {
            //        if (char.IsDigit(contraseña[i]))
            //        {
            //            caracter++;
            //        }

            //    }

            //    if (caracter >= 2)
            //    {
            //        Console.WriteLine("la contraseña es correcta");
            //    }
            //    else
            //    {
            //        Console.WriteLine("la contraseña es incorrecta");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("la contraseña es incorrecta");
            //}

            //Con booleanos
            //bool correcto = false;
            //string contraseña;
            //int contador;
            //do
            //{
            //    Console.WriteLine("escriba una contraseña");
            //    contraseña = Console.ReadLine();
            //    if (contraseña.Length > 8)
            //    {
            //        for (int i = 0; i < contraseña.Length; i++)
            //        {
            //            if (char.IsDigit(contraseña[i]))
            //            {
            //                contador++;
            //                if (contador >=2)
            //                {
            //                    correcto = true;
            //                }
            //            }
            //        }

            //} while (correcto == false)
            // Console.ReadLine();

            //Ejercicio 10
            //Escribe un programa que al meter tres números por teclado identifique el mínimo y el máximo
            //(usa el método correspondiente). 
            int num, num1, num2, num3, num4;

            Console.WriteLine("inserte un numero");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserte otro numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserte otro numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Math.Max(num, num1);
            num4 = Math.Min(num, num1);
            Console.WriteLine("El numero maximo es: " + Math.Max(num3,num2));
            Console.WriteLine("El numero minimo es: " + Math.Min(num4,num2));


            //if (num > num1 && Mnum > num2)
            //{
            //    Console.WriteLine("el numero maximo es: " + num);
            //}
            //else if (num1 > num && num1 > num2)
            //{
            //    Console.WriteLine("el numero maximo es: " + num1);
            //}
            //else if (num2 > num && num2 > num1)
            //{
            //    Console.WriteLine("el numero maximo es: " + num1);
            //}
            //else if (num2 < num && num2 < num1)
            //{
            //    Console.WriteLine("el numero minimo es: " + num2);
            //}
            //else if (num1 > num && num1 > num2)
            //{
            //    Console.WriteLine("el numero minimo es: " + num1);
            //}
            //else
            //{
            //    Console.WriteLine("el numero minimo es: " + num);
            //}



            //for (int i = 0; ; i++)



            //Ejercicio 12
            //Escribe un programa que muestre la fecha de hoy.

            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Now.ToString("dd/mm/yyyy hh:mm"));
            //Console.WriteLine(DateTime.Today.ToString("yyyy/MM/dd"));
            //Console.WriteLine(DateTime.Today.ToString("dd/mm/yyyy"));


            Console.ReadLine();
        }
    }
}
