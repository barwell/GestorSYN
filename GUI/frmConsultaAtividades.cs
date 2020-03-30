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
    public partial class frmConsultaAtividades : Form
    {
        public int codigo = 0;

        public frmConsultaAtividades()
        {
            InitializeComponent();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            DLLAtividades dll = new DLLAtividades(cx);
            dgvDados.DataSource = dll.Localizar(txtNome.Text);
            label2.Visible = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaAtividades_Load(object sender, EventArgs e)
        {
            btBusca_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Atividade";
            dgvDados.Columns[1].Width = 210;
            dgvDados.Columns[2].HeaderText = "Dias";
            dgvDados.Columns[2].Width = 50;
            dgvDados.Columns[3].HeaderText = "Horas";
            dgvDados.Columns[3].Width = 50;
            dgvDados.Columns[4].HeaderText = "Minutos";
            dgvDados.Columns[4].Width = 50;
            dgvDados.Columns[5].HeaderText = "Horas/ Dia";
            dgvDados.Columns[5].Width = 50;
            dgvDados.Columns[6].HeaderText = "Data da Criação";
            dgvDados.Columns[6].Width = 80;
            dgvDados.Columns[7].Visible = false;
            dgvDados.Columns[8].Visible = false;
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
