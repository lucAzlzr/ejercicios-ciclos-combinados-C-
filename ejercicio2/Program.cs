using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            int n, con, conImpar, grupoMax = 0, min, conOrdenados = 0;
            bool banOrdenados;
            double porcentajeImpares, maxPorcentaje = 0;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                con = 0;
                conImpar = 0;
                banOrdenados = true;
                min = n;
                while (n != 0)
                {
                    con++;
                    if(n % 2 != 0)
                        conImpar++;

                    if(n < min)
                        min = n;
                    else
                        banOrdenados = false;
                    
                    Console.WriteLine("Ingrese otro número:");
                    n = int.Parse(Console.ReadLine());
                }
                porcentajeImpares = conImpar * 100 / con;
                if(porcentajeImpares > maxPorcentaje){
                    maxPorcentaje = porcentajeImpares;
                    grupoMax = (x + 1);
                }

                if(banOrdenados)
                    conOrdenados++;
            }
            Console.WriteLine("El grupo " + grupoMax + " es el grupo con mayor porcentaje de números impares");
            Console.WriteLine("La cantidad de grupos que estan formados por todos números ordenados de mayor a menos es: " + conOrdenados);
        }
    }
}
