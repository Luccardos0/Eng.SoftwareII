// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();

        Console.WriteLine("===== CALCULADORA SIMPLES =====");
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEscolha a operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.Write("Opção: ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        try
        {
            double resultado = 0;

            switch (opcao)
            {
                case 1:
                    resultado = calc.Somar(num1, num2);
                    break;
                case 2:
                    resultado = calc.Subtrair(num1, num2);
                    break;
                case 3:
                    resultado = calc.Multiplicar(num1, num2);
                    break;
                case 4:
                    resultado = calc.Dividir(num1, num2);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }

            Console.WriteLine($"\nResultado: {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}

