using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Funcionario
    {
        // definição dos parametros

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        // Construtor 

        public Funcionario(int id, string nome, double salario){
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        // Metodo para aumentar salario

        public void AumentarSalario(double porcentagem){
            Salario += Salario * porcentagem / 100.0;
        }

        //Mudança para tipo double

        public override string ToString(){
            return Id
                + ", "
                + Nome
                + " , "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}




