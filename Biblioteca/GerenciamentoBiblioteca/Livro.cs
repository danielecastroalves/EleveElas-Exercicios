namespace GerenciamentoBiblioteca
{
    public class Livro
    {
        public string Titulo { get; set; } // Acessível por qualquer pessoa
        protected string Autor { get; set; } // Acessível dentro da classe e suas subclasses
        internal string ISBN { get; set; } // Acessível apenas dentro do assembly

        public Livro(string titulo, string autor, string isbn)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
        }

        public string ObterResumo()
        {
            return $"{Titulo} por {Autor}. ISBN: {ISBN}";
        }
    }
}
