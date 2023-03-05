using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        double num1, num2;
        int opcao = 0;

        double Addition()
        {
            double soma = num1 + num2;
            Console.WriteLine($" {num1} + {num2} = {soma}");
            Console.ReadLine();
            return soma;   
        }

        double Subtraction()
        {
            double subtraction = num1 - num2;
            Console.WriteLine($" {num1} - {num2} = {subtraction}");
            return subtraction;   
        }

        double Division()
        {
            if (num2 == 0)
            {
                Console.WriteLine("Não existe divisão por zero");
                return 0;
            }
            else
            {
                double division = num1/num2;
                Console.WriteLine($" {num1} / {num2} = {division}");
                return division;
            }
            
        }

        double Multiplication()
        {
            double multiplication = num1 * num2;
            Console.WriteLine($" {num1} * {num2} = {multiplication}");
            return multiplication;
        }

        int Menu()
        {
            Console.Clear();
            Console.WriteLine("1- Somar");
            Console.WriteLine("2- Subtrair");
            Console.WriteLine("3- Multiplicar");
            Console.WriteLine("4- Dividir");
            Console.WriteLine("5- Sair");
            Console.Write(" Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Addition();
                    Console.ReadLine();
                    break;

                case 2:
                    Subtraction();
                    Console.ReadLine();
                    break;

                case 3:
                    Multiplication();
                    Console.ReadLine();
                    break;

                case 4:
                    Division();
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Até mais :) ");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    Console.ReadLine();
                    break;
            }
            return opcao;
        }

        Console.WriteLine("Informe o 1° número: ");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o 2° número: ");
        num2 = double.Parse(Console.ReadLine()); 

        while(opcao != 5)
        {
            Menu();  //chamada de função
        }
        
    }
}