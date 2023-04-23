using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    public class Calculadora
    {
        Calculo calculadora = new Calculo();

        public void LerValores()
        {
            Console.WriteLine("Digite o valor A:");
            calculadora.ValorA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor B:");
            calculadora.ValorB = Convert.ToDouble(Console.ReadLine());
        }

        public void ExecutarCalculadora()

        {
            int valor;
            do
            {
                Console.WriteLine("Escolha uma das seguintes opções:  1=Somar  2=Subtrair  3=Multiplicar  4=Retornar o maior valor  5=Soma geral.  6= Sair.");
                valor = int.Parse(Console.ReadLine());

                switch (valor)
                {
                    case 1:
                        calculadora.CalcularSoma();
                        calculadora.ImprimirResultado();
                        break;

                    case 2:
                        calculadora.CalcularSubtracao();
                        calculadora.ImprimirResultado();
                        break;

                    case 3:
                        calculadora.CalcularMultiplicacao();
                        calculadora.ImprimirResultado();
                        break;

                    case 4:
                        calculadora.RetornarMaior();
                        break;

                    case 5:
                        calculadora.SomarGeral(50.30);
                        calculadora.ImprimirResultado();
                        break;

                    case 6:
                        Console.WriteLine("Obrigado por utilizar a calculadora!!");
                        break;

                    default:
                        Console.WriteLine("Você não digitou uma opção válida. Favor digitar novamente!");
                        break;
                }
            }
            while (valor != 6);
        }



    }
}
