using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 10 números. El mismo debe analizar 
            //y mostrar por pantalla cuántos de esos números son primos.
            int num, con, conPrimo = 0;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un número:");
                num = int.Parse(Console.ReadLine());

                con = 0;
                for (int y = 1; y <= num; y++)
                {
                    if(num % y == 0)
                        con++;
                }
                if(con == 2)
                    conPrimo++;
            }
            Console.WriteLine("De los 10 números ingresados, " + conPrimo + " son primos");
        }
    }
}
