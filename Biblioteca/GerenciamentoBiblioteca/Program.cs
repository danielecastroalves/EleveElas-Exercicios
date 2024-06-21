// See https://aka.ms/new-console-template for more information
using GerenciamentoBiblioteca;



// Criando um livro
Livro livro = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", "1234567890");
Console.WriteLine(livro.ObterResumo());

// Criando um membro da biblioteca
Membro membro = new Membro("João Silva", 1);
membro.PegarLivroEmprestado(livro);

// Registrando e utilizando um funcionário
Funcionario funcionario = Funcionario.RegistrarNovoFuncionario(1001);
//funcionário.AdicionarLivro(livro); // Esse método é protegido e não pode ser chamado diretamente aqui

// Criando um administrador
Administrador administrador = new Administrador(2001);
administrador.GerenciarBiblioteca();