using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Perguntas_e_Respo
{
    public class Pergunta
    {
        public int Contador { get; set; }
        public int Maior { get; set; }


        public int Realista { get; set; }
        public int Investigativo { get; set; }
        public int Artístico { get; set; }
        public int Social { get; set; }
        public int Empreendedor { get; set; }
        public int Convencional { get; set; }

        public void Perguntas()
        {
            List<string> Perguntas = new List<string>
            {
                "1. Gosto de trabalhar com ferramentas, máquinas ou objetos", "2. Prefiro atividades práticas a discussões teóricas", "3. Gosto de consertar, montar ou construir coisas",
                "4. Prefiro ambientes organizados e tarefas manuais", "5. Gosto de resolver problemas complexos", "6. Tenho interesse em ciência, pesquisa ou experimentos.",
                "7. Gosto de analisar informações e entender como as coisas funcionam", "8. Prefiro atividades que envolvam reflexão e lógica.", "9. Gosto de criar, desenhar, inventar ou expressar ideias.",
                "10. Prefiro atividades com liberdade e sem regras rígidas.", "11. Gosto de música, artes visuais, escrita ou atuação.", "12. Sou imaginativo(a) e busco formas diferentes de fazer as coisas.",
                "13. Gosto de ajudar, orientar ou cuidar de pessoas.", "14. Tenho facilidade para ouvir e compreender os outros.","15. Prefiro atividades que envolvem ensinar ou apoiar alguém.",
                "16. Gosto de trabalhar em equipe e apoiar o bem-estar coletivo.","17. Gosto de liderar, convencer ou motivar pessoas.", "18. Tenho iniciativa e gosto de tomar decisões.",
                "19. Prefiro desafios que envolvam resultados e metas.", "20. Gosto de criar projetos e colocar ideias em prática.", "21. Gosto de organizar, planejar e manter tudo em ordem.",
                "22. Prefiro atividades com regras claras e rotina", "23. Gosto de trabalhar com documentos, tabelas ou registros.", "24. Sou detalhista e cuidadoso(a) com informações."
            };
            foreach (var pergunta in Perguntas)
            {
                Console.WriteLine(pergunta);
                Console.WriteLine("0 = Nada a ver | 1 = Pouco | 2 = Parcialmente | 3 = Bastante | 4 = Totalmente");
                int Resp = int.Parse(Console.ReadLine()!);
                switch (Resp)
                {
                    case 0:
                        if (Contador >= 0 && Contador <= 3)
                        {
                            Realista += 0;
                        }
                        else if (Contador >= 4 && Contador <= 7)
                        {
                            Investigativo += 0;
                        }
                        else if (Contador >= 8 && Contador <= 11)
                        {
                            Artístico += 0;
                        }
                        else if (Contador >= 12 && Contador <= 15)
                        {
                            Social += 0;
                        }
                        else if (Contador >= 16 && Contador <= 19)
                        {
                            Empreendedor += 0;
                        }
                        else if (Contador >= 20 && Contador <= 23)
                        {
                            Convencional += 0;
                        }
                        break;

                    //Caso Um -------------------------------

                    case 1:
                        if (Contador >= 0 && Contador <= 3)
                        {
                            Realista += 1;
                        }
                        else if (Contador >= 4 && Contador <= 7)
                        {
                            Investigativo += 1;
                        }
                        else if (Contador >= 8 && Contador <= 11)
                        {
                            Artístico += 1;
                        }
                        else if (Contador >= 12 && Contador <= 15)
                        {
                            Social += 1;
                        }
                        else if (Contador >= 16 && Contador <= 19)
                        {
                            Empreendedor += 1;
                        }
                        else if (Contador >= 20 && Contador <= 23)
                        {
                            Convencional += 1;
                        }
                        break;
                    //Caso Dois -------------------------------

                    case 2:
                        if (Contador >= 0 && Contador <= 3)
                        {
                            Realista += 2;
                        }
                        else if (Contador >= 4 && Contador <= 7)
                        {
                            Investigativo += 2;
                        }
                        else if (Contador >= 8 && Contador <= 11)
                        {
                            Artístico += 2;
                        }
                        else if (Contador >= 12 && Contador <= 15)
                        {
                            Social += 2;
                        }
                        else if (Contador >= 16 && Contador <= 19)
                        {
                            Empreendedor += 2;
                        }
                        else if (Contador >= 20 && Contador <= 23)
                        {
                            Convencional += 2;
                        }
                        break;

                    //Caso Tres -------------------------------

                    case 3:
                        if (Contador >= 0 && Contador <= 3)
                        {
                            Realista += 3;
                        }
                        else if (Contador >= 4 && Contador <= 7)
                        {
                            Investigativo += 3;
                        }
                        else if (Contador >= 8 && Contador <= 11)
                        {
                            Artístico += 3;
                        }
                        else if (Contador >= 12 && Contador <= 15)
                        {
                            Social += 3;
                        }
                        else if (Contador >= 16 && Contador <= 19)
                        {
                            Empreendedor += 3;
                        }
                        else if (Contador >= 20 && Contador <= 23)
                        {
                            Convencional += 3;
                        }
                        break;

                    //Caso Quatro -------------------------------

                    case 4:
                        if (Contador >= 0 && Contador <= 3)
                        {
                            Realista += 4;
                        }
                        else if (Contador >= 4 && Contador <= 7)
                        {
                            Investigativo += 4;
                        }
                        else if (Contador >= 8 && Contador <= 11)
                        {
                            Artístico += 4;
                        }
                        else if (Contador >= 12 && Contador <= 15)
                        {
                            Social += 4;
                        }
                        else if (Contador >= 16 && Contador <= 19)
                        {
                            Empreendedor += 4;
                        }
                        else if (Contador >= 20 && Contador <= 23)
                        {
                            Convencional += 4;
                        }
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
                Contador++;
            }
        }

        public List<string> QualEscolha(List<int> respostasMaisEscolhidas)
        {
            Dictionary<int, string> cursos = new Dictionary<int, string>()
        {
            {0, "Mecânica, Automação, Usinagem, Eletricidade, Plastico, Costura"},
            {1, "Tecnologia da Informação, Eletroeletrônica, Manutenção, Plastico"},
            {2, "Design de Produto, Impressão 3D, Comunicação Visual, Costura"},
            {3, "Segurança do Trabalho, Educação, Saúde Ocupaciona"},
            {4, "Gestão, Vendas Técnicas, Logística"},
            {5, "Administração, Controle de Qualidade, Planejamento."}
        };

            List<string> cursosIndicados = new List<string>();

            // Para cada resposta vencedora, adiciona o curso correspondente
            foreach (int resposta in respostasMaisEscolhidas)
            {
                if (cursos.ContainsKey(resposta))
                    cursosIndicados.Add(cursos[resposta]);
            }

            return cursosIndicados;
        }
        public List<int> DescobrirMaisEscolhidas()
        {
            int[] valores = { Realista, Investigativo, Artístico, Social, Empreendedor, Convencional };

            int maior = valores.Max(); // valor máximo
            List<int> maisEscolhidos = new List<int>();

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] == maior)
                    maisEscolhidos.Add(i); // índice 0 a 5
            }

            return maisEscolhidos;
        }

    }
}