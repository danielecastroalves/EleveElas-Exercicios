namespace GerenciamentoBiblioteca
{
    public class Membro
    {
        public string Nome { get; set; } // Acessível por qualquer pessoa
        private int IdMembro { get; set; } // Acessível apenas dentro da classe

        internal Membro(string nome, int idMembro)
        {
            Nome = nome;
            IdMembro = idMembro;
        }

        internal void PegarLivroEmprestado(Livro livro) // Acessível apenas dentro do assembly
        {
            Console.WriteLine($"{Nome} pegou o livro '{livro.Titulo}' emprestado.");
        }

        protected void ObterInformacoesDetalhadas() // Método protegido
        {
            Console.WriteLine($"Nome: {Nome}, ID Membro: {IdMembro}");
        }
    }
}
