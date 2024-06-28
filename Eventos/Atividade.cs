namespace GerenciamentoEventos
{
    public class Atividade
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Horario { get; set; }
        private List<Participante> Participantes { get; set; }
        private Dictionary<Participante, int> Avaliacoes { get; set; }

        public Atividade(string titulo, string descricao, DateTime horario)
        {
            Titulo = titulo;
            Descricao = descricao;
            Horario = horario;
            Participantes = new List<Participante>();
            Avaliacoes = new Dictionary<Participante, int>();
        }

        public void AdicionarParticipante(Participante participante)
        {
            Participantes.Add(participante);
        }

        public void RemoverParticipante(Participante participante)
        {
            Participantes.Remove(participante);
        }

        public void Avaliar(Participante participante, int nota)
        {
            if (nota < 0 || nota > 10)
            {
                throw new ArgumentOutOfRangeException("A nota deve estar entre 0 e 10.");
            }

            if (!Participantes.Contains(participante))
            {
                throw new InvalidOperationException("O participante não está inscrito nesta atividade.");
            }

            Avaliacoes[participante] = nota;

            Console.WriteLine($"Atividade {Titulo} avaliada por {participante.Nome} com a nota: {nota}");
        }

        public double ObterMediaAvaliacoes()
        {
            if (Avaliacoes.Count == 0)
            {
                return 0;
            }

            double total = 0;

            foreach (var nota in Avaliacoes.Values)
            {
                total += nota;
            }

            return total / Avaliacoes.Count;
        }
    }
}
