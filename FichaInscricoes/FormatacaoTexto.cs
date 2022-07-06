using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaInscricoes
{
    internal class FormatacaoTexto : CobrarCurso
    {
        public static string FichaFormatacao(string? nome, string? curso, float valorCurso, float resultado)
        {
            return $"Nome: {nome.ToUpper()} | Curso: {curso.ToUpper()} | Valor do Curso: {valorCurso.ToString("c")} | Resultado {resultado.ToString("c")}";
        }
        public static string FichaFormatacao(string? nome, string? curso, float valorCurso, float valorDesconto, float resultado)
        {
            return $"Nome: {nome.ToUpper()} | Curso: {curso.ToUpper()} | Valor do Curso: {valorCurso.ToString("c")} | Valor Desconto: {valorDesconto.ToString("c")} | Resultado {resultado.ToString("c")}";
        }
        public static string FichaFormatacao(string? nome, string? curso, float valorCurso, float valorDesconto, int idade, float resultado)
        {
            return $"Nome: {nome.ToUpper()} | Curso: {curso.ToUpper()} | Valor do Curso: {valorCurso.ToString("c")} | Valor Desconto: {valorDesconto.ToString("c")} | Idade: {idade}| Resultado {resultado.ToString("c")}";
        }
    }
}
