using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSYN
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            progressBarLogin.Value = 0;

            while (progressBarLogin.Value < 100)
            {
                progressBarLogin.Value = progressBarLogin.Value + 2;
            }

            FormPrincipal frmp = new FormPrincipal();
            frmp.Show();
            this.Visible = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
               
    }
}
