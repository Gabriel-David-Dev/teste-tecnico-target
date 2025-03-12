namespace QuartoTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Valor em ordem por estado como foi informado no enunciado (SP, RJ, MG, ES, Outros)
            double[] faturamentos = { 67836.43, 36678.66, 29229.88, 27165.48, 19849.53 };

            double faturamentoTotal = 0;
            foreach (var faturamento in faturamentos)
            {
                faturamentoTotal += faturamento;
            }

            string[] estados = { "SP", "RJ", "MG", "ES", "Outros" };
            for (int i = 0; i < faturamentos.Length; i++)
            {
                double percentual = (faturamentos[i] / faturamentoTotal) * 100;
                Console.WriteLine($"{estados[i]}: {percentual:F2}%");
            }
        }

    }
}