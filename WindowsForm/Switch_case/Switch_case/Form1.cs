using System;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSemana.Text)
            //o conteudo do combobox será analisada de acordo com a opção escolhida pelo usuário, 
            //seja qual for o dia escolhido da semana, aparacerá um alerta para o usuário
            {
                case "Domingo":
                    MessageBox.Show("Este é o primeiro dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Segunda":
                    MessageBox.Show("Este é o segunda dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Terça":
                    MessageBox.Show("Este é o terceiro dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quarta":
                    MessageBox.Show("Este é o quarto dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quinta":
                    MessageBox.Show("Este é o quinta dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sexta":
                    MessageBox.Show("Este é o sexto dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                default:
                    MessageBox.Show("Este é o sétimo dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            // instancia um novo objeto e o chama logo em seguida;
            novo.Show();
            // fecha o formulário atual
            this.Visible = false;

        }
    }
}
