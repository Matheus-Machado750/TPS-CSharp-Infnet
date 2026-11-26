using System;

namespace exercicio06_TP1
{
    public class ClassificadorPermanenciaWhile
    {
        int MinutosEstacionados = 0;

        int QuantRotativaCurta = 0;
        int QuantRotativaPadrao = 0;
        int QuantRotativaDiaria = 0;
        const int RotativaCurta = 30;
        const int RotativaPadrao = 120;

        /// Se for > 120 já é diária mesmo

        public void LerMinutosEstacionados()
        {
            while (true)
            {
                Console.Write("Digite o tempo de permanência em minutos (-1 para sair): ");
                string MinutosEstacionadosStr = Console.ReadLine();

                if (!int.TryParse(MinutosEstacionadosStr, out int minutosConvertidos))
                {
                    Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                    continue;
                }

                if (minutosConvertidos == -1)
                {
                    Console.WriteLine("Encerrando classificação...");
                    break;
                }

                if (minutosConvertidos < 0)
                {
                    Console.WriteLine("Valor inválido. Digite um valor positivo ou -1 para sair.");
                    continue;
                }

                this.MinutosEstacionados = minutosConvertidos;

                if (MinutosEstacionados <= RotativaCurta)
                {
                    Console.WriteLine("Permanência classificada como rotativa curta");
                    QuantRotativaCurta++;
                }
                else if (MinutosEstacionados <= RotativaPadrao)
                {
                    Console.WriteLine("Permanência classificada como rotativa padrão");
                    QuantRotativaPadrao++;
                }
                else
                {
                    Console.WriteLine("Permanência classificada como diária");
                    QuantRotativaDiaria++;
                }

                Console.WriteLine();
            }
        }

        public void ExibirEstatisticas()
        {
            Console.WriteLine("\nEstatísticas de permanência:");
            Console.WriteLine($"Rotativa curta: {QuantRotativaCurta}");
            Console.WriteLine($"Rotativa padrão: {QuantRotativaPadrao}");
            Console.WriteLine($"Rotativa diária: {QuantRotativaDiaria}");
        }
    }
}