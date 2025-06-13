namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        private const decimal DescontoMaximo = 0.30m; // Máximo de 30%

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal ObterValorBruto()
        {
            return DiasReservados * Suite.ValorDiaria;
        }

        public decimal ObterPercentualDesconto()
        {
            if (DiasReservados < 10) return 0;

            decimal percentual = DiasReservados * 0.01m;
            if (percentual > DescontoMaximo)
                percentual = DescontoMaximo;

            return percentual * 100; // em porcentagem
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorBruto = ObterValorBruto();
            decimal desconto = DiasReservados >= 10 ? DiasReservados * 0.01m : 0;

            if (desconto > DescontoMaximo)
                desconto = DescontoMaximo;

            decimal valorComDesconto = valorBruto * (1 - desconto);
            return valorComDesconto;
        }

        public void ExibirResumoDaReserva()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===== RESUMO DA RESERVA =====");
            Console.ResetColor();

            Console.WriteLine("Hóspedes:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var hospede in Hospedes)
            {
                Console.WriteLine($"- {hospede.NomeCompleto}");
            }
            Console.ResetColor();

            Console.WriteLine($"\nDias reservados: {DiasReservados}");
            Console.WriteLine($"Tipo de suíte: {Suite.TipoSuite}");
            Console.WriteLine($"Valor da diária: R$ {Suite.ValorDiaria}");

            decimal valorBruto = ObterValorBruto();
            decimal valorFinal = CalcularValorDiaria();
            decimal desconto = ObterPercentualDesconto();

            Console.WriteLine($"\nValor original total: R$ {valorBruto}");

            Console.WriteLine($"Desconto aplicado: {desconto}%");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Valor final com desconto: R$ {valorFinal}");
            Console.ResetColor();
            Console.WriteLine("=============================\n");
        }
    }
}