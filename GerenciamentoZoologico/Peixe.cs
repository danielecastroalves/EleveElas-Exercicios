using GerenciamentoZoologico.Interfaces;

namespace GerenciamentoZoologico
{
    public class Peixe : Animal, INadar
    {
        public string TipoDeAgua { get; set; } // água doce ou salgada
        public int LimiteDeProfundidade { get; set; }

        public Peixe(string nome, int idade, double peso, string tipoDeAgua, int limiteDeProfundidade) : base(nome, idade, peso)
        {
            TipoDeAgua = tipoDeAgua;
            LimiteDeProfundidade = limiteDeProfundidade;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} está fazendo som de peixe.");
        }

        public override void Mover()
        {
            Console.WriteLine($"{Nome} está nadando.");
        }

        public void Subir(int metros)
        {
            Console.WriteLine($"{Nome} está subindo {metros} metros.");
        }

        public void Descer(int metros)
        {
            Console.WriteLine($"{Nome} está descendo {metros} metros.");
        }
    }
}
