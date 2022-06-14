using System;

namespace aula07refatoracao
{
    public class Conversao
    {
        public double cotacaoDoDolarHoje = 4.97;
        public const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
        public const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;

        public string converterRealParaDolar(double valorDaCompraEmReais)
        {
            double resultadoConversao;
            resultadoConversao = valorDaCompraEmReais / cotacaoDoDolarHoje;

            if (resultadoConversao < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
            {
                return "A compra mínima permitida é de $ 100,00.";
            }
            else if (resultadoConversao > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
            {
                return "A compra máxima permitida é de $ 2500,00.";
            }
            else
            {
                return $"Você pode comprar  ${Math.Round(resultadoConversao, 2)}";
            }
        }

        }
    
    internal class Program
    {
        static void Main(string[] args)
        {

            Conversao operacao01 = new Conversao();

            Console.WriteLine(operacao01.converterRealParaDolar(700));
        }         
        }
    }
