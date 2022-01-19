using System;

public class Program
{
    public static void Main(string[] args)
    {
        double numeroUm = 0;
        double numeroDois = 0;
        double resultado = 0;

        Console.WriteLine("Seja bem vindo(a) a primeira calculadora do Gabriel");

        Console.WriteLine("Digite um numero");
        numeroUm = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a operacao -> Soma, Subtração, Multiplicação, Divisão, Porcentagem");
        var operacao = Console.ReadLine();

        Console.WriteLine("Digite o segundo numero");
        numeroDois = double.Parse(Console.ReadLine());

        if (operacao == "+")
        {
            Console.WriteLine(numeroUm + numeroDois);
        }
        else if (operacao == "-")
        {
            Console.WriteLine(numeroUm - numeroDois);
        }
        else if (operacao == "*")
        {
            Console.WriteLine(numeroUm * numeroDois);
        }
        else if (operacao == "/")
        {
            Console.WriteLine(numeroUm / numeroDois);
        }
        else if (operacao == "%")
        {
            Console.WriteLine(numeroUm % numeroDois);
        }
        else if (operacao != "+, -, *, /, %")
        {
            Console.WriteLine("Operacao negada, favor colocar um operador válido");
        }
    }
}