using System;

namespace Calculadora
{
    public class Program
    {
        // Método
        public static void Main(string[] args)  // Para passar algum valor no momento da execução.
        {
            Console.WriteLine("Bem-Vindo a Calculadora!\nClique em qualquer tecla para iniciar. ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Iniciando...");

            if (args.Length > 0)
            {
                foreach (string item in args)
                {
                    Console.WriteLine($"Recebi o valor: {item}");
                }

            }
            else
            {
                Console.WriteLine("Você não passou nenhum nome de arquivo\n");
            }




            while (true)
            {
                Console.WriteLine("\nMenu de Operações\n1- Adição\n2- Subtração\n3- Multiplicação\n4- Divisão\n5- Sair");
                int opcao = int.Parse(Console.ReadLine());

                // Tratar erro de opcão não listada
                if (opcao < 1 || opcao > 5)
                {
                    Console.WriteLine("Digite uma operação válida!");
                    continue;
                }

                if (opcao == 5)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }


                Console.WriteLine("Digite o primeiro número: ");
                string texto = Console.ReadLine();
                // Conversão de string para int com TryParse
                bool converteuComSucesso = double.TryParse(texto, out double numero1);

                if (converteuComSucesso)
                {
                    Console.WriteLine($"Conversão com sucesso para: {numero1}\n");
                }
                else
                {
                    Console.WriteLine("Erro: Isso não é número válido!");
                    continue;
                }


                Console.WriteLine("Digite o segundo número: ");
                texto = Console.ReadLine();

                converteuComSucesso = double.TryParse(texto, out double numero2);

                if (converteuComSucesso)
                {
                    Console.WriteLine($"Conversão com sucesso para: {numero2}\n");
                }
                else
                {
                    Console.WriteLine("Erro: Isso não é número válido!");
                    continue;
                }


                switch (opcao)
                {
                    case 1:
                        double resultado = Calcule.Adicao(numero1, numero2);
                        Calcule.MensagemSucesso();
                        Console.WriteLine($"O resultado da soma entre {numero1} e {numero2} é: {resultado:F2}\n");
                        break;

                    case 2:
                        resultado = Calcule.Subtracao(numero1, numero2);
                        Calcule.MensagemSucesso();
                        Console.WriteLine($"O resultado da subtração entre {numero1} e {numero2} é: {resultado:F2}\n");
                        break;

                    case 3:
                        resultado = Calcule.Multiplicacao(numero1, numero2);
                        Calcule.MensagemSucesso();
                        Console.WriteLine($"O resultado da Multiplicação entre {numero1} e {numero2} é: {resultado:F2}\n");
                        break;

                    case 4:
                        if (numero2 == 0)
                        {
                            Console.WriteLine("Não existe divisão por zero");
                        }
                        else
                        {
                            double resultadoDivisao = Calcule.Divisao(numero1, numero2);
                            Calcule.MensagemSucesso();
                            Console.WriteLine($"O resultado da Divisão entre {numero1} e {numero2} é: {resultadoDivisao:F2}\n");
                        }
                        break;


                }

            }

        }


    }

    // Classe Calcule e seus métodos (Funções)
    public class Calcule
    {
        public static void MensagemSucesso()
        {
            Console.WriteLine("Calculo realizado com sucesso!");
        }
        public static double Adicao(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Subtracao(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Divisao(double n1, double n2)
        {
            return n1 / n2;  
        }


    }
}











