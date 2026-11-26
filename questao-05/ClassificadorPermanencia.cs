namespace exercicio05_TP
{
    public class ClassificadorPermanencia
    {
        int MinutosEstacionados = 0;
        int RotativaCurta = 30; // Definido como 30 minutos.
        int RotativaPadrao = 120; // Definido como 120 minutos (2 horas).
        int Diaria = 1440; // Definido como 1440 minutos (24 horas).

        public void LerMinutosEstacionados()
        {
            Console.Write("Digite o tempo de permanência em minutos: ");
            string MinutosEstacionadosStr = Console.ReadLine();

            int.TryParse(MinutosEstacionadosStr, out int minutosConvertidos);

            if (minutosConvertidos >= 0)
            {
                this.MinutosEstacionados = minutosConvertidos;
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, insira um número inteiro não negativo.");
            }
        }

        public void ClassificarPermanencia()
        {
            if (MinutosEstacionados <= RotativaCurta)
            {
                Console.WriteLine("Permanência classificada como: rotativa curta");
            }
            else if (MinutosEstacionados <= RotativaPadrao)
            {
                Console.WriteLine("Permanência classificada como: rotativa padrão");
            }
            else
            {
                Console.WriteLine("Permanência classificada como: diária");
            }
        }
    }
}