using DAL;
using DLL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCCadastroSubCategoria : GUI.UCModDeFormCadastro
    {
        private int closeCadSubCategoria = 1;

        private static UCCadastroSubCategoria _instancia;

        public static UCCadastroSubCategoria Instancia
        {
            get
            {
                if (_instancia == null) { _instancia = new UCCadastroSubCategoria(); }

                return _instancia;
            }
        }


        public UCCadastroSubCategoria()
        {
            InitializeComponent();
        }

        //Cria o evento de fechamento
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
        }

        //Evento que verifica se o User Control pode ser fechado
        void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeCadSubCategoria != 1)
            {
                if (MessageBox.Show("Um Cadastro de Categoria está sendo editado! Deseja cancelar esse cadastro em operação?", "Cancelar operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    UCCadastroSubCategoria.Instancia.BringToFront();
                }
            }
        }


        public void LimpaTela()
        {
            txtSCatCod.Clear();
            txtNome.Clear();
            txtSCatData.Clear();
        }

        private void UCCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            DLLCategoria dll = new DLLCategoria(cx);
            cbCatCod.DataSource = dll.Localizar("");
            cbCatCod.DisplayMember = "cat_nome";
            cbCatCod.ValueMember = "cat_cod";
        }

        private void btInserir_Click(object sender, EventArgs e)
        {

            //Alterna imagens dos botões
            btInserir.ImageIndex = 1;

            this.alteraBotoes(2);
            closeCadSubCategoria = 2;
            this.operacao = "inserir";
            txtSCatData.Text = DateTime.Now.ToShortDateString();

            
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btLocalizar.ImageIndex = 3;

            frmConsultaSubCategoria frmSubCCateg = new frmConsultaSubCategoria();
            frmSubCCateg.ShowDialog();
            if (frmSubCCateg.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLSubCategoria dll = new DLLSubCategoria(cx);
                ModeloSubCategoria modelo = dll.CarregaModeloSubCategoria(frmSubCCateg.codigo);
                txtSCatCod.Text = modelo.ScatCod.ToString();
                txtNome.Text = modelo.ScatNome;
                txtSCatData.Text = modelo.ScatData;
                cbCatCod.SelectedValue = Convert.ToString(modelo.CatCod);
                label1.Visible = true;
                this.alteraBotoes(3);
                closeCadSubCategoria = 3;

            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
                btLocalizar.ImageIndex = 2;
            }
            frmSubCCateg.Dispose();

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btAlterar.ImageIndex = 5;

            this.operacao = "alterar";
            this.alteraBotoes(2);
            closeCadSubCategoria = 2;
            txtSCatData.Text = DateTime.Now.ToShortDateString();

            btAlterar.ImageIndex = 4;

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btExcluir.ImageIndex = 7;

            //o try é para tratamento de erros ao inserir objeto
            try
            {

                DialogResult d = MessageBox.Show("Tem certeza que deseja excluir o registro?", "Excluir?", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    //MessageBox.Show("Excluindo o registro!");
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    DLLSubCategoria dll = new DLLSubCategoria(cx);
                    dll.Excluir(Convert.ToInt32(txtSCatCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    closeCadSubCategoria = 1;
                }
                else
                {
                    MessageBox.Show("Erro no valor passado!" + d.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.");
                this.alteraBotoes(3);
                closeCadSubCategoria = 3;
                //FormPrincipal.toolStripBarStatus.Text = "ERRO! Impossível excluir o registro.";
            }
            btExcluir.ImageIndex = 6;
            btLocalizar.ImageIndex = 2;
            this.operacao = "";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            
            btSalvar.ImageIndex = 9;

            //o try é para tratamento de erros ao inserir objeto
            try
            {

                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.CatCod = Convert.ToInt32(cbCatCod.SelectedValue); 
                modelo.ScatNome = txtNome.Text;
                modelo.ScatData = DateTime.Now.ToShortDateString();
                modelo.ScatTime = DateTime.Now.ToShortTimeString();
                modelo.ScatStatus = "local";

                //Obj para gravar os dados da conexão
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLSubCategoria dll = new DLLSubCategoria(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar nova categoria
                    dll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Código " + modelo.ScatCod.ToString());
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + modelo.CatCod.ToString() + " cadastrado!";
                }
                else
                {
                    //Alterar Categoria
                    modelo.ScatCod = Convert.ToInt32(txtSCatCod.Text);
                    dll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado!");
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + txtcodigo.Text + " alterado!";
                    label1.Visible = false;
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                closeCadSubCategoria = 1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //toolStripBarStatus.Text = "Erro! Cadastro não realizado!";
            }

            //Retorna parâmetros originais
            btSalvar.ImageIndex = 8;
            btInserir.ImageIndex = 0;
            btLocalizar.ImageIndex = 2;
            this.operacao = "";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btCancelar.ImageIndex = 11;

            if (MessageBox.Show("Tem certeza que deseja cancelar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Limpo os campos, retornando o estado original
                this.LimpaTela();
                //Habilito botões
                this.alteraBotoes(1);
                closeCadSubCategoria = 1;
                //Esconde a palavra código
                label1.Visible = false;

                this.operacao = "";
            }

            btCancelar.ImageIndex = 10;
            btInserir.ImageIndex = 0;
            btLocalizar.ImageIndex = 2;
        }
        
    }
}
