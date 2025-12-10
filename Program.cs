using System.Runtime.InteropServices;
using Projeto_Perguntas_e_Respo;

//Variaveis
bool Continuar = true;
Pergunta Respostas = new Pergunta();
Respostas.Contador = 0;
Respostas.Realista = 0;
Respostas.Investigativo = 0;
Respostas.Artístico = 0;
Respostas.Social = 0;
Respostas.Empreendedor = 0;
Respostas.Convencional = 0;


Console.WriteLine("Olá, Vamos para as perguntas!");
Console.WriteLine("Descubra quais cursos combinam com você!");


while (Continuar)
{
    Respostas.Perguntas();
    Respostas.Contador++;

    Continuar = false;
}

Respostas.Perguntas();
// Descobre quais categorias ficaram no topo
List<int> maisEscolhidas = Respostas.DescobrirMaisEscolhidas();

// Agora chama corretamente o método
List<string> cursos = Respostas.QualEscolha(maisEscolhidas);

// Exibe o resultado
Console.WriteLine("\nRESULTADO — Cursos recomendados:");
foreach (var curso in cursos)
{
    Console.WriteLine("- " + curso);
}

