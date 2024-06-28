namespace GerenciamentoEventos
{
    public abstract class Participante
    {
        public string Nome { get; set; }
        public List<Atividade> Agenda { get; private set; }

        protected Participante(string nome)
        {
            Nome = nome;
            Agenda = new List<Atividade>();
        }

        public void AdicionarAtividade(Atividade atividade)
        {
            Agenda.Add(atividade);
        }

        public abstract void Participar();
    }
}
