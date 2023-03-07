using System;

namespace punto5
{
    class Program
    {
        static void Main(string[] args)
        {   // Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números
            // pares y el mínimo de los números impares.
            int  n, maxp = 0, mini = 0;
            //int bi = 0, bp = 0;

            // esta es una bandera de verdadero o falso
            bool banpar = false, banimp = false;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un nro: ");
            n = int.Parse(Console.ReadLine());

            //if(n % 2 == 0){
              //  bp++;
                //Trabajo con pares
                //if(bp == 1){
                  // maxp = n;
                //}else if(n > maxp){
                  //    maxp = n;
                //}
            //}
            if(n % 2 == 0){
                //Trabajo con pares
                if(banpar == false){
                   maxp = n;
                   banpar = true;
                }else if(n > maxp){
                      maxp = n;
                }
             }else{
                //Trabajo con impares
              if(banimp == false){
                mini = n;
                banimp = true;
              }else if(n < mini){
                mini = n;
              }

              //else{
                //Trabajo con impares
               // bi++;
              //if(bi == 1){
               // mini = n;
              //}else if(n < mini){
              //  mini = n;
              //}

            }
            
        }
            
            Console.WriteLine("El maximo de los numeros pares es: " + maxp + " El minimo de los numeros impares es: " + mini);
        }
    }
}
