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
    public partial class UCCadastroUFEstado : GUI.UCModDeFormCadastro
    {
        private int closeCadEstado = 1;

        private static UCCadastroUFEstado _instancia;

        public static UCCadastroUFEstado Instancia
        {
            get
            {
                if (_instancia == null) { _instancia = new UCCadastroUFEstado(); }

                return _instancia;
            }
        }

        public UCCadastroUFEstado()
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
            if (closeCadEstado != 1)
            {
                if (MessageBox.Show("Um Cadastro de Estado está sendo editado! Deseja cancelar esse cadastro em operação?", "Cancelar operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    UCCadastroUFEstado.Instancia.BringToFront();
                }
            }
        }


        public void LimpaTela()
        {
            txtEstadoCod.Clear();
            txtEstadoNome.Clear();
            txtEstadoData.Clear();
            txtEstadoCodFed.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btInserir.ImageIndex = 1;

            this.alteraBotoes(2);
            closeCadEstado = 2;
            this.operacao = "inserir";
            txtEstadoData.Text = DateTime.Now.ToShortDateString();

        }

        private void UCCadastroUFEstado_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            DLLPais dll = new DLLPais(cx);
            cbEstadoPaisCod.DataSource = dll.Localizar("");
            cbEstadoPaisCod.DisplayMember = "pais_nome";
            cbEstadoPaisCod.ValueMember = "pais_cod";
            cbEstadoPaisCod.SelectedItem = dll.Localizar("Brasil");

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btLocalizar.ImageIndex = 3;

            frmConsultaEstado frmCEstado = new frmConsultaEstado();
            frmCEstado.ShowDialog();
            if (frmCEstado.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLEstado dll = new DLLEstado(cx);
                ModeloEstado modelo = dll.CarregaModeloEstado(frmCEstado.codigo);
                txtEstadoCod.Text = modelo.EstadoCod.ToString();
                txtEstadoNome.Text = modelo.EstadoNome;
                txtEstadoData.Text = modelo.EstadoData;
                txtEstadoCodFed.Text = modelo.EstadoCodFed.ToString();
                cbEstadoPaisCod.SelectedValue = Convert.ToString(modelo.EstadoPaisCod);
                label1.Visible = true;
                this.alteraBotoes(3);
                closeCadEstado = 3;

            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
                btLocalizar.ImageIndex = 2;
            }
            frmCEstado.Dispose();

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btAlterar.ImageIndex = 5;

            this.operacao = "alterar";
            this.alteraBotoes(2);
            closeCadEstado = 2;
            txtEstadoData.Text = DateTime.Now.ToShortDateString();

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
                    DLLEstado dll = new DLLEstado(cx);
                    dll.Excluir(Convert.ToInt32(txtEstadoCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    closeCadEstado = 1;
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
                closeCadEstado = 3;
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

                ModeloEstado modelo = new ModeloEstado();
                modelo.EstadoPaisCod = Convert.ToInt32(cbEstadoPaisCod.SelectedValue);
                modelo.EstadoNome = txtEstadoNome.Text;
                modelo.EstadoCodFed = Convert.ToInt32(txtEstadoCodFed.Text);
                modelo.EstadoData = DateTime.Now.ToShortDateString();
                modelo.EstadoTime = DateTime.Now.ToShortTimeString();
                modelo.EstadoStatus = "local";

                //Obj para gravar os dados da conexão
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLEstado dll = new DLLEstado(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar nova categoria
                    dll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Código " + modelo.EstadoCod.ToString());
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + modelo.CatCod.ToString() + " cadastrado!";
                }
                else
                {
                    //Alterar Categoria
                    modelo.EstadoCod = Convert.ToInt32(txtEstadoCod.Text);
                    dll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado!");
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + txtcodigo.Text + " alterado!";
                    label1.Visible = false;
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                closeCadEstado = 1;
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
                closeCadEstado = 1;
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
