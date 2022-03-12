using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    internal class Program
    {
        /*
         En C# la generacion de una excepcion recibe el nombre de "iniciacion" de una excepcion.
        El proceso de informar de que se ha iniciado una excepcion recibe el nombre de "capturar" una excepcion
        El fragmento de codigo que se ejecuta despues de que se haya procesado la excepcion es el bloque "finally"
         */

        /*
         La palabra try especifica que hay un bloque de codigo que debe buscar cualquier excepcion 
        iniciada mientras se esta ejecutando el codigo.
        Para indicar el codigo que debe ejecutarse cuando se atrape una excepcion se usa la palabra clave catch
         */

        /*
         Las instrucciones del bloque catch se ejecutan si se inicia una excepcion desde el bloque try.
        Si ninguna de las instrucciones del bloque try inicia una excepcion. Entonces no se ejecuta nada del 
        codigo catch
         */

        /*
         Investigar las principales exepciones y cuando se ejecutan
         */
        static void Main(string[] args)
        {
            int[] largeArray;
            try
            {
                //OutOfMemoryException
                //largeArray = new int[2000000000];

                //StackOverflowException
                //Recursive();

                //NullReferenceException
                MyClass MyObject = new MyClass();
                MyObject = null;
                MyObject.value = 123;



            }
            //OutOfMemoryException.- Inicia cuando se agota la memoria
            catch (OutOfMemoryException)
            {
                Console.WriteLine("La memoria se agoto");
            }
            //StackOverflowException.- Inicia cuando se agota el espacio de la pila
            catch (StackOverflowException)
            {
                Console.WriteLine("La memoria se agoto");
            }
            //NullReferenceException.- El compilador atrapa un intento de eliminar la referencia de un objeto null
            catch (NullReferenceException)
            {
                Console.WriteLine("No se puede referenciar un objeto null");
            }



            Console.ReadKey();
        }

        public static void Recursive()
        {
            Recursive();
        }

        class MyClass
        {
            public int value;
        }
    }
}
