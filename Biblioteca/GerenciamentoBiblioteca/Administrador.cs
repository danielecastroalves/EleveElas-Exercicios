namespace GerenciamentoBiblioteca
{
    public class Administrador
    {
        private int IdAdministrador { get; } // Acessível apenas dentro da classe

        internal Administrador(int idAdministrador)
        {
            IdAdministrador = idAdministrador;
        }

        internal static void GerenciarBiblioteca() // Acessível apenas dentro do Assembly
        {
            Console.WriteLine("Biblioteca gerenciada pelo administrador.");
        }

        protected void ObterInformacoesDetalhadas()
        {
            Console.WriteLine($"ID Administrador: {IdAdministrador}");
        }
    }
}
