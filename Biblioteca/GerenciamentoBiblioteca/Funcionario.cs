namespace GerenciamentoBiblioteca
{
    public class Funcionario
    {
        protected internal int IdFuncionario { get; set; } // Acessível dentro do assembly e em subclasses

        protected Funcionario(int idFuncionario)
        {
            IdFuncionario = idFuncionario;
        }

        protected static void AdicionarLivro(Livro livro) // Acessível apenas dentro da classe e em subclasses
        {
            Console.WriteLine($"Livro '{livro.Titulo}' adicionado à biblioteca.");
        }

        private protected static void RemoverLivro(Livro livro) //Acessível apenas dentro da classe e em subclasses dentro do mesmo assembly
        {
            Console.WriteLine($"Livro '{livro.Titulo}' removido da biblioteca.");
        }

        public static Funcionario RegistrarNovoFuncionario(int idFuncionario)
        {
            return new Funcionario(idFuncionario);
        }
    }
}
