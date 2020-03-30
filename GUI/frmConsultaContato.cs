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
    public partial class frmConsultaContato : Form
    {
        public int codigo = 0;

        public frmConsultaContato()
        {
            InitializeComponent();
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            btBusca.ImageIndex = 1;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            DLLContato dll = new DLLContato(cx);
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

        private void frmConsultaContato_Load(object sender, EventArgs e)
        {
            btBusca_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 30;
            dgvDados.Columns[1].HeaderText = "Contato";
            dgvDados.Columns[1].Width = 50;
            dgvDados.Columns[2].HeaderText = "email";
            dgvDados.Columns[2].Width = 50;
            dgvDados.Columns[3].HeaderText = "Telefone";
            dgvDados.Columns[3].Width = 20;
            dgvDados.Columns[4].HeaderText = "Celular 1";
            dgvDados.Columns[4].Width = 20;
            dgvDados.Columns[5].HeaderText = "Operadora 1";
            dgvDados.Columns[5].Width = 20;
            dgvDados.Columns[6].HeaderText = "Celular 2";
            dgvDados.Columns[6].Width = 20;
            dgvDados.Columns[7].HeaderText = "Operadora 2";
            dgvDados.Columns[7].Width = 20;
            dgvDados.Columns[8].HeaderText = "Endereço";
            dgvDados.Columns[8].Width = 120;
            dgvDados.Columns[9].HeaderText = "Cidade";
            dgvDados.Columns[9].Width = 80;
            dgvDados.Columns[10].HeaderText = "Estado";
            dgvDados.Columns[10].Width = 50;
            dgvDados.Columns[11].HeaderText = "Pais";
            dgvDados.Columns[11].Width = 50;
            dgvDados.Columns[12].HeaderText = "Data do Cadastro";
            dgvDados.Columns[12].Width = 50;
            dgvDados.Columns[13].HeaderText = "Fornecedor";
            dgvDados.Columns[13].Width = 100;
            dgvDados.Columns[14].HeaderText = "Cliente";
            dgvDados.Columns[14].Width = 100;
            dgvDados.Columns[15].Visible = false;
            dgvDados.Columns[16].Visible = false;
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
