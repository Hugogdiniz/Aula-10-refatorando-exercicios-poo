using System;

namespace aula06refatoracao
{
    public class Usuario
    {
        public string nome;
        public int idade;
        public int anoAtual;


        public int CalcularAnoNascimento(int anoAtual, int idade)
        {
            int anoNascimento = anoAtual - idade;
            return anoNascimento;
        }
        public void ApresentarUsuario(string nome, int anoNascimento)
        {
            Console.WriteLine($"Olá {nome}, você nasceu em {anoNascimento}");
        }

    }
    
    
    public class Program
    {
        static void Main(string[] args)
        {
            Usuario user01 = new Usuario();

            Console.Write("Digite seu Nome: ");
            user01.nome = Console.ReadLine();

            Console.Write("Idade: ");
            user01.idade = int.Parse(Console.ReadLine());

            Console.Write("Ano Atual: ");
            user01.anoAtual = int.Parse(Console.ReadLine());

            user01.CalcularAnoNascimento(user01.anoAtual, user01.idade);
            user01.ApresentarUsuario(user01.nome, user01.CalcularAnoNascimento(user01.anoAtual, user01.idade));
            
        }
    }
}