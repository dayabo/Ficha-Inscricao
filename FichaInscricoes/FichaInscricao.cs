using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaInscricoes
{
    public class FichaInscricao
    {
        public string Nome = string.Empty;
        public int Idade;
        public string Curso = string.Empty;
        public string Escolaridade = string.Empty;
        public DateTime DataDeNascimento;
        public float ValorCurso;
        public float ValorDoDesconto;
        public float ValorDaMulta;

        public FichaInscricao(DateTime dataDeNascimento) 
        { 
            Idade = CalcularIdade(dataDeNascimento);
        }
       
        public FichaInscricao(string nome, string curso, string escolaridade, DateTime dataDeNascimento, float valorCurso, float valorDoDesconto, float valorDaMulta)
        {
            Nome = nome;
            Curso = curso;
            Escolaridade = escolaridade;
            DataDeNascimento = dataDeNascimento;
            ValorCurso = valorCurso;
            ValorDoDesconto = valorDoDesconto;
            ValorDaMulta = valorDaMulta;
            Idade = CalcularIdade(dataDeNascimento);
        }
        private int CalcularIdade(DateTime dataNascimento)
        {
            var idade = 0;
            var dataAtual = DateTime.Now;
            idade = dataAtual.Year - dataNascimento.Year;
            if (dataAtual.DayOfYear < dataNascimento.DayOfYear)
            {
                idade -= 1;
            }

            return idade;
        }
    }
}
