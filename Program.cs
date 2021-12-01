using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular calculadora = new Calcular();
            calculadora.Show();
            Console.ReadKey();

        }
    }
    class Calcular
    {

        double valor1 = 0, valor2 = 0, resultado, numero;
        string operador, valorDigitado;
        bool isNumeroInteiro;

        public void Show()
        {
            Console.Title = "Calculadora";
            Console.WriteLine("============================ Calculadora ============================ ");
            Console.WriteLine("Digite o 1 valor: ");
            valorDigitado = Console.ReadLine();
            //VERIFICA SE É UM NUMERO
            isNumeroInteiro = double.TryParse(valorDigitado, out numero);
            //FAZ A VALIDAÇÃO
            if (isNumeroInteiro)
            {
                valor1 = Math.Round(double.Parse(valorDigitado), 4);
            }
            else
            {
                Console.WriteLine("Digite um número válido");
            }


            Console.WriteLine("Digite a operação (' / | + | * | - |') ");
            operador = Console.ReadLine();


            Console.WriteLine("Digite o 2 valor: ");
            valorDigitado = Console.ReadLine();
            isNumeroInteiro = double.TryParse(valorDigitado, out numero);
            if (isNumeroInteiro)
            {
                valor2 = Math.Round(double.Parse(valorDigitado), 4);
            }
            else
            {
                Console.WriteLine("Digite um número válido");
            }


            switch (operador)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 4);
                    Console.WriteLine($"{ valor1 } {'+'} { valor2 } = {resultado}");
                    break;
                case "-":
                    resultado = Math.Round(valor1 - valor2, 4);
                    Console.WriteLine($"{ valor1 } {'-'} { valor2 } = {resultado}");
                    break;
                case "*":
                    resultado = Math.Round(valor1 * valor2, 4);
                    Console.WriteLine($"{ valor1 } {'*'} { valor2 } = {resultado}");
                    break;
                case "/":
                    resultado = Math.Round(valor1 / valor2, 4);
                    Console.WriteLine($"{ valor1 } {'/'} { valor2 } = {resultado}");
                    break;

            }



            Console.ReadKey();
        }
    }

}
