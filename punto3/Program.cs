using System;

namespace punto3
{
    class Program
    {
        static void Main(string[] args)
        {   

            //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas
            // mayores a 18 años.
            int edad, con = 0, sumar = 0, promedio;
            

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese una edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad > 18){
                   con++;
                   sumar += edad;
                }
            }

            promedio = sumar / con;

            Console.WriteLine("El promedio de edad de personas mayores a 18 es de: " + promedio);
        }
    }
}
