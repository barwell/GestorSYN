using DAL;
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
    public partial class frmConfiguracaoBDados : Form
    {
        public frmConfiguracaoBDados()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            
            btCancelar.ImageIndex = 3;
            this.Close();
            btCancelar.ImageIndex = 2;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            btSalvar.ImageIndex = 1;

            if (txtPastaBackup.Text != "")
            {


                try
                {

                    //Testando a Conexao com o banco de dados
                    DadosDaConexao.servidor = txtServidor.Text;
                    DadosDaConexao.banco = txtBanco.Text;
                    DadosDaConexao.usuario = txtUsuario.Text;
                    DadosDaConexao.senha = txtSenha.Text;
                    DadosDaConexao.pasta_backup = txtPastaBackup.Text;
                    SqlConnection conexao = new SqlConnection();
                    conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                    conexao.Open();
                    conexao.Close();
                    MessageBox.Show("Teste de Conexão OK!");

                    //Gravando o Arquivo
                    StreamWriter arquivo = new StreamWriter("ConfiguracaoBanco.txt", false);
                    arquivo.WriteLine(txtServidor.Text);
                    arquivo.WriteLine(txtBanco.Text);
                    arquivo.WriteLine(txtUsuario.Text);
                    arquivo.WriteLine(txtSenha.Text);
                    arquivo.WriteLine(txtPastaBackup.Text);
                    arquivo.Close();
                    MessageBox.Show("Arquivo atualizado!");

                    this.Close();
                }
                catch (SqlException errob)
                {
                    MessageBox.Show("Erro no teste de conexão," +
                        "não foi possível conectar com o banco de dados," +
                        "verifique os dados informados!" + errob.Message);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma pasta para fazer backup!");
            }

            btSalvar.ImageIndex = 0;
        }

        private void frmConfiguracaoBDados_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                txtServidor.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                txtPastaBackup.Text = arquivo.ReadLine();
                arquivo.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            btProcurar.ImageIndex = 5;

            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "Backup Files|";
            d.ShowDialog();
            if (d.FileName != "")
            {
                txtPastaBackup.Text = d.FileName;
            }
            else
            {
                MessageBox.Show("Local ou nome inválido!");
            }
            btProcurar.ImageIndex = 4;
        }
    }
}
