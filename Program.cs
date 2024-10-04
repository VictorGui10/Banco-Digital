// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

using System;
using System.Threading.Channels;
using BancoDigital;


Console.WriteLine("Seja bem vindo aos meus dois sistemas !");
Console.WriteLine("Banco Digital - RotciV e ConversorRD");
Console.WriteLine();
Console.WriteLine("Deseja acessar o Banco ou o Conversor de Moedas (REAL/DOLAR)?, digite 1 para BANCO DIGITAL ou digite 2 para CONVERSOR DE MOEDAS");
int decidiu = int.Parse(Console.ReadLine());

if (decidiu == 1)
{

    Banco c1 = new Banco();


    Console.WriteLine("Entre com o número da conta: ");
    c1.Conta = int.Parse(Console.ReadLine());

    Console.WriteLine("Entre com o nome do titular da conta: ");
    c1.Nome = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("Olá " + c1.Nome + ", digite qual será a sua proxima tarefa: ");
    Console.WriteLine();
     Console.WriteLine("Digite a opção 1, para - Depositar ");
     Console.WriteLine("Digite a opção 2, para - Sacar ");
     Console.WriteLine("Digite a opção 3, para - Verificar Saldo");
     Console.WriteLine("Digite a opção 4, para - Sair da Sessão");
     c1.Decisao2 = Console.ReadLine();


        while (c1.Decisao2 != "4") {

            if (c1.Decisao2 == "1")

            {
                Console.WriteLine();
                Console.WriteLine("Entre um valor para depósito: ");
                double dep = double.Parse(Console.ReadLine());
                c1.Depositar(dep);
                Console.WriteLine();
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine();
                Console.WriteLine(c1);
                Console.WriteLine();
                Console.WriteLine("Digite novamente qual vai ser a sua proxima tarefa: ");
                Console.WriteLine("Digite a opção 1, para - Depositar ");
                Console.WriteLine("Digite a opção 2, para - Sacar ");
                Console.WriteLine("Digite a opção 3, para - Verificar Saldo");
                Console.WriteLine("Digite a opção 4, para - Sair da Sessão");
                c1.Decisao2 = Console.ReadLine();

        }

            else if (c1.Decisao2 == "2")

            {
                Console.WriteLine("___informação aos usuários, todo saque efetuado é cobrado uma taxa de R$ 5,00____");
                Console.WriteLine();
                Console.WriteLine("Entre um valor para saque: ");
                double sacar = double.Parse(Console.ReadLine());
                while (sacar > c1.Saldo)

                {
                    Console.WriteLine("Você está tentando sacar um valor maior do que o saldo disponivel!, digite outro saque ou realize mais um deposíto !");
                    Console.WriteLine();
                    Console.WriteLine(c1);
                    Console.WriteLine();
                    Console.WriteLine("Entre um valor para saque: ");
                    sacar = double.Parse(Console.ReadLine());

                }
                {
                    c1.Sacar(sacar);
                    Console.WriteLine("Dados da conta atualizados: ");
                    Console.WriteLine();
                    Console.WriteLine(c1);
                }

                    Console.WriteLine();
                    Console.WriteLine("Digite novamente qual vai ser a sua proxima tarefa: ");
                    Console.WriteLine("Digite a opção 1, para - Depositar ");
                    Console.WriteLine("Digite a opção 2, para - Sacar ");
                    Console.WriteLine("Digite a opção 3, para - Verificar Saldo");
                    Console.WriteLine("Digite a opção 4, para - Sair da Sessão");
                    c1.Decisao2 = Console.ReadLine();

        }

            else if (c1.Decisao2 == "3")

            {
                Console.WriteLine();
                Console.WriteLine(c1);
                Console.WriteLine();
                Console.WriteLine("Digite novamente qual vai ser a sua proxima tarefa: ");
                Console.WriteLine("Digite a opção 1, para - Depositar ");
                Console.WriteLine("Digite a opção 2, para - Sacar ");
                Console.WriteLine("Digite a opção 3, para - Verificar Saldo");
                Console.WriteLine("Digite a opção 4, para - Sair da Sessão");
                c1.Decisao2 = Console.ReadLine();

        }

            else if (c1.Decisao2 == "4")
            {
                Console.WriteLine("FIM DA SESSÃO");
            }




            else
            {
                Console.WriteLine();
                Console.WriteLine("Opção Inválida,digite outra opção !!!!");
            }

        }
    }


else if (decidiu == 2)
{

    ConversorMoeda p1 = new ConversorMoeda();
    Console.WriteLine("Qual a cotação do dólar?!");
    p1.Dolar = double.Parse(Console.ReadLine());
    Console.WriteLine("Quantos doláres você vai comprar? ");
    p1.QuantReal = double.Parse(Console.ReadLine());
    p1.Conversor();
    Console.WriteLine(p1);
}

else
{
    Console.WriteLine("Opção inválida, tente novamente");
}






