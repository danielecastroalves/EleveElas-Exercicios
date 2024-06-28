namespace GerenciamentoEventos
{
    public abstract class Evento
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
        public int CapacidadeMaxima { get; set; }
        private List<Participante> Participantes { get; set; }
        private List<Atividade> Atividades { get; set; }

        protected Evento(string nome, DateTime data, string local, int capacidadeMaxima)
        {
            Nome = nome;
            Data = data;
            Local = local;
            CapacidadeMaxima = capacidadeMaxima;
            Participantes = [];
            Atividades = [];
        }

        public void AdicionarParticipante(Participante participante)
        {
            if (Participantes.Count < CapacidadeMaxima)
            {
                Participantes.Add(participante);
            }
            else
            {
                throw new InvalidOperationException("Capacidade máxima atingida.");
            }
        }

        public void RemoverParticipante(Participante participante)
        {
            Participantes.Remove(participante);
        }

        public void AdicionarAtividade(Atividade atividade)
        {
            Atividades.Add(atividade);
        }

        public abstract void Iniciar();
        public abstract void Pausar();
        public abstract void Concluir();
        public abstract void Cancelar();
    }
}
