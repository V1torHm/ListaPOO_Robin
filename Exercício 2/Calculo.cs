using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    public class Calculo
    {

        private double Resultado;
        public double ValorA;
        public double ValorB;


        public void CalcularSoma()
        {
            Resultado = ValorA + ValorB;
        }

        public void CalcularSubtracao()
        {
            Resultado = ValorA - ValorB;
        }

        public void CalcularMultiplicacao()
        {
            Resultado = ValorA * ValorB;
        }

        public void RetornarMaior()
        {
            if (ValorA > ValorB)
            {
                Console.WriteLine(ValorA);
            }
            else
            {
                Console.WriteLine(ValorB);
            }
        }

        public void SomarGeral(double valor)
        {
            Resultado = ValorA + ValorB + valor;
        }

        public void ImprimirResultado()
        {
            Console.WriteLine(Resultado);
        }

    }
}
