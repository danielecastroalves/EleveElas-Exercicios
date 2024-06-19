namespace GerenciamentoZoologico
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }

        public Animal(string nome, int idade, double peso)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
        }

        public abstract void EmitirSom();
        public abstract void Mover();
    }
}
