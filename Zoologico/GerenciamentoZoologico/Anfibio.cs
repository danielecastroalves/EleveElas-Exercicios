namespace GerenciamentoZoologico
{
    public class Anfibio : Animal
    {
        public string CorDaPele { get; set; }

        public Anfibio(string nome, int idade, double peso, string corDaPele) : base(nome, idade, peso)
        {
            CorDaPele = corDaPele;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} está emitindo som de anfíbio.");
        }

        public override void Mover()
        {
            Console.WriteLine($"{Nome} está saltando.");
        }
    }
}
