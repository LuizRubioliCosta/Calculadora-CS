using System;

namespace Calculadora
{
    class Program
    {
        enum Menu {soma=1, subt, mult, div, pot, raiz, sair}
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t BEM VINDO A CALCULADORA\n\n ");
            bool saida =false;
            while (!saida)
            {
                Console.WriteLine("Digite a operação que deseja efetuar:\n\n1- Soma\n\n2- Subtração\n\n3- Multiplicação\n\n4- Divisão\n\n5- Potência\n\n6- Raiz Quadrada\n\n7- Sair");
                Menu opçaoSel = (Menu)int.Parse(Console.ReadLine());

                switch (opçaoSel)
                {
                    case Menu.soma:
                    soma();
                    break;

                    case Menu.subt:
                    subt();
                    break;

                    case Menu.mult:
                    mult();
                    break;

                    case Menu.div:
                    div();
                    break;

                    case Menu.pot:
                    pot();
                    break;

                    case Menu.raiz:
                    raiz();
                    break;

                    case Menu.sair:
                    saida = true;
                    break;

                    default:
                    Console.Clear();
                    Console.WriteLine("\n\n\tDIGITE UMA OPÇÃO VÁLIDA !!!\n\n");
                    break;
                }


            }
            
        }

                static void soma()
                {
                    Console.Clear();
                    Console.WriteLine("Digite o primeiro número da soma: ");
                    float a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número da soma: ");
                    float b = float.Parse(Console.ReadLine());
                    float resultado = a + b;
                    Console.WriteLine("O resultado da soma entre " + a + " e " + b + " é: " + resultado);
                    Console.WriteLine("APERTE ENTER PARA VOLTAR AO MENU");
                    Console.ReadLine();
                    Console.Clear();
                }

                 static void subt()
                {
                    Console.Clear();
                    Console.WriteLine("Digite o primeiro número da subtração: ");
                    float a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número da subtração: ");
                    float b = float.Parse(Console.ReadLine());
                    float resultado = a - b;
                    Console.WriteLine("O resultado da subtração entre " + a + " e " + b + " é: " + resultado);
                    Console.WriteLine("APERTE ENTER PARA VOLTAR AO MENU");
                    Console.ReadLine();
                    Console.Clear();
                }

                static void mult()
                {
                    Console.Clear();
                    Console.WriteLine("Digite o primeiro número da multiplicação: ");
                    float a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número da multiplicação: ");
                    float b = float.Parse(Console.ReadLine());
                    float resultado = a * b;
                    Console.WriteLine("O resultado da multiplicação entre " + a + " e " + b + " é: " + resultado);
                    Console.WriteLine("APERTE ENTER PARA VOLTAR AO MENU");
                    Console.ReadLine();
                    Console.Clear();
                }

                static void div()
                {
                    Console.Clear();
                    Console.WriteLine("Digite o primeiro número da divisão: ");
                    float a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número da divisão: ");
                    float b = float.Parse(Console.ReadLine());
                    float resultado = a / b;
                    Console.WriteLine("O resultado da divisão entre " + a + " e " + b + " é: " + resultado);
                    Console.WriteLine("APERTE ENTER PARA VOLTAR AO MENU");
                    Console.ReadLine();
                    Console.Clear();
                }

                static void pot()
                {
                    Console.Clear();
                    Console.WriteLine("Digite o número base: ");
                    float a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o expoente: ");
                    float b = float.Parse(Console.ReadLine());
                    double resultado = Math.Pow(a,b);
                    Console.WriteLine("O resultado da potência onde a base é " + a + " e o expoente " + b + " é: " + resultado);
                    Console.WriteLine("APERTE ENTER PARA VOLTAR AO MENU");
                    Console.ReadLine();
                    Console.Clear();
                }

                static void raiz()
                {
                    Console.Clear();
                    Console.WriteLine("Digite o número a ser encontrada a raiz quadrada: ");
                    float a = float.Parse(Console.ReadLine());
                    double resultado = Math.Sqrt(a);
                    Console.WriteLine("O resultado da raiz quadrada de " + a  + " é: " + resultado);
                    Console.WriteLine("APERTE ENTER PARA VOLTAR AO MENU");
                    Console.ReadLine();
                    Console.Clear();
                }
    }
}
