﻿using Projeto_Perguntas_e_Respo;

Pergunta Respostas = new Pergunta();

Console.WriteLine("Olá, Vamos para as perguntas!");
Console.WriteLine("Descubra quais cursos combinam com você!\n");

// Executa EXATAMENTE as 24 perguntas
Respostas.Perguntas();

// Descobre as categorias com maior pontuação
List<int> maisEscolhidas = Respostas.DescobrirMaisEscolhidas();

// Busca os cursos correspondentes
List<string> cursos = Respostas.QualEscolha(maisEscolhidas);

// Exibe o resultado
Console.WriteLine("\nRESULTADO — Cursos recomendados:");

foreach (var curso in cursos)
{
    Console.WriteLine("- " + curso);
}

// Exibe categorias empatadas
Console.WriteLine("\nCategorias mais fortes:");

string[] nomes = { "Realista", "Investigativo", "Artístico", "Social", "Empreendedor", "Convencional" };

foreach (int indice in maisEscolhidas)
{
    Console.WriteLine("- " + nomes[indice]);
}
