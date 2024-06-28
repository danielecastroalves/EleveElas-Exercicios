namespace GerenciamentoEventos
{
    public class Workshop : Evento
    {
        public Workshop(string nome, DateTime data, string local, int capacidadeMaxima)
            : base(nome, data, local, capacidadeMaxima) { }

        public override void Iniciar() => Console.WriteLine($"{Nome} (Workshop) iniciado.");
        public override void Pausar() => Console.WriteLine($"{Nome} (Workshop) pausado.");
        public override void Concluir() => Console.WriteLine($"{Nome} (Workshop) concluído.");
        public override void Cancelar() => Console.WriteLine($"{Nome} (Workshop) cancelado.");
    }
}
