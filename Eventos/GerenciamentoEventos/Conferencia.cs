namespace GerenciamentoEventos
{
    public class Conferencia : Evento
    {
        public Conferencia(string nome, DateTime data, string local, int capacidadeMaxima)
            : base(nome, data, local, capacidadeMaxima) { }

        public override void Iniciar() => Console.WriteLine($"{Nome} (Conferência) iniciada.");
        public override void Pausar() => Console.WriteLine($"{Nome} (Conferência) pausada.");
        public override void Concluir() => Console.WriteLine($"{Nome} (Conferência) concluída.");
        public override void Cancelar() => Console.WriteLine($"{Nome} (Conferência) cancelada.");
    }
}
