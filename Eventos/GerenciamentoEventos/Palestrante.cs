namespace GerenciamentoEventos
{
    public class Palestrante : Participante
    {
        public string Especialidade { get; set; }

        public Palestrante(string nome, string especialidade)
            : base(nome)
        {
            Especialidade = especialidade;
        }

        public override void Participar() => Console.WriteLine($"{Nome} está palestrando sobre {Especialidade}.");
    }
}
