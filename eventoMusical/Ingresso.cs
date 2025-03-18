using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03.eventoMusical
{
    internal class Ingresso
    {
        private string nomeDoShow;
        private double preco;
        private int quantidadeDisponível;

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponível)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponível = quantidadeDisponível;
        }

        public string GetNomeDoShow()
        {
            return nomeDoShow;
        }

        public double GetPreco()
        {
            return preco;
        }

        public int GetQuantidadeDisponível()
        {
            return quantidadeDisponível;
        }

        public void SetPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void SetQuantidadeDisponível(int novaQuantidade)
        {
            quantidadeDisponível = novaQuantidade;
        }



        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            quantidadeDisponível = novaQuantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome do show: " + nomeDoShow);
            Console.WriteLine("Preço: " + preco);
            Console.WriteLine("Quantidade disponível: " + quantidadeDisponível);
        }
    }
}
