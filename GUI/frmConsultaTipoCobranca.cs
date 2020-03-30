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
    public partial class frmConsultaTipoCobranca : Form
    {
        public int codigo = 0;

        public frmConsultaTipoCobranca()
        {
            InitializeComponent();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            DLLTipoCobranca dll = new DLLTipoCobranca(cx);
            dgvDados.DataSource = dll.Localizar(txtNome.Text);
            label2.Visible = true;
        }

        private void frmConsultaTipoCobranca_Load(object sender, EventArgs e)
        {
            btBusca_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Tipo de Cobrança";
            dgvDados.Columns[1].Width = 340;
            dgvDados.Columns[2].HeaderText = "Data da Criação";
            dgvDados.Columns[2].Width = 120;
            dgvDados.Columns[3].Visible = false;
            dgvDados.Columns[4].Visible = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
