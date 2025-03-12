namespace PrimeiroTeste
{
    internal class Program
    {
        static void Main()
        {
            int indice = 13, soma = 0, k = 0;

            while (k < indice)
            {
                k++;
                soma += k;
            }

            Console.WriteLine($"O valor da SOMA é: {soma}");
        }
    }
}
