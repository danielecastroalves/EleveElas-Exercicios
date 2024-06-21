using GerenciamentoZoologico;

// Aves
Ave ave = new Ave("Papagaio", 2, 1.5, 0.5);
ave.EmitirSom();
ave.Mover();
ave.LevantarVoo();
ave.Pousar();

Ave ave2 = new Ave("Águia", 5, 3.0, 2.0);
ave2.EmitirSom();
ave2.Mover();
ave2.LevantarVoo();
ave2.Pousar();

// Peixes
Peixe peixe = new Peixe("Tilápia", 1, 0.3, "doce", 100);
peixe.EmitirSom();
peixe.Mover();
peixe.Subir(10);
peixe.Descer(20);

Peixe peixe2 = new Peixe("Tubarão", 7, 500, "salgada", 2000);
peixe2.EmitirSom();
peixe2.Mover();
peixe2.Subir(100);
peixe2.Descer(500);

// Mamíferos
Mamifero mamifero = new Mamifero("Elefante", 10, 5000, true);
mamifero.EmitirSom();
mamifero.Mover();

Mamifero mamifero2 = new Mamifero("Cachorro", 3, 15, true);
mamifero2.EmitirSom();
mamifero2.Mover();

Mamifero mamifero3 = new Mamifero("Golfinho", 6, 300, false);
mamifero3.EmitirSom();
mamifero3.Mover();

// Répteis
Reptil reptil = new Reptil("Cobra", 5, 15, true);
reptil.EmitirSom();
reptil.Mover();

Reptil reptil2 = new Reptil("Tartaruga", 80, 50, false);
reptil2.EmitirSom();
reptil2.Mover();

// Anfíbio
Anfibio anfibio = new Anfibio("Sapo", 3, 0.2, "verde");
anfibio.EmitirSom();
anfibio.Mover();

Anfibio anfibio2 = new Anfibio("Salamandra", 4, 0.5, "vermelho e preto");
anfibio2.EmitirSom();
anfibio2.Mover();