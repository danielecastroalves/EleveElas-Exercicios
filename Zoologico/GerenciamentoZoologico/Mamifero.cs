namespace GerenciamentoZoologico
{
    public class Mamifero : Animal
    {
        public bool TemPelos { get; set; }

        public Mamifero(string nome, int idade, double peso, bool temPelos) : base(nome, idade, peso)
        {
            TemPelos = temPelos;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} está emitindo som de mamífero.");
        }

        public override void Mover()
        {
            Console.WriteLine($"{Nome} está caminhando.");
        }
    }
}
