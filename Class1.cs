using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDigital
{
    public class Banco
    {
        public string Nome;
        public int Conta;
        public double Saldo;
        public double Saque;
        public string Decisao2;
        public double Deposito;



        public Banco(string nome, int conta, double di, double dep, double saque)  //aqui eu estou forçando o usuario digitar estas informações
        {
            Nome = nome;
            Conta = conta;
            Deposito = dep;
            Saque = saque;

        }

        public Banco()
        {
            // construtor padrao/vazio, para poder deixar em branco as info
        }

        public double Depositar(double dep) //aqui o metodo vai pegar todo o deposito e atribuiir no saldo
        {
            return Saldo = Saldo + dep;
        }


        public double Sacar(double sacar) //aqui o metodo vai sacar/subtrair todo o valor e atribuiir no saldo
        {
            return Saldo = (Saldo - sacar) - 5;
        }


        public override string ToString() //método para imprimir os valores do produto
        {
            return "Conta " + Conta + "," + "Titular: " + Nome + "," + "Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture); ;
        }



    }

   
}



       
