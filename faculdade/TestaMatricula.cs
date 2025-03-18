using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03.faculdade
{
    internal class TestaMatricula
    {
        public static void Executar()
        {
            Matricula matricula = new Matricula("Matheus", "Engenharia de Software", 123456, "Ativa", "01/01/2021");

            Console.WriteLine("\nInformações Iniciais:");
            matricula.ExibirInformacoes();

            matricula.TrancarMatricula();
            Console.WriteLine("\nInformações após trancar:");
            matricula.ExibirInformacoes();

            matricula.ReativarMatricula();
            Console.WriteLine("\nInformações após reativar:");
            matricula.ExibirInformacoes();
        }
    }
}
