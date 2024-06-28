
// Criação de eventos
using GerenciamentoEventos;

Conferencia conferencia = new("Tech Conference 2024", DateTime.Now, "Centro de Convenções", 200);
Workshop workshop = new("Workshop de C# Avançado", DateTime.Now.AddDays(1), "Sala 101", 50);

// Criação de participantes
Palestrante palestrante = new("Fernanda", "Inteligência Artificial");
Espectador espectador = new("João");

// Criação de atividades
Atividade atividade1 = new("Palestra de Abertura", "Introdução à conferência", DateTime.Now.AddHours(1));
Atividade atividade2 = new("Workshop Hands-on", "Prática de C# avançado", DateTime.Now.AddHours(2));

// Adicionando atividades aos eventos
conferencia.AdicionarAtividade(atividade1);
workshop.AdicionarAtividade(atividade2);

// Adicionando participantes aos eventos
conferencia.AdicionarParticipante(palestrante);
conferencia.AdicionarParticipante(espectador);
workshop.AdicionarParticipante(espectador);

// Adicionando atividades às agendas dos participantes
palestrante.AdicionarAtividade(atividade1);
espectador.AdicionarAtividade(atividade1);
espectador.AdicionarAtividade(atividade2);

// Iniciando eventos
conferencia.Iniciar();
workshop.Iniciar();

// Participantes participando das atividades
palestrante.Participar();
espectador.Participar();

// Avaliando atividades
atividade1.Avaliar(palestrante, 9);
atividade1.Avaliar(espectador, 8);
atividade2.Avaliar(espectador, 10);

// Obter média das avaliações
double mediaAtividade1 = atividade1.ObterMediaAvaliacoes();
double mediaAtividade2 = atividade2.ObterMediaAvaliacoes();

Console.WriteLine($"Média de avaliações da {atividade1.Titulo}: {mediaAtividade1}");
Console.WriteLine($"Média de avaliações da {atividade2.Titulo}: {mediaAtividade2}");

// Concluindo eventos
conferencia.Concluir();
workshop.Concluir();