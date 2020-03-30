using DAL;
using FerramentasDeProjeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{

    public partial class FormPrincipal : Form
    {
        

        public FormPrincipal()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Determinando a data e a hora nas Labels da Status Bar
            toolStripStatusLabelData.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabelHora.Text = DateTime.Now.ToShortTimeString();

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!panelCadastro.Controls.Contains(UCCadastroCategoria.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroCategoria.Instancia);
                UCCadastroCategoria.Instancia.Dock = DockStyle.None;
                UCCadastroCategoria.Instancia.BringToFront();

            }
            else
            {
                UCCadastroCategoria.Instancia.BringToFront();
            }
               

        }

       /* void UCCadastroCategoria_OnClose(bool Status)
        {
            if (Status)
            {
                panelCadastro.Controls.Remove(UCCadastroCategoria.Instancia); // removendo User Control
            }
        }*/

        private void subCategoriaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelCadastro.Controls.Contains(UCCadastroSubCategoria.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroSubCategoria.Instancia);
                UCCadastroSubCategoria.Instancia.Dock = DockStyle.None;
                UCCadastroSubCategoria.Instancia.BringToFront();

            }
            else
            {
                UCCadastroSubCategoria.Instancia.BringToFront();
            }
        }



        private void cadastroTab_Click(object sender, EventArgs e)
        {

            toolStripBarStatus.Text = "Cadastrar novos itens?";

        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelCadastro.Controls.Contains(UCCadastroUndMedida.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroUndMedida.Instancia);
                UCCadastroUndMedida.Instancia.Dock = DockStyle.None;
                UCCadastroUndMedida.Instancia.BringToFront();

            }
            else
            {
                UCCadastroUndMedida.Instancia.BringToFront();
            }        

        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!panelCadastro.Controls.Contains(UCCadastroUFPais.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroUFPais.Instancia);
                UCCadastroUFPais.Instancia.Dock = DockStyle.None;
                UCCadastroUFPais.Instancia.BringToFront();

            }
            else
            {
                UCCadastroUFPais.Instancia.BringToFront();
            }

                                
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelCadastro.Controls.Contains(UCCadastroUFPais.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroFerramentas.Instancia);
                UCCadastroFerramentas.Instancia.Dock = DockStyle.None;
                UCCadastroFerramentas.Instancia.BringToFront();

            }
            else
            {
                UCCadastroFerramentas.Instancia.BringToFront();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //Verifica conexao com o banco de dados
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDaConexao.servidor = arquivo.ReadLine();
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();
                //testa a conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();

             }
            catch (SqlException errob)
            {
                MessageBox.Show("Erro ao tentar conectar com o Banco de dados,"+
                "acesse as configurações do banco de dados e atualize as informações! "+ errob.Message);
                frmConfiguracaoBDados f = new frmConfiguracaoBDados();
                f.ShowDialog();
                f.Dispose();
            }
             catch (Exception erro)
             {
                 MessageBox.Show(erro.Message);
             }
        }

        private void toolStripBtAtividades_Click(object sender, EventArgs e)
        {
            if (!panelCadastro.Controls.Contains(UCCadastroAtividades.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroAtividades.Instancia);
                UCCadastroAtividades.Instancia.Dock = DockStyle.None;
                UCCadastroAtividades.Instancia.BringToFront();

            }
            else
            {
                UCCadastroAtividades.Instancia.BringToFront();
            }

        }

        private void planoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelCadastro.Controls.Contains(UCCadastroPlanoContas.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroPlanoContas.Instancia);
                UCCadastroPlanoContas.Instancia.Dock = DockStyle.None;
                UCCadastroPlanoContas.Instancia.BringToFront();

            }
            else
            {
                UCCadastroPlanoContas.Instancia.BringToFront();
            }
        }

        private void tipoDeCobrançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelCadastro.Controls.Contains(UCCadastroTipoCobranca.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroTipoCobranca.Instancia);
                UCCadastroTipoCobranca.Instancia.Dock = DockStyle.None;
                UCCadastroTipoCobranca.Instancia.BringToFront();

            }
            else
            {
                UCCadastroTipoCobranca.Instancia.BringToFront();
            }
        }

        private void centroDeCustosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelCadastro.Controls.Contains(UCCadastroCentroCustos.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroCentroCustos.Instancia);
                UCCadastroCentroCustos.Instancia.Dock = DockStyle.None;
                UCCadastroCentroCustos.Instancia.BringToFront();

            }
            else
            {
                UCCadastroCentroCustos.Instancia.BringToFront();
            }
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelCadastro.Controls.Contains(UCCadastroUFEstado.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroUFEstado.Instancia);
                UCCadastroUFEstado.Instancia.Dock = DockStyle.None;
                UCCadastroUFEstado.Instancia.BringToFront();

            }
            else
            {
                UCCadastroUFEstado.Instancia.BringToFront();
            }
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panelCadastro.Controls.Contains(UCCadastroUFCidade.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroUFCidade.Instancia);
                UCCadastroUFCidade.Instancia.Dock = DockStyle.None;
                UCCadastroUFCidade.Instancia.BringToFront();

            }
            else
            {
                UCCadastroUFCidade.Instancia.BringToFront();
            }
        }

        private void toolStripButtonContato_Click(object sender, EventArgs e)
        {
            if (!panelCadastro.Controls.Contains(UCCadastroContatos.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroContatos.Instancia);
                UCCadastroContatos.Instancia.Dock = DockStyle.None;
                UCCadastroContatos.Instancia.BringToFront();

            }
            else
            {
                UCCadastroContatos.Instancia.BringToFront();
            }
        }

        private void bancoDeDadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConfiguracaoBDados f = new frmConfiguracaoBDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void backupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if(DadosDaConexao.pasta_backup != "")
                {
                    String NomeBanco = DadosDaConexao.banco;
                    String localBackup = DadosDaConexao.pasta_backup + " - " + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss") + ".bak";
                    String conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User=" +
                    DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    SQLServerBackup.BackupDataBase(conexao, NomeBanco, localBackup);
                    MessageBox.Show("Backup realizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Verificar as configurações do banco de dados!"+
                        "Selecione um local para salvar o backup!");
                    frmConfiguracaoBDados f = new frmConfiguracaoBDados();
                    f.ShowDialog();
                    f.Dispose();

                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void restaurarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
             try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup Files|*.bak";
                d.ShowDialog();
                if(d.FileName != "")
                {
                    String NomeBanco = DadosDaConexao.banco;
                    String localBackup = d.FileName ;
                    String conexao = @"Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master;User=" +
                    DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    SQLServerBackup.BackupDataBase(conexao, NomeBanco, localBackup);
                    MessageBox.Show("Backup restaurado com sucesso!");
                }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

        private void toolStripButtonProduto_Click(object sender, EventArgs e)
        {
            if (!panelCadastro.Controls.Contains(UCCadastroProduto.Instancia))
            {
                panelCadastro.Controls.Add(UCCadastroProduto.Instancia);
                UCCadastroProduto.Instancia.Dock = DockStyle.None;
                UCCadastroProduto.Instancia.BringToFront();

            }
            else
            {
                UCCadastroProduto.Instancia.BringToFront();
            }
        }
      

    }
}
