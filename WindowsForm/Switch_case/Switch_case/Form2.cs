using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            //Apresenta o formulário e chama em seguida
            novo.Show();
            //fecha o formulário atual
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(cboOpcao.Text)

            {
                case "1 ou 2":
                    lblRes.Text = "O dia de seu rodízio é Segunda feira";
                    break;
                case "3 ou 4":
                    lblRes.Text = "O dia de seu rodízio é Terça feira";
                    break;
                case "5 ou 6":
                    lblRes.Text = "O dia do seu rodízio é Quarta feira";
                    break;
                case "7 ou 8":
                    lblRes.Text = "O dia do seu rodízio é Quinta feira";
                    break;
                case "9 ou 0":
                    lblRes.Text = "O dia do seu rodízio é Sexta feira";
                    break;
                
            }
        }
    }
}
