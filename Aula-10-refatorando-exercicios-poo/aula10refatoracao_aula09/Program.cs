﻿namespace aula10refatoracao_aula09
{

    public class calculadora
    {
        public double resultado = 0;

        public double somarValor()
        {
            double valor;
            double resultadoFuncao;
            Console.WriteLine("Você digitou 1 - Somar");
            Console.WriteLine("Qual valor deseja Somar");
            try
            {
                valor = double.Parse(Console.ReadLine());
                resultadoFuncao = resultado + valor;
                definirResultadoDaUltimaOperacaoMatematica(resultadoFuncao);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Você deve digitar um número -> " + ex.Message);
            }







            return pegarResultadoDaUltimaOperacaoMatematica();
        }

        public double subtrairValor()
        {
            double valor;
            double resultadoFuncao;
            Console.WriteLine("Você digitou 2 - Subtrair");
            Console.WriteLine("Qual valor deseja Subtrair?");
            try
            {
                valor = double.Parse(Console.ReadLine());
                resultadoFuncao = resultado - valor;
                definirResultadoDaUltimaOperacaoMatematica(resultadoFuncao);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Você deve digitar um número -> " + ex.Message);
            }




            return pegarResultadoDaUltimaOperacaoMatematica();
        }

        public void dividePorZero(double valor)
        {
            if (valor == 0)
            {
                throw new DivideByZeroException(message: "Não pode ser zero");
            }
        }

        public double dividirValor()
        {

            double valor;
            double resultadoFuncao;
            Console.WriteLine("Você digitou 4 - Dividir");
            Console.WriteLine("Qual valor deseja Dividir?");
            try
            {
                valor = double.Parse(Console.ReadLine());
                try
                {
                    dividePorZero(valor);
                    resultadoFuncao = resultado / valor;
                    definirResultadoDaUltimaOperacaoMatematica(resultadoFuncao);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Não pode dividir por zero");

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Você deve digitar um número -> " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Não pode dividir por zero");

            }
            return pegarResultadoDaUltimaOperacaoMatematica();
        }

        public double multiplicarValor()
        {
            double valor;
            double resultadoFuncao;
            Console.WriteLine("Você digitou 3 - Multiplicar");
            Console.WriteLine("Qual valor deseja Multiplicar?");
            try
            {
                valor = double.Parse(Console.ReadLine());
                resultadoFuncao = resultado * valor;
                definirResultadoDaUltimaOperacaoMatematica(resultadoFuncao);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Você deve digitar um número -> " + ex.Message);
            }

            return pegarResultadoDaUltimaOperacaoMatematica();
        }
        
        public void zerarResultado()
        {
            definirResultadoDaUltimaOperacaoMatematica(0);
        }

        public double pegarResultadoDaUltimaOperacaoMatematica()
        {

            return resultado;
        }

        public void definirResultadoDaUltimaOperacaoMatematica(double resultadoFuncao)
        {
            resultado = resultadoFuncao;
        }

        public int menu()
        {
            int op;
            Console.WriteLine("Menu de opções da calculadora");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Zerar Calculadora");
            Console.WriteLine("0 - Terminar");
            Console.WriteLine("Sua opção: ");
            op = int.Parse(Console.ReadLine());

            return op;
        }
        public int opcao;
        public int continua = 1;
        public double ultimoValor;
        
        
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            calculadora calculadora01 = new calculadora();

            do
            {
                calculadora01.opcao = calculadora01.menu();
                switch (calculadora01.opcao)
                {
                    case 0:
                        calculadora01.continua = 0;
                        break;
                    case 1:

                        Console.WriteLine(calculadora01.somarValor());
                        break;
                    case 2:
                        Console.WriteLine(calculadora01.subtrairValor());
                        break;
                    case 3:

                        Console.WriteLine(calculadora01.multiplicarValor());
                        break;
                    case 4:
                        Console.WriteLine(calculadora01.dividirValor());
                        break;
                    case 5:
                        calculadora01.zerarResultado();
                        break;
                    default:
                        Console.WriteLine("Opção invalida! Por favor digite uma das opções acima.");
                        break;
                }

            } while (calculadora01.continua != 0);
        }
    }
}













// double resultado = 0;



//double somarValor()
//{
//    double valor;
//    double resultadoFuncao;
//    Console.WriteLine("Você digitou 1 - Somar");
//    Console.WriteLine("Qual valor deseja Somar");
//    try
//    {
//        valor = double.Parse(Console.ReadLine());
//        resultadoFuncao = resultado + valor;
//        definirResultadoDaUltimaOperacaoMatematica(resultadoFuncao);
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine("Você deve digitar um número -> " + ex.Message);
//    }







//    return pegarResultadoDaUltimaOperacaoMatematica();
//}

//double subtrairValor()
//{
//    double valor;
//    double resultadoFuncao;
//    Console.WriteLine("Você digitou 2 - Subtrair");
//    Console.WriteLine("Qual valor deseja Subtrair?");
//    try
//    {
//        valor = double.Parse(Console.ReadLine());
//        resultadoFuncao = resultado - valor;
//        definirResultadoDaUltimaOperacaoMatematica(resultadoFuncao);
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine("Você deve digitar um número -> " + ex.Message);
//    }




//    return pegarResultadoDaUltimaOperacaoMatematica();
//}

//void dividePorZero(double valor)
//{
//    if (valor == 0)
//    {
//        throw new DivideByZeroException(message: "Não pode ser zero");
//    }
//}

//double dividirValor()
//{

//    double valor;
//    double resultadoFuncao;
//    Console.WriteLine("Você digitou 4 - Dividir");
//    Console.WriteLine("Qual valor deseja Dividir?");
//    try
//    {
//        valor = double.Parse(Console.ReadLine());
//        try
//        {
//            dividePorZero(valor);
//            resultadoFuncao = resultado / valor;
//            definirResultadoDaUltimaOperacaoMatematica(resultadoFuncao);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Não pode dividir por zero");

//        }
//    }
//    catch (FormatException ex)
//    {
//        Console.WriteLine("Você deve digitar um número -> " + ex.Message);
//    }

//    catch (Exception ex)
//    {
//        Console.WriteLine("Não pode dividir por zero");

//    }
//    return pegarResultadoDaUltimaOperacaoMatematica();
//}

//double multiplicarValor()
//{
//    double valor;
//    double resultadoFuncao;
//    Console.WriteLine("Você digitou 3 - Multiplicar");
//    Console.WriteLine("Qual valor deseja Multiplicar?");
//    try
//    {
//        valor = double.Parse(Console.ReadLine());
//        resultadoFuncao = resultado * valor;
//        definirResultadoDaUltimaOperacaoMatematica(resultadoFuncao);
//    }

//    catch (FormatException ex)
//    {
//        Console.WriteLine("Você deve digitar um número -> " + ex.Message);
//    }

//    return pegarResultadoDaUltimaOperacaoMatematica();
//}

//void zerarResultado()
//    {
//        definirResultadoDaUltimaOperacaoMatematica(0);
//    }

//double pegarResultadoDaUltimaOperacaoMatematica()
//{

//    return resultado;
//}

//void definirResultadoDaUltimaOperacaoMatematica(double resultadoFuncao)
//{
//    resultado = resultadoFuncao;
//}

//int menu()
//{
//    int op;
//    Console.WriteLine("Menu de opções da calculadora");
//    Console.WriteLine("1 - Somar");
//    Console.WriteLine("2 - Subtrair");
//    Console.WriteLine("3 - Multiplicar");
//    Console.WriteLine("4 - Dividir");
//    Console.WriteLine("5 - Zerar Calculadora");
//    Console.WriteLine("0 - Terminar");
//    Console.WriteLine("Sua opção: ");
//    op = int.Parse(Console.ReadLine());

//    return op;
//}
//int opcao;
//int continua = 1;
//double ultimoValor;
//do
//{

//    opcao = menu();
//    switch (opcao)
//    {
//        case 0:
//            continua = 0;
//            break;
//        case 1:

//            Console.WriteLine(somarValor());
//            break;
//        case 2:
//            Console.WriteLine(subtrairValor());
//            break;
//        case 3:

//            Console.WriteLine(multiplicarValor());
//            break;
//        case 4:
//            Console.WriteLine(dividirValor());
//            break;
//        case 5:
//            zerarResultado();
//            break;
//        default:
//            Console.WriteLine("Opção invalida! Por favor digite uma das opções acima.");
//            break;
//    }

//} while (continua != 0);