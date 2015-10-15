using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class FormDeposit : Form
    {
        public FormDeposit()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; //Abre o form maximizado
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o depósito?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
