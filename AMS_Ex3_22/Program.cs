using System;

namespace AMS_Ex3_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorVendido = 500000;
            int porcentagem = 5;
            int resultado = valorVendido * porcentagem /100;

            Console.WriteLine("");
            Console.WriteLine($"O 5% de 500000 é: {resultado}");
            Console.WriteLine("");
        }
    }
}
