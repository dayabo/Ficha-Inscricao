using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaInscricoes
{
    public class CobrarCurso
    {
        private float ValorCurso;
        private float ValorMulta;
        private float ValorDeDesconto;
        public float Resultado;

        public float RetornaValorResultado(float valor, float multa, float desconto)
        {
            return this.Calcular(valor, multa, desconto);
        }

        private float Calcular(float valor, float multa, float desconto)
        {
            if (multa > 0)

                Resultado = valor + multa;

            else if (multa <= 0)

                Resultado = valor - desconto;

            return 0;

        }
    }
}
