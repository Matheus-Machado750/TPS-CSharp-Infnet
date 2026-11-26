using System;

namespace exercicio04_TP1{
    public class CalculadoraTarifa
    {

        int MinutosEstacioanados;
        double ValorHora;
        double TetoDiario = 20.0;

        //Construtor
        public CalculadoraTarifa(int minutosEstacionados, double valorHora)
        {
            MinutosEstacioanados = minutosEstacionados;
            ValorHora = valorHora;
        }

        public  int calcularHorasCheias()
        {
            int horas = MinutosEstacioanados / 60;
            int minutosRestantes = MinutosEstacioanados % 60;

            if (minutosRestantes > 0)
            {
                horas++;
            }
            return horas;
        }

        public void printarHoras()
        {
            int horas = MinutosEstacioanados / 60;
            int minutosRestantes = MinutosEstacioanados % 60;

            Console.WriteLine($"Tempo: {horas}h {minutosRestantes}min");
        }

        public double calcularTarifa(int horas)
        {
            return horas * this.ValorHora;
        }

        public void compararTeto(double ValorCobrado){
            if (ValorCobrado > TetoDiario)
            {
                Console.WriteLine("O valor cobrado excede o teto diário.");
            }
            else if (ValorCobrado < TetoDiario)
            {
                Console.WriteLine("O valor cobrado está dentro do teto diário.");
            }
            else
            {
                Console.WriteLine("O valor cobrado é igual ao teto diário.");
            }
        }
    } 
}