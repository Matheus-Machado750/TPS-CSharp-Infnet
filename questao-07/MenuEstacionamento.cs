using System;
using exercicio04_TP1;
using exercicio06_TP1;

namespace exercicio07_TP1
{
    public class MenuEstacionamento
    {
        public void Executar()
        {
            int opcao;

            do
            {
                Console.WriteLine("\n===== MENU DO ESTACIONAMENTO =====");
                Console.WriteLine("1 - Calcular tarifa");
                Console.WriteLine("2 - Converter duração em horas e minutos");
                Console.WriteLine("3 - Classificar permanência");
                Console.WriteLine("4 - Sair");

                Console.Write("\nEscolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = 0;
                }

                switch (opcao)
                {
                    case 1:
                        CalcularTarifa();
                        break;

                    case 2:
                        ConverterDuracao();
                        break;

                    case 3:
                        ClassificarPermanencia();
                        break;

                    case 4:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 4);
        }

        // OPÇÃO 1 de Calcular tarifa
        private void CalcularTarifa()
        {
            Console.Write("\nDigite os minutos estacionados: ");

            if (!int.TryParse(Console.ReadLine(), out int minutos) || minutos < 0)
            {
                Console.WriteLine("Valor inválido!");
                return;
            }

            Console.Write("Digite o valor cobrado por hora: ");

            if (!double.TryParse(Console.ReadLine(), out double valorHora) || valorHora < 0)
            {
                Console.WriteLine("Valor inválido!");
                return;
            }

            CalculadoraTarifa calculadora = new CalculadoraTarifa(minutos, valorHora);

            int horas = calculadora.calcularHorasCheias();

            calculadora.printarHoras();

            double valorCobrado = calculadora.calcularTarifa(horas);

            Console.WriteLine($"Valor cobrado: R$ {valorCobrado:F2}");

            calculadora.compararTeto(valorCobrado);
        }

        // OPÇÃO 2 de Converter duração
        private void ConverterDuracao()
        {
            Console.Write("\nDigite os minutos estacionados: ");

            if (!int.TryParse(Console.ReadLine(), out int minutos) || minutos < 0)
            {
                Console.WriteLine("Valor inválido!");
                return;
            }

            CalculadoraTarifa calculadora = new CalculadoraTarifa(minutos, 0.0);

            calculadora.printarHoras();
        }

        // OPÇÃO 3: Classificar permanência
        private void ClassificarPermanencia()
        {
            ClassificadorPermanenciaWhile classificador = new ClassificadorPermanenciaWhile();

            classificador.LerMinutosEstacionados();

            classificador.ExibirEstatisticas();
        }
    }
}