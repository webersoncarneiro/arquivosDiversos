using System;
using System.Globalization;

namespace Cadastro1{
    class Clientes{

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        public double Pagamento { get; private set; }
        
        public Clientes(string nome, string email, string endereco,int telefone){
            Nome = nome;
            Email = email;
            Endereco = endereco;
            Telefone = telefone;
        }

        public Clientes(string nome, string email, string endereco, int telefone,double debitoAnterior): this (nome, email, endereco, telefone){
            Pagamento = debitoAnterior;
            
        }

        public void Pagar(double valor){
            Pagamento += valor;
        }

        public override string ToString(){
            return " O nome do cliente é : "
                + Nome
                + " , "
                + " com o email : "
                + Email
                + " ,"
                + " com o número de telefone :"
                + Telefone
                + " e com o endereço : "
                + Endereco
                + " e com o saldo : "
                + Pagamento.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
