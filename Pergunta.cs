using System;
using System.Collections.Generic;
using System.Linq;

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
                "1. Gosto de trabalhar com ferramentas, máquinas ou objetos",
                "2. Prefiro atividades práticas a discussões teóricas",
                "3. Gosto de consertar, montar ou construir coisas",
                "4. Prefiro ambientes organizados e tarefas manuais",
                "5. Gosto de resolver problemas complexos",
                "6. Tenho interesse em ciência, pesquisa ou experimentos.",
                "7. Gosto de analisar informações e entender como as coisas funcionam",
                "8. Prefiro atividades que envolvam reflexão e lógica.",
                "9. Gosto de criar, desenhar, inventar ou expressar ideias.",
                "10. Prefiro atividades com liberdade e sem regras rígidas.",
                "11. Gosto de música, artes visuais, escrita ou atuação.",
                "12. Sou imaginativo(a) e busco formas diferentes de fazer as coisas.",
                "13. Gosto de ajudar, orientar ou cuidar de pessoas.",
                "14. Tenho facilidade para ouvir e compreender os outros.",
                "15. Prefiro atividades que envolvem ensinar ou apoiar alguém.",
                "16. Gosto de trabalhar em equipe e apoiar o bem-estar coletivo.",
                "17. Gosto de liderar, convencer ou motivar pessoas.",
                "18. Tenho iniciativa e gosto de tomar decisões.",
                "19. Prefiro desafios que envolvam resultados e metas.",
                "20. Gosto de criar projetos e colocar ideias em prática.",
                "21. Gosto de organizar, planejar e manter tudo em ordem.",
                "22. Prefiro atividades com regras claras e rotina",
                "23. Gosto de trabalhar com documentos, tabelas ou registros.",
                "24. Sou detalhista e cuidadoso(a) com informações."
            };

            foreach (var pergunta in Perguntas)
            {
                Console.WriteLine(pergunta);
                Console.WriteLine("0 = Nada a ver | 1 = Pouco | 2 = Parcialmente | 3 = Bastante | 4 = Totalmente");

                int Resp = int.Parse(Console.ReadLine()!);

                // Avaliação automática conforme a pergunta
                if (Contador < 4) Realista += Resp;
                else if (Contador < 8) Investigativo += Resp;
                else if (Contador < 12) Artístico += Resp;
                else if (Contador < 16) Social += Resp;
                else if (Contador < 20) Empreendedor += Resp;
                else Convencional += Resp;

                Contador++;
            }
        }

        public List<int> DescobrirMaisEscolhidas()
        {
            int[] valores = { Realista, Investigativo, Artístico, Social, Empreendedor, Convencional };

            int maior = valores.Max(); 
            List<int> maisEscolhidos = new List<int>();

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] == maior)
                    maisEscolhidos.Add(i);
            }
            return maisEscolhidos;
        }

        public List<string> QualEscolha(List<int> respostasMaisEscolhidas)
        {
            Dictionary<int, string> cursos = new Dictionary<int, string>
            {
                {0, "Mecânica, Automação, Usinagem, Eletricidade, Plástico, Costura"},
                {1, "Tecnologia da Informação, Eletroeletrônica, Manutenção, Plástico"},
                {2, "Design de Produto, Impressão 3D, Comunicação Visual, Costura"},
                {3, "Segurança do Trabalho, Educação, Saúde Ocupacional"},
                {4, "Gestão, Vendas Técnicas, Logística"},
                {5, "Administração, Controle de Qualidade, Planejamento"}
            };

            List<string> cursosIndicados = new List<string>();

            foreach (int indice in respostasMaisEscolhidas)
            {
                cursosIndicados.Add(cursos[indice]);
            }

            return cursosIndicados;
        }
    }
}
