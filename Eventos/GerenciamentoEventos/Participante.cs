namespace GerenciamentoEventos
{
    public abstract class Participante
    {
        public string Nome { get; set; }
        public List<Atividade> Agenda { get; private set; }

        protected Participante(string nome)
        {
            Nome = nome;
            Agenda = [];
        }

        public void AdicionarAtividade(Atividade atividade)
        {
            if (!Agenda.Exists(a => a.Horario == atividade.Horario))
            {
                Agenda.Add(atividade);

                Console.WriteLine($"{Nome} adicionou {atividade.Titulo} à sua agenda.");
            }
            else
            {
                Console.WriteLine($"{Nome} já tem uma atividade marcada para {atividade.Horario}.");
            }
        }

        public abstract void Participar();

        public void MostrarAgenda()
        {
            Console.WriteLine($"Agenda de {Nome}:");

            foreach (var atividade in Agenda.OrderBy(a => a.Horario))
            {
                Console.WriteLine($"{atividade.Horario:HH:mm} - {atividade.Titulo}");
            }
        }
    }
}
