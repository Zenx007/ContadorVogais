using System;

namespace Vogais;

class Contador
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra");
        string palavra = Console.ReadLine();

        int totalVogais = ContarVogais(palavra);
        Console.WriteLine($"A frase contém {totalVogais} vogais.");

        static int ContarVogais(string texto)
        {
            int contador = 0;
            string vogais = "aeiouAEIOU";

            foreach (char letra in texto)
            {
                if (vogais.Contains(letra))
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}


