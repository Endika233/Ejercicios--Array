using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Haz un programa que escriba tu nombre al reves//usaremos arrays
            //string nombre = "endika";
            //char[] arrayNombre = nombre.ToCharArray();//declaras un array y conviertes el string en carácteres,
            ////cada carácter ocupara hueco en el array y queda asignado el número que tiene.
            //Array.Reverse(arrayNombre);//esta funcion da la vuelta a los carácteres del array.
            //Console.Write(arrayNombre);


            ////Crear un array de 10 ints. Asignar un valor a cada uno de las 10 posiciones. 
            ////Mostrar los 10 valores en pantalla.
            //int[] numeros = {1,2,3,4,5,6,7,8,9,10 };//Al darle los valores no hace falta numerar
            //for (int i = 0; i < numeros.Length; i++)//i que empieze de 0 porque si no se saltaría el primer número
            //{
            //    Console.WriteLine(numeros[i]);//i es la posicion que escribe
            //}
            //Console.ReadKey();


            ////Crear un array de 3 strings. Pedir al usuario 3 veces que escriba un string. 
            ////Guardar cada uno de esos strings en la posición 0 , 1 y 2.
            ////Mostrar en pantalla en el orden: primero posición 1, después posición 2 y por último posicion 0.
            //string pal1, pal2, pal3;
            //Console.WriteLine("Escribe 1 palabra");
            //pal1=Console.ReadLine();
            //Console.WriteLine("Escribe otra palabra");
            //pal2 = Console.ReadLine();
            //Console.WriteLine("Escribe otra palabra");
            //pal3 = Console.ReadLine();
            //string[] arrayPal = { pal1, pal2, pal3 };
            //Console.WriteLine(arrayPal[1]);
            //Console.WriteLine(arrayPal[2]);
            //Console.WriteLine(arrayPal[0]);


            ////Crear un array de 10 ints. Usar un for para asignar los valores de 20 a 11 a las 10 posiciones 
            ////(en orden descendente). Usar un for para mostrar los 10 valores en pantalla.
            //int[] arrayNum=new int [10];//Declaramos el array y le damos un "valor" de 10 espacios (si no no dejaria usarlo en el for)
            //int num = 20;
            //for(int i = 0; i < 10; i++)
            //{
            //    arrayNum[i] = num;
            //    num = num - 1;
            //}
            //for(int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine(arrayNum[j]);
            //}



            ////Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores
            ////a cada una de las posiciones. Usar otro for para mostrarlos en pantalla.
            //int[] arrayNums = new int[3];
            //Console.WriteLine("Introduzca un valor");
            //arrayNums[0] = Int32.Parse(Console.ReadLine());
            //for(int i = 1; i < arrayNums.Length; i++)
            //{
            //    Console.WriteLine("Introduza otro valor");
            //    arrayNums[i] = Int32.Parse(Console.ReadLine());
            //}
            //Console.Write("Los valores introducidos son ");
            //for(int j = 0; j < arrayNums.Length; j++)
            //{
            //    if (j == 2)//Cuando llegue al ultimo valor(si tiene 3 espacios sera el 2 al contar desde 0)
            //    {
            //        Console.Write("y ");
            //    }
            //    Console.Write(arrayNums[j] + " ");
            //}



            //Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores 
            //a cada una de las posiciones. Mirar los valores del array una vez tenga los 3 valores 
            //y mostrar en pantalla el más pequeño.
            int[] arrayNums = new int[3];
            Console.WriteLine("Introduzca un valor");
            arrayNums[0] = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < arrayNums.Length; i++)
            {
                Console.WriteLine("Introduza otro valor");
                arrayNums[i] = Int32.Parse(Console.ReadLine());
            }








            Console.ReadKey();


        }
    }
}
