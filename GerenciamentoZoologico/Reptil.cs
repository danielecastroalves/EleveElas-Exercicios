namespace GerenciamentoZoologico
{
    public class Reptil : Animal
    {
        public bool TemEscamas { get; set; }

        public Reptil(string nome, int idade, double peso, bool temEscamas) : base(nome, idade, peso)
        {
            TemEscamas = temEscamas;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} está fazendo som de réptil.");
        }

        public override void Mover()
        {
            Console.WriteLine($"{Nome} está rastejando.");
        }
    }
}
