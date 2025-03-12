namespace SegundoTeste
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            int a = 0, b = 1, soma = 0;

            while (soma < numero)
            {
                soma = a + b;
                a = b;
                b = soma;
            }

            if (soma == numero || numero == 0)
            {
                Console.WriteLine($"O número {numero} pertence a sequência Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} não pertence a sequência Fibonacci.");
            }

        }
    }
}
