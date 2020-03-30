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
    public partial class frmConsultaEstado : Form
    {
        public int codigo = 0;
        public frmConsultaEstado()
        {
            InitializeComponent();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            btBusca.ImageIndex = 1;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            DLLEstado dll = new DLLEstado(cx);
            dgvDados.DataSource = dll.Localizar(txtNome.Text);
            label2.Visible = true;
            btBusca.ImageIndex = 0;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            btCancelar.ImageIndex = 3;
            this.Close();
            btCancelar.ImageIndex = 2;
        }

        private void frmConsultaEstado_Load(object sender, EventArgs e)
        {
            btBusca_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Estado";
            dgvDados.Columns[1].Width = 150;
            dgvDados.Columns[2].HeaderText = "Código do Estado";
            dgvDados.Columns[2].Width = 150;
            dgvDados.Columns[3].HeaderText = "Código do País";
            dgvDados.Columns[3].Width = 120;
            dgvDados.Columns[4].HeaderText = "Data da Criação";
            dgvDados.Columns[4].Width = 110;
            dgvDados.Columns[5].Visible = false;
            dgvDados.Columns[6].Visible = false;
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
