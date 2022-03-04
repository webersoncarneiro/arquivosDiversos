using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //declaração de variáreis, recebe conteúdo do textbox
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);
            // textbox recebe o conteúdo
            txtImc.Text = imc.ToString("0.00");

            if (imc < 18.49)
                MessageBox.Show("Situação: Você está abaixo do peso ", "Atenção", MessageBoxButtons.OK);
            else if (imc > 18.5 && imc <= 24.99)
                MessageBox.Show("Situação : Você está no peso normal", "Atenção", MessageBoxButtons.OK);
            else if (imc > 25 && imc <= 29.99)
                MessageBox.Show("Situação : Você está acima do peso ", "Cuidado" ,MessageBoxButtons.OK);
            else if (imc > 30 && imc <= 34.99)
                MessageBox.Show("Situação : Você está com obesidade grau 1", "Cuidado", MessageBoxButtons.OK);
            else if (imc > 35 && imc <= 39.99)
                MessageBox.Show("Situação : Você está com obesidade grau 2(Severa)", "Alerta", MessageBoxButtons.OK);
            else
                MessageBox.Show("Situação : Você está com obesidade grau  3(Mórbida)", "Procure ajuda", MessageBoxButtons.OK);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Text = "";
            txtPeso.Text = "";
            txtImc.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
