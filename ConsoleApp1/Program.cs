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
            ////Aqui podrias poner Console.Write(arrayNum[i]);
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



            ////Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores 
            ////a cada una de las posiciones. Mirar los valores del array una vez tenga los 3 valores 
            ////y mostrar en pantalla el más pequeño.
            //////////************************Si creamos un comparador de un número muy bajo o muy alto y hacemos que se compare con todos los numeros en un for, solo cogerla el valor del mas bajo o algo.
            //int[] arrayNums = new int[3];
            //Console.WriteLine("Introduzca un valor");
            //arrayNums[0] = Int32.Parse(Console.ReadLine());
            //for (int i = 1; i < arrayNums.Length; i++)
            //{
            //    Console.WriteLine("Introduza otro valor");
            //    arrayNums[i] = Int32.Parse(Console.ReadLine());
            //}
            //if(arrayNums[0]==arrayNums[1]&& arrayNums[1] == arrayNums[2])
            //{
            //    Console.WriteLine("Todos los números son iguales");
            //}
            //else
            //{
            //    Console.Write("El número más pequeño es ");
            //    if (arrayNums[0] < arrayNums[1] && arrayNums[0] < arrayNums[2])//Acuerdate de usar && o ||, en parentesis solo no vale
            //    {
            //        Console.WriteLine(arrayNums[0]);
            //    }
            //    if (arrayNums[1] < arrayNums[0] && arrayNums[1] < arrayNums[2])
            //    {
            //        Console.WriteLine(arrayNums[1]);
            //    }
            //    if (arrayNums[2] < arrayNums[1] && arrayNums[2] < arrayNums[0])
            //    {
            //        Console.WriteLine(arrayNums[2]);
            //    }
            //}



            ////Poner los nombres de los meses en un array de 12. 
            ////Cuando el usuario introduce un número del 1 al 12, mostrar el nombre de ese mes en pantalla.
            //int elec;
            //string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };          
            //do
            //{
            //    Console.WriteLine("Introduzca un número de mes");
            //    elec = Int32.Parse(Console.ReadLine());
            //    if (elec < 13 && elec > 0)
            //    {
            //        Console.WriteLine("Es mes elegido es "+meses[(elec-1)]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Respuesta no válida");
            //    }
            //} while (elec<1|| elec >12);//Si alguna de las dos condiciones se cumple sera TRUE y seguira ejecutando
            ////Si directamente hubieras puesto un while que excluyera los menores de 0 y may. de 12 te habrias ahorrado el if
            ////y dentro de ese while "Ese num es incorrecto"

            ////Hacer la media de 10 valores utilizando un array.
            //int[] media = { 6, 4, 8, 2 };
            //int suma = 0;
            //for(int i = 0; i < media.Length; i++)
            //{
            //    suma = suma + media[i];
            //}
            //Console.WriteLine("La media es " + suma / media.Length);



            //Crear un array de 11 ints. Usar un for para asignar 0 a cada posición. 
            //Pedir al usuario que introduzca valores entre 0 y 10. 
            //Cada vez que introduzca un dígito, añadir uno al valor en esa posición del array. 
            //Si por ejemplo introduce un 3, sumar uno a la posición 3.
            //Si introduce un número mayor que 10, decir que ese número es incorrecto. 
            //Si introduce un número negativo, mostrar en pantalla el número de cada posición y el valor que contiene. 
            //int[] array = new int[11];
            //int numIn=0;
            //for(int i = 0; i < array.Length; i++)
            //{
            //    array[i] = 0;
            //}


            //do
            //{
            //    Console.WriteLine("Introduzca un valor del 0 al 10");
            //    numIn = Int32.Parse(Console.ReadLine());
            //    if (numIn > 10)
            //        {
            //            Console.WriteLine("\nEse número es incorrecto, introduzca otro número\n");
            //        }
            //    else if (numIn < 11 && numIn >= 0)
            //        {
            //            array[numIn] = array[numIn] + 1;// o solo escribir array[numIn]++
            //        }
            //} while (numIn > 0 );//Ejecuta mientras eso sea cierto

            //for(int k = 0; k < array.Length; k++)
            //{
            //    Console.WriteLine(k + "\t" + array[k]);//\t tabulador \n salto linea
            //}



            ////Crear un array de 10 valores. Poner el valor 1 en cada una de la posición. 
            ////Pedir al usuario que introduzca un número entre 0 y 9. 
            ////Cada vez que introduzca un valor entre 0 y 9, mostrar el valor de esa posición del array,
            ////y modificarlo multiplicando por 2.
            //int[] array = new int[10];
            //int num;
            //for(int i = 0; i < array.Length; i++)
            //{
            //    array[i] = 1;
            //}
            //do
            //{
            //    Console.WriteLine("Introduzca un valor de 0 al 9");
            //    num = Int32.Parse(Console.ReadLine());
            //    if(num>=0&&num<=9)
            //        {
            //        array[num] = array[num] * 2;
            //        }
            //} while (num<10&&num>=0);
            //for (int k = 0; k < array.Length; k++)
            //{
            //    Console.WriteLine(k + "\t" + array[k]);//\t tabulador \n salto linea
            //}


            ////Programa que lee las edades de 20 alumnos (validado entre 18 y 35), 
            ////las almacena en un array y calcula y escribe su media 
            ////(para probar, se pueden generar aleatoriamente entre 18 y 35). 
            //int []arrayEdad=new int[20];
            //int edad,media=0;
            //for(int i = 0; i < arrayEdad.Length; i++)
            //{
            //    Console.WriteLine("Introduzca la edad el alumno nº" + (i+1));
            //    edad = Int32.Parse(Console.ReadLine());
            //    while (edad < 18 || edad > 35)
            //    {
            //        Console.WriteLine("Edad no correcta, introduzca otra edad");
            //        edad = Int32.Parse(Console.ReadLine());
            //    }
            //    arrayEdad[i] = edad;
            //}
            //Console.Write("La edad media de los alumnos es ");
            //for (int j = 0; j < arrayEdad.Length; j++)
            //{
            //    media = arrayEdad[j] + media;
            //}
            //Console.WriteLine(media / arrayEdad.Length);
            ////RANDOM:Random ((como una int)) random ((nombre variabe))=new Random();    ****Asi se declara
            //////////int ((nombre que quieras))=random.Next(0,20);   ****Crearia un Random entre 0 y 20
            ///


            ////Cargar una tabla de 20 componentes enteros y calcular la suma de los componentes de posición par y  
            ////el producto(multipli) de los componentes de posición impar. 
            ////Los valores se generarán aleatoriamente entre 1 y 100.
            //int[] array = new int[20];
            //int par = 0, impar = 1;////Como a impar luego lo vamos a multiplicar si pusieramos 0 aqui se quedaria en cero
            //Random random = new Random();//ASI SE DECLARA UN NUMERO ALEATORIO
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(1, 100);
            //    if (i % 2 == 0)
            //    {
            //        par = par + array[i];
            //    }
            //    else
            //    {
            //        impar = impar * array[i];
            //    }
            //}
            //for (int j = 0; j < array.Length; j++)
            //{
            //    Console.WriteLine(j + "\t" + array[j]);
            //}
            //Console.WriteLine("PAR=" + par + "\tIMPAR=" + impar);



            ////Cargar una tabla de 20 elementos donde cada elemento almacenará un valor entre 1 y 9 
            ////(genéralos de forma aleatoria) y escribir, además del contenido de la tabla, la cantidad de 1,
            ////cantidad de 2, cantidad de 3…, cantidad de 9 almacenados en ella. 
            //int[] array = new int[20];
            //int[] arrayNum = new int[9];
            //Random random = new Random();//random declarado
            //for (int i = 0; i < array.Length; i++)
            //{           
            //    array[i] = random.Next(1, 10);
            //    for(int j = 1; j <= arrayNum.Length; j++)
            //    {
            //        if (array[i] == j)
            //        {
            //            arrayNum[j-1] = arrayNum[j-1] + 1;//HAY QUE RESTAR 1 PORQUE EMPIEZA EN 1 Y NO 0                        
            //        }
            //    }
            //    Console.WriteLine(i+"\t"+array[i]);
            //}
            //Console.WriteLine("\t\tTABLA EQUIVALENCIAS");
            //for(int k = 1; k <= arrayNum.Length; k++)
            //{
            //    Console.WriteLine(k + "\t" +arrayNum[k-1]);//HAY QUE RESTAR OTRA VEZ
            //}


            //Cargar dos tablas, una con los nombres y otra con las calificaciones de los N alumnos de una clase de Progr. 
            //Rellenar arrays con el nombre del alumno y su nota validando entre 0 y 10.
            //Calcular la media de la clase
            //Escribir los alumnos cuya nota es mayor que la media.
            //Calcular la nota máxima y quienes la han conseguido
            //Calcular la nota mínima y quienes la han conseguido
            //Mostrar la lista de alumnos junto con su nota correspondiente: 
            //Nombre1 Apellido11 Apellido12 - Nota
            //Nombre2 Apellido21 Apellido22 - Nota
            int alum,num=0,mediaSum=0,media,max=-10,min=20;
            Console.WriteLine("¿Cuantos alumnos hay en clase?");
            alum=Int32.Parse(Console.ReadLine());//Como alum condiciona el largo de los arrays hay que ponerle valor antes
            int[] arrayNot = new int[alum];
            Random random = new Random();
            string[] arrayNom = new string[alum];
            string[] arrayApe1 = new string[alum];
            string[] arrayApe2 = new string[alum];
            for(int i = 0; i < alum; i++)
            {
                arrayNom[i] = "Nombre"+num;
                arrayApe1[i] = "Apellido" + num + "1";
                arrayApe2[i] = "Apellido" + num + "2";
                num = num + 1;             
            }
            for(int j = 0; j < alum; j++)
            {
                Console.WriteLine("Introduzca la nota del alumno (va aleatorio)");
                Console.ReadLine();
                arrayNot[j] = random.Next(0, 11);
                while(arrayNot[j]<0||arrayNot[j]>10)
                {
                    Console.WriteLine("Solo se aceptan valores del 1 al 10, vuelva a intentarlo");
                    arrayNot[j] = Int32.Parse(Console.ReadLine());
                }
                if(arrayNot[j]>max)
                    {
                    max = arrayNot[j];
                    }
                if(arrayNot[j]<min)
                    {
                    min = arrayNot[j];
                    }
            mediaSum = mediaSum + arrayNot[j];
            }
            media = mediaSum / alum;
            Console.WriteLine("Alumnos que superan la media:");
            for(int k = 0; k < alum; k++)
            {
                if (arrayNot[k]>media)
                {
                    Console.WriteLine(arrayNom[k] + " " + arrayApe1[k] + " " + arrayApe2[k]);
                }
            }
            Console.WriteLine("Alumnos con la nota máxima");
            for(int l = 0; l < alum; l++)
            {
                if (arrayNot[l] == max)
                {
                    Console.WriteLine(arrayNom[l] + " " + arrayApe1[l] + " " + arrayApe2[l]);
                }
            }
            Console.WriteLine("Alumnos con la nota mínima");
            for (int m = 0; m < alum; m++)
            {
                if (arrayNot[m] == min)
                {
                    Console.WriteLine(arrayNom[m] + " " + arrayApe1[m] + " " + arrayApe2[m]);
                }
                   
            }






            Console.ReadKey();

      
        }
    }
}
