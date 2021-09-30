using System;

namespace Revisão
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir Novo Aluno");
            Console.WriteLine("2- Listar Alunos");
            Console.WriteLine("3- Calcular Média Geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //To Do: adicionar aluno
                        break;
                    case "2":
                        //To Do Listar Aluno
                        break;
                    case "3":
                        //To Do Calcular Média geral
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1- Inserir Novo Aluno");
                Console.WriteLine("2- Listar Alunos");
                Console.WriteLine("3- Calcular Média Geral");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                opcaoUsuario = Console.ReadLine();
            }
        }
    }
}
