using System;

namespace exercicio05_TP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ClassificadorPermanencia classificador = new ClassificadorPermanencia();

            classificador.LerMinutosEstacionados();
            classificador.ClassificarPermanencia();
        }
    }
}