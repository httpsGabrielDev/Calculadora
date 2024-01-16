using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pergunta ao usuario qual operação ele deseja realizar.
            Console.WriteLine("Qual operação você deseja realizar: ");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");

            //Recebe o numero, o int.parse converte string numero em inteiro.
            int operacao = int.Parse(Console.ReadLine()); 

            //abaixo recebemos os dois valores a serem calculados.
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine()); //int num1 armazena o numero 1 na variavel num1.

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine()); //int num2 armazena o numero 2 na variavel num2.

            int resultado = 0; //Aqui criamos a variavel resultado.

            string operacao2 = ""; // serve para mostrar ao usuario na saida de resultados a operação selecionada

            switch (operacao) //decidi ultilizar um switch aonde cada operação selecionada equivale a um codigo.
            {
                case 1: //case 1 equivale a escolha da operação 1 (Adição).
                    {
                        resultado = Adicao(num1, num2); //executa a variavel Adicao que está na linha 65
                         operacao2 = "adição";
                        break;
                    }
                case 2: //case 2 equivale a escolha da operação 1 (Subtração).
                    {
                        resultado = Subtracao(num1, num2); //executa a variavel Subtracao que está na linha 71
                        operacao2 = "Subtração";
                        break;
                    }
                case 3: //case 3 equivale a escolha da operação 1 (Multiplicação).
                    {
                        resultado = Multiplicacao(num1, num2); //executa a variavel Multiplicacao que está na linha 77
                         operacao2 = "Multiplicação";
                        break;
                    }
                case 4: //case 4 equivale a escolha da operação 1 (Divisão).
                    {
                        resultado = Divisao(num1, num2); //executa a variavel Divisao que está na linha 83
                        operacao2 = "Divisão";
                        break;
                    }

                default: //default pede ao usuario digitar outro numero caso o que ele escolha não seja uma operação
                    Console.WriteLine("Numero invalido, digite outro numero.");
                    break;
            }
            //Na linha abaixo ele retorna ao usuario a operação e os numeros escolhidos para a operação e o resultado final.
            Console.WriteLine("O resultado da {0} com os números {1} e {2} é {3}", operacao2, num1, num2, resultado);

            Console.ReadLine(); //Este readline previne que o codigo feche antes de mostrar o resultado.
        }


        public static int Adicao (int numero1, int numero2) //Aqui foi criada a variavel adição aonde ele realiza a soma.
        {
            int result = numero1 + numero2;
            return result;
        }

        public static int Subtracao(int numero1, int numero2) //Aqui foi criada a variavel subtração aonde ele realiza a subtração.
        {
            int result = numero1 - numero2;
            return result;
        }

        public static int Multiplicacao(int numero1, int numero2) //Aqui foi criada a variavel multiplicação aonde ele realiza a multiplicação.
        {
            int result = numero1 * numero2;
            return result;
        }

        public static int Divisao(int numero1, int numero2) //Aqui foi criada a variavel divisão aonde ele realiza a divisão.
        {
            int result = numero1 / numero2;
            return result;
        }
    }
}