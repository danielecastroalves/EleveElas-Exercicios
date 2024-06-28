namespace GerenciamentoEventos
{
    public class Trilha
    {
        public string Nome { get; set; }
        public List<Atividade> Atividades { get; set; }

        public Trilha(string nome)
        {
            Nome = nome;
            Atividades = [];
        }

        public void AdicionarAtividade(Atividade atividade)
        {
            Atividades.Add(atividade);
        }
    }
}
