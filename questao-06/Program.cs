using System;

namespace exercicio06_TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ClassificadorPermanenciaWhile classificador = new ClassificadorPermanenciaWhile();

            classificador.LerMinutosEstacionados();
            classificador.ExibirEstatisticas();
        }
    }
}