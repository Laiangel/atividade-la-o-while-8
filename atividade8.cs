using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase para contar as vogais. Digite 'fim' para encerrar o programa.");

        while (true)
        {
            Console.Write("\nDigite uma frase: ");
            string entrada = Console.ReadLine();

            // Verifica se o usuário deseja encerrar
            if (entrada.Equals("fim", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Programa encerrado. Até logo!");
                break;
            }

            // Conta as vogais na entrada
            int contadorVogais = ContarVogais(entrada);

            // Exibe o resultado
            Console.WriteLine($"A frase contém {contadorVogais} vogal(is).");
        }
    }

    static int ContarVogais(string texto)
    {
        int contador = 0;
        string vogais = "aeiouAEIOU";

        foreach (char caractere in texto)
        {
            if (vogais.Contains(caractere))
            {
                contador++;
            }
        }

        return contador;
    }
}

