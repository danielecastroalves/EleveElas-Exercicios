using GerenciamentoZoologico.Interfaces;

namespace GerenciamentoZoologico
{
    public class Ave : Animal, IVoar
    {
        public double EnvergaduraDasAsas { get; set; }

        public Ave(string nome, int idade, double peso, double envergaduraDasAsas) : base(nome, idade, peso)
        {
            EnvergaduraDasAsas = envergaduraDasAsas;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} está cantando.");
        }

        public override void Mover()
        {
            Console.WriteLine($"{Nome} está andando.");
        }

        public void LevantarVoo()
        {
            Console.WriteLine($"{Nome} está levantando voo.");
        }

        public void Pousar()
        {
            Console.WriteLine($"{Nome} está pousando.");
        }
    }
}
