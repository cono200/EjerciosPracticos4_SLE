using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciosPracticos4_SLE
{
    internal class Class1
    {
        public void EjerciciosPracticos4()
        {
            

            //a) Escriba una instrucción que declare y cree a t.

            int[,] t = new int[2, 3];
            
            //b) ¿Cuántas filas tiene t?
            Console.WriteLine("Respuesta de la B: 2 ");
            //c) ¿Cuántas columnas tiene t?
            Console.WriteLine("Respuesta de la C 3 ");

            //d) ¿Cuántos elementos tiene t?
            Console.WriteLine("Respuesta de la D 6 ");


            //e) Escriba expresiones de acceso para todos los elementos en la fila 1 de t.

            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(string.Join("Respuesta de la E ", i));

                //f ) Escriba expresiones de acceso para todos los elementos en la columna 2 de t.
                for (int j = 0; j < t.Length; j++)
                {
                    Console.WriteLine(string.Join("Respuesta de la F ", j));
                }
            }

            //g) Escriba una sola instrucción que asigne cero al elemento de t en la fila 0 y la columna 1.

            t[0, 0] = 0;

            //h) Escriba una serie de instrucciones que inicialice cada elemento de t con cero. No utilice una instrucción de repetición.
            Console.WriteLine("Respuestas de la H: ");
            Console.WriteLine(t[0, 0] = 0);
            Console.WriteLine(t[0, 1] = 0);
            Console.WriteLine(t[0, 2] = 0);
            Console.WriteLine(t[1, 0] = 0);
            Console.WriteLine(t[1, 1] = 0);
            Console.WriteLine(t[1, 2] = 0);
            

            //i) Escriba una instrucción for anidada que inicialice cada elemento de t con cero.

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    t[i,j] = 0;

                    Console.WriteLine("Respuestas de la I "  + t[i,j]);
                }

            }


            //j) Escriba una instrucción for anidada que reciba como entrada del usuario los valores de los elementos de t.
            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    

                    Console.WriteLine("Escribe los numeros que desees ingresar a la matriz");
                    t[i, j] = Convert.ToInt32(Console.ReadLine());

                    
                }

            }


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {


                    

                    Console.WriteLine("Respuesta de la J" + t[i, j]);
                }

            }


            //k) Escriba una serie de instrucciones que determine e imprima el valor más pequeño en t.

            int numeroMenor = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (i<=0)
                    {
                        numeroMenor = 0;
                        
                    }
                    else if(j<=0)
                    {
                        numeroMenor = 0;
                    }

                    else if(i>0)


                   
                }

            }

            Console.WriteLine("EL numero menor es " + numeroMenor);

        }





    }
}
