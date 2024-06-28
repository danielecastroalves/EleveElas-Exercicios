using GerenciamentoEventos;

// Criação de trilhas
Trilha trilhaDesenvolvimento = new("Trilha de Desenvolvimento");
Trilha trilhaDevOps = new("Trilha de DevOps");
Trilha trilhaInteligenciaArtificial = new("Trilha de Inteligência Artificial");

// Criação de atividades para cada trilha
Atividade atividadeDesenvolvimento1 = new("Introdução ao Desenvolvimento Web", "Palestra sobre os fundamentos do desenvolvimento web", DateTime.Now.AddHours(9));
Atividade atividadeDesenvolvimento2 = new("Desenvolvimento Mobile com Flutter", "Palestra sobre desenvolvimento de aplicativos móveis com Flutter", DateTime.Now.AddHours(14));

Atividade atividadeDevOps1 = new("CICD com Azure", "Workshop prático sobre integração e entrega contínua usando Azure Pipelines", DateTime.Now.AddHours(10));
Atividade atividadeDevOps2 = new("Monitoramento com Prometheus e Grafana", "Workshop sobre monitoramento de sistemas com Prometheus e Grafana", DateTime.Now.AddHours(15));

Atividade atividadeInteligenciaArtificial1 = new("Machine Learning com Python", "Palestra sobre conceitos e aplicações de machine learning", DateTime.Now.AddHours(11));
Atividade atividadeInteligenciaArtificial2 = new("Deep Learning com TensorFlow", "Palestra sobre deep learning e suas aplicações usando TensorFlow", DateTime.Now.AddHours(16));

trilhaDesenvolvimento.AdicionarAtividade(atividadeDesenvolvimento1);
trilhaDesenvolvimento.AdicionarAtividade(atividadeDesenvolvimento2);

trilhaDevOps.AdicionarAtividade(atividadeDevOps1);
trilhaDevOps.AdicionarAtividade(atividadeDevOps2);

trilhaInteligenciaArtificial.AdicionarAtividade(atividadeInteligenciaArtificial1);
trilhaInteligenciaArtificial.AdicionarAtividade(atividadeInteligenciaArtificial2);

// Criação de eventos
Conferencia conferenciaTech = new("Tech Conference 2024", DateTime.Now, "Centro de Convenções", 200);
Workshop workshopCSharp = new("Workshop Avançado de C#", DateTime.Now.AddDays(1), "Sala 101 FIAP", 50);

// Adicionando trilhas à conferência
conferenciaTech.AdicionarAtividade(atividadeDesenvolvimento1);
conferenciaTech.AdicionarAtividade(atividadeDesenvolvimento2);

conferenciaTech.AdicionarAtividade(atividadeDevOps1);
conferenciaTech.AdicionarAtividade(atividadeDevOps2);

conferenciaTech.AdicionarAtividade(atividadeInteligenciaArtificial1);
conferenciaTech.AdicionarAtividade(atividadeInteligenciaArtificial2);

// Criação de participantes
Palestrante palestranteDani = new("Dani", "Desenvolvimento Web");
Palestrante palestranteHugo = new Palestrante("Hugo", "DevOps");
Espectador espectadorAnderson = new Espectador("Anderson");
Espectador espectadorFernanda = new Espectador("Fernanda");

// Adicionando participantes aos eventos
conferenciaTech.AdicionarParticipante(palestranteDani);
conferenciaTech.AdicionarParticipante(palestranteHugo);
conferenciaTech.AdicionarParticipante(espectadorAnderson);
conferenciaTech.AdicionarParticipante(espectadorFernanda);

workshopCSharp.AdicionarParticipante(espectadorAnderson);
workshopCSharp.AdicionarParticipante(espectadorFernanda);

// Participantes escolhendo atividades para suas agendas
palestranteDani.AdicionarAtividade(atividadeDesenvolvimento1);
palestranteDani.AdicionarAtividade(atividadeDesenvolvimento2);

palestranteHugo.AdicionarAtividade(atividadeDevOps1);
palestranteHugo.AdicionarAtividade(atividadeDevOps2);

espectadorAnderson.AdicionarAtividade(atividadeDevOps2);
espectadorAnderson.AdicionarAtividade(atividadeInteligenciaArtificial1);

espectadorFernanda.AdicionarAtividade(atividadeInteligenciaArtificial2);
espectadorFernanda.AdicionarAtividade(atividadeDesenvolvimento2);

// Mostrando agendas
palestranteDani.MostrarAgenda();
palestranteHugo.MostrarAgenda();
espectadorAnderson.MostrarAgenda();
espectadorFernanda.MostrarAgenda();

// Iniciando eventos
conferenciaTech.Iniciar();
workshopCSharp.Iniciar();

// Participantes participando das atividades
palestranteDani.Participar();
palestranteHugo.Participar();
espectadorAnderson.Participar();
espectadorFernanda.Participar();

// Avaliando atividades
atividadeDesenvolvimento1.Avaliar(palestranteDani, 10);
atividadeDesenvolvimento2.Avaliar(palestranteDani, 9);

atividadeDevOps1.Avaliar(palestranteHugo, 8);
atividadeDevOps2.Avaliar(palestranteHugo, 9);

atividadeInteligenciaArtificial1.Avaliar(espectadorAnderson, 8);
atividadeInteligenciaArtificial2.Avaliar(espectadorFernanda, 8);

// Obter média das avaliações
double mediaDesenvolvimento1 = atividadeDesenvolvimento1.ObterMediaAvaliacoes();
double mediaDesenvolvimento2 = atividadeDesenvolvimento2.ObterMediaAvaliacoes();

double mediaDevOps1 = atividadeDevOps1.ObterMediaAvaliacoes();
double mediaDevOps2 = atividadeDevOps2.ObterMediaAvaliacoes();

double mediaInteligenciaArtificial1 = atividadeInteligenciaArtificial1.ObterMediaAvaliacoes();
double mediaInteligenciaArtificial2 = atividadeInteligenciaArtificial2.ObterMediaAvaliacoes();

Console.WriteLine($"Média de avaliações da {atividadeDesenvolvimento1.Titulo}: {mediaDesenvolvimento1}");
Console.WriteLine($"Média de avaliações da {atividadeDesenvolvimento2.Titulo}: {mediaDesenvolvimento2}");

Console.WriteLine($"Média de avaliações da {atividadeDevOps1.Titulo}: {mediaDevOps1}");
Console.WriteLine($"Média de avaliações da {atividadeDevOps2.Titulo}: {mediaDevOps2}");

Console.WriteLine($"Média de avaliações da {atividadeInteligenciaArtificial1.Titulo}: {mediaInteligenciaArtificial1}");
Console.WriteLine($"Média de avaliações da {atividadeInteligenciaArtificial2.Titulo}: {mediaInteligenciaArtificial2}");

// Concluindo eventos
conferenciaTech.Concluir();
workshopCSharp.Concluir();