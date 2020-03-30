using DAL;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaFerramentas : Form
    {
        public int codigo = 0;

        public frmConsultaFerramentas()
        {
            InitializeComponent();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            DLLFerramentas dll = new DLLFerramentas(cx);
            dgvDados.DataSource = dll.Localizar(txtNome.Text);
            label2.Visible = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaFerramentas_Load(object sender, EventArgs e)
        {
            btBusca_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Ferramenta";
            dgvDados.Columns[1].Width = 300;
            dgvDados.Columns[2].HeaderText = "Valor";
            dgvDados.Columns[2].Width = 80;
            dgvDados.Columns[3].HeaderText = "Data da Criação";
            dgvDados.Columns[3].Width = 80;
            dgvDados.Columns[4].Visible = false;
            dgvDados.Columns[5].Visible = false;
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();

            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNome.Text = Convert.ToString(dgvDados.Rows[e.RowIndex].Cells[1].Value);

            }
        }


    }
}
