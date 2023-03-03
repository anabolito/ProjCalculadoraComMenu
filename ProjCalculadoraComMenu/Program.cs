using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        double num1, num2;
        int opcao = 0;

        void Menu()
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
                    Console.WriteLine("A soma dos números é: " + (num1 + num2));
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("A subtração dos números é: " + (num1 - num2));
                    Console.ReadLine();

                    break;

                case 3:
                    Console.WriteLine("A multiplicação dos números é: " + (num1 * num2));
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("A divisão dos números é: " + (num1 / num2));
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