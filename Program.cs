
using System;
using NCalc;

namespace CalculadoraTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool escolha = true;

            while (escolha)
            {
                Console.WriteLine("Digite sua expressão matemática ou sair):");
                string expressao = Console.ReadLine();

                if (expressao.ToLower() == "sair")
                {
                    escolha = false;
                    Console.WriteLine("Programa Finalizado");
                }
                else
                {
                        Expression exp = new Expression(expressao);
                        object resultado = exp.Evaluate();
                        Console.WriteLine("Resultado da expressão: " + resultado);
                }
            }
        }
    }
}