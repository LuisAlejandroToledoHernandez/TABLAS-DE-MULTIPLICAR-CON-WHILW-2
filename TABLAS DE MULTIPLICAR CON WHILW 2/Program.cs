using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TABLA_DE_MULTIPLICAR_CON_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, RESUL, T, I;
            string linea;
            Console.Write("CUANTAS TABLAS: "); linea = Console.ReadLine();
            NUM = int.Parse (linea);
            T = 1;
            while((T <= NUM))
            {
                I = 10;
                while(!((I < 1)))
                {
                    RESUL = T * I;
                    Console.WriteLine("{0} * {1} = {2}", T, I, RESUL);
                    I = I - 1;
                }
                Console.Write("PULSE UNA TECLA: "); Console.ReadLine();
                T = T + 1;
            }
        }
    }
}
