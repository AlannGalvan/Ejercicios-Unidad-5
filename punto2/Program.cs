using System;

namespace punto2
{
    class Program
    {
        static void Main(string[] args)
        {    
            //Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. 
            //Solo se debe emitir UN valor por pantalla.

            int n, mayor = 0;
            //n = 0;
            //mayor = n;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());

                if(x == 0)
                   mayor = n;
                else{
                  if(n > mayor)
                    mayor = n;
                }
            }

            Console.WriteLine("El mayor es: " + mayor);
        }
    }
}
