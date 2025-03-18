using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP03.faculdade
{
    internal class Matricula
    {
        public String NomeDoAluno;
        public String Curso;
        public int NumeroMatricula;
        public String Situacao;
        public String DataInicial;

        public Matricula(string nomeDoAluno, string curso, int numeroMatricula, string situacao, string dataInicial)
        {
            NomeDoAluno = nomeDoAluno;
            Curso = curso;
            NumeroMatricula = numeroMatricula;
            Situacao = situacao;
            DataInicial = dataInicial;
        }

        public String getNomeDoAluno()
        {
            return NomeDoAluno;
        }

        public void setNomeDoAluno(String nomeDoAluno)
        {
            NomeDoAluno = nomeDoAluno;
        }

        public String getCurso()
        {
            return Curso;
        }

        public void setCurso(String curso)
        {
            Curso = curso;
        }

        public int getNumeroMatricula()
        {
            return NumeroMatricula;
        }

        public void setNumeroMatricula(int numeroMatricula)
        {
            NumeroMatricula = numeroMatricula;
        }

        public String getSituacao()
        {
            return Situacao;
        }

        public void setSituacao(String situacao)
        {
            Situacao = situacao;
        }

        public String getDataInicial()
        {
            return DataInicial;
        }

        public void setDataInicial(String dataInicial)
        {
            DataInicial = dataInicial;
        }



        public void TrancarMatricula()
        {
            Situacao = "Trancada";
        }

        public void ReativarMatricula()
        {
            Situacao = "Ativa";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome do aluno: " + NomeDoAluno);
            Console.WriteLine("Curso: " + Curso);
            Console.WriteLine("Número da matrícula: " + NumeroMatricula);
            Console.WriteLine("Situação: " + Situacao);
            Console.WriteLine("Data inicial: " + DataInicial);
        }
    }
}
