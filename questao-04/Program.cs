using System;

namespace exercicio04_TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int minutosEstacionados = 137;
            double valorHora = 10.0;

            CalculadoraTarifa calculadora = new CalculadoraTarifa(minutosEstacionados, valorHora);

            int horasCheias = calculadora.calcularHorasCheias();
            calculadora.printarHoras();
            double valorCobrado = calculadora.calcularTarifa(horasCheias);

            Console.WriteLine($"Valor cobrado: R${valorCobrado}");

            calculadora.compararTeto(valorCobrado);
        }
    }
}