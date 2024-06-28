namespace GerenciamentoEventos
{
    public class Espectador : Participante
    {
        public Espectador(string nome)
            : base(nome) { }

        public override void Participar() => Console.WriteLine($"{Nome} está assistindo as atividades.");
    }
}
