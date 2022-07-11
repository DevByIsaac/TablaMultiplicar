using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tablaMultiplicar
{
    class TablaMultiplicar
    {
        static void Main(String[] argumentos)
        {
            int x;
            string y;

            Console.Write("Ingrese el multiplicador: \n");
            y = Console.ReadLine();
            x = int.Parse(y);
            
            if (x >= 1 && x<=12)
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.Write(i + " * " + x + " = " + i * x + "\n");    
                }
            }
            else
            {
                Console.Write("Debe ingresar un número entre 1 y 12");

                }
            Console.ReadKey();
        }
}
}