using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceito_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            while (c < 1000)
            {
                c = c + 1;
                lblNumero.Text = Convert.ToString(c);
                lblNumero.Refresh();
                // declaração de variável c, inicializando com zero.
                //condição enquanto o c for menor que 1000, irá repetir o laço
                // refresh varia os números.

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
