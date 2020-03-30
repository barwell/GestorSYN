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
    public partial class UCCadastroUFPais : GUI.UCModDeFormCadastro
    {
        private int closeCadUFPais = 1;

        private static UCCadastroUFPais _instancia;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        public static UCCadastroUFPais Instancia
        {
            get
            {
                if (_instancia == null) { _instancia = new UCCadastroUFPais(); }

                return _instancia;
            }
        }


        public UCCadastroUFPais()
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
            if (closeCadUFPais != 1)
            {
                if (MessageBox.Show("Um Cadastro de País está sendo editado! Deseja cancelar esse cadastro em operação?", "Cancelar operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    UCCadastroUFPais.Instancia.BringToFront();
                }
            }
        }

        public void LimpaTela()
        {
            txtpaiscodigo.Clear();
            txtnome.Clear();
            txtpaisdata.Clear();
        }


        private void btInserir_Click(object sender, EventArgs e)
        {
            btInserir.ImageIndex = 1;

            this.operacao = "inserir";
            this.alteraBotoes(2);
            closeCadUFPais = 2;
            txtpaisdata.Text = DateTime.Now.ToShortDateString();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btLocalizar.ImageIndex = 3;

            frmConsultaPais frmCPais = new frmConsultaPais();
            frmCPais.ShowDialog();
            if (frmCPais.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLPais dll = new DLLPais(cx);
                ModeloPais modelo = dll.CarregaModeloPais(frmCPais.codigo);
                txtpaiscodigo.Text = modelo.PaisCod.ToString();
                txtnome.Text = modelo.PaisNome;
                txtpaisdata.Text = modelo.PaisData;
                txtpaiscodigo.Text = Convert.ToString(modelo.PaisCod);
                label1.Visible = true;
                this.alteraBotoes(3);
                closeCadUFPais = 3;

            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
                closeCadUFPais = 1;
                btLocalizar.ImageIndex = 2;
            }
            frmCPais.Dispose();
            
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btAlterar.ImageIndex = 5;


            this.operacao = "alterar";
            this.alteraBotoes(2);
            closeCadUFPais = 2;
            txtpaisdata.Text = DateTime.Now.ToShortDateString();
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
                    DLLPais dll = new DLLPais(cx);
                    dll.Excluir(Convert.ToInt32(txtpaiscodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    closeCadUFPais = 1;
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
                closeCadUFPais = 3;
                //FormPrincipal.toolStripBarStatus.Text = "ERRO! Impossível excluir o registro.";
            }
            btExcluir.ImageIndex = 6;
            btLocalizar.ImageIndex = 2;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btSalvar.ImageIndex = 9;

            //o try é para tratamento de erros ao inserir objeto
            try
            {

                ModeloPais modelo = new ModeloPais();
                modelo.PaisNome = txtnome.Text;
                modelo.PaisData = DateTime.Now.ToShortDateString();
                modelo.PaisTime = DateTime.Now.ToShortTimeString();
                modelo.PaisStatus = "local";

                //Obj para gravar os dados da conexão
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLPais dll = new DLLPais(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar novo Pais
                    dll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Código " + modelo.PaisCod.ToString());
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + modelo.CatCod.ToString() + " cadastrado!";
                }
                else
                {
                    //Alterar Pais
                    modelo.PaisCod = Convert.ToInt32(txtpaiscodigo.Text);
                    dll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado!");
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + txtcodigo.Text + " alterado!";
                    label1.Visible = false;
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                closeCadUFPais = 1;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //toolStripBarStatus.Text = "Erro! Cadastro não realizado!";
            }
            btSalvar.ImageIndex = 8;
            btInserir.ImageIndex = 0;
            btLocalizar.ImageIndex = 2;
            
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
                closeCadUFPais = 1;
                //Esconde a palavra código
                label1.Visible = false;
            }

            btCancelar.ImageIndex = 10;
            btInserir.ImageIndex = 0;
            btLocalizar.ImageIndex = 2;
        }

        private void UCCadastroUFPais_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

    }
}
