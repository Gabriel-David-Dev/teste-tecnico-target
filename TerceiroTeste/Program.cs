using TerceiroTeste.Models;
using Newtonsoft.Json;

namespace TerceiroTeste
{
    internal class Program
    {
        static void Main()
        {
            string json = File.ReadAllText("dados.json");

            List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);
            List<Faturamento> diasValidos = faturamentos.Where(f => f.Valor > 0).ToList();

            if (diasValidos.Count == 0)
            {
                Console.WriteLine("Sem dias válidos de faturamento.");
                return;
            }

            double menorFaturamento = diasValidos.Min(f => f.Valor);
            double maiorFaturamento = diasValidos.Max(f => f.Valor);
            double media = diasValidos.Average(f => f.Valor);
            int diasAcimaDaMedia = diasValidos.Count(f => f.Valor > media);

            Console.WriteLine("Menor faturamento: " + menorFaturamento);
            Console.WriteLine("Maior faturamento: " + maiorFaturamento);
            Console.WriteLine("Dias com faturamento acima da média: " + diasAcimaDaMedia);
        }
    }
}