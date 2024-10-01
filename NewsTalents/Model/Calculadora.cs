using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsTalents.Model
{
    public class Calculadora
    {
        static void Main(string[] args){
            // Criar um menu para o usuário escolher a operação desejada
            Console.WriteLine("Escolha uma opçao: 1-Somar,2-Subtrair,3-Multiplicar,4-Dividir");

            // lê se a opção escolhida pelo usuário
            int operacao = int.Parse(Console.ReadLine());

            // solicitando doi números
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            // VARIÁVEL PARA ARMAZENAR O RESULTADO DAS OPERAÇÕES
            double resultado = operacao switch{
                // Executa operação com base na escolha
                1 => Somar(num1,num2),
                2 => Subtrair(num1,num2),
                3 => multiplicar(num1,num2),
                4 => Dividir(num1,num2),
                _ => throw new ArgumentException("Operação inválida")
            };
            
        }
    }
}