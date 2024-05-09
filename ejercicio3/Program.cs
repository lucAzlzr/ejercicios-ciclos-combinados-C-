using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            int n, con, numeroGrupo = 0;

            do
            {
                numeroGrupo++;
                con = 0;
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                while (n > 0)
                {
                    Console.WriteLine("Ingrese otro número:");
                    n = int.Parse(Console.ReadLine());
                    con++;
                }
                Console.WriteLine("La lista del grupo número " + numeroGrupo + " tiene " + con + " números");
            } while (n >= 0);
        }
    }
}
