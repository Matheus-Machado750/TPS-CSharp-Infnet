using System;
using exercicio04_TP1;
using exercicio06_TP1;

namespace exercicio08_TP1
{
    public static class MenuEstacionamento
    {
        public static void Executar()
        {
            int opcao;

            do
            {
                Console.WriteLine("\n===== MENU DO ESTACIONAMENTO =====");
                Console.WriteLine("1 - Calcular tarifa");
                Console.WriteLine("2 - Converter duração");
                Console.WriteLine("3 - Classificar permanência");
                Console.WriteLine("4 - Sobre");
                Console.WriteLine("5 - Sair");

                Console.Write("\nEscolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = 0;
                }

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite os minutos estacionados: ");
                        int.TryParse(Console.ReadLine(), out int minutos);

                        Console.Write("Digite o valor por hora: ");
                        double.TryParse(Console.ReadLine(), out double valorHora);

                        CalculadoraTarifa calculadora = new CalculadoraTarifa(minutos, valorHora);

                        int horas = calculadora.calcularHorasCheias();

                        calculadora.printarHoras();

                        double valor = calculadora.calcularTarifa(horas);

                        Console.WriteLine($"Valor cobrado: R$ {valor:F2}");

                        calculadora.compararTeto(valor);
                        break;

                    case 2:
                        Console.Write("Digite os minutos: ");
                        int.TryParse(Console.ReadLine(), out int duracao);

                        CalculadoraTarifa conversor = new CalculadoraTarifa(duracao, 0);

                        conversor.printarHoras();
                        break;

                    case 3:
                        ClassificadorPermanenciaWhile classificador =
                            new ClassificadorPermanenciaWhile();

                        classificador.LerMinutosEstacionados();
                        classificador.ExibirEstatisticas();
                        break;

                    case 4:
                        Console.WriteLine("\n===== SOBRE =====");
                        Console.WriteLine($"Versão do .NET: {Environment.Version}");
                        Console.WriteLine("O programa funciona em diferentes sistemas operacionais porque o .NET é multiplataforma e permite executar o mesmo código em ambientes compatíveis, como Windows, Linux e macOS.");
                        break;

                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 5);
        }
    }
}