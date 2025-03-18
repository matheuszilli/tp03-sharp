using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03.eventoMusical
{
    internal static class EventoMusical
    {
        public static void Executar()
        {
            Ingresso ingresso = new Ingresso("Rock in Rio", 500, 1000);
            Console.WriteLine("Informações Iniciais:");
            ingresso.ExibirInformacoes();

            ingresso.SetPreco(200);
            ingresso.SetQuantidadeDisponível(500);

            Console.WriteLine("\nApós atualização:");
            ingresso.ExibirInformacoes();
        }
    }
}

