namespace QuintoTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string input = Console.ReadLine();
    
            string stringInvertida = InverterString(input);
            Console.WriteLine("Sua string invertida: " + stringInvertida);
        }

        static string InverterString(string stringBase)
        {
            char[] caracteres = new char[stringBase.Length];

            int contador = 0;
            for (int c = stringBase.Length - 1; c >= 0; c--)
            {
                caracteres[contador] = stringBase[c];
                contador++;
            }

            return new string(caracteres);
        }
    }
}