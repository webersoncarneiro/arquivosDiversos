using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ContaBancaria
    {
        public string Nome { get; private set; }
        public int Numero { get; set; }
        public string Banco { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int numero, string banco)
        {
            Nome = nome;
            Numero = numero;
            Banco = banco;
         
        }

        public ContaBancaria (string nome, int numero, string banco, double depositoInicial) : this (nome, numero, banco)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.0;
        }

        public override string ToString()
        {
            return "Name : "
                + Nome
                + ", "
                + "Numero: "
                + Numero
                +", "
                + "Banco: "
                + Banco
                + ", "
                + "saldo: "
                + Saldo.ToString();

        }
    }
}
