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
    public partial class UCCadastroUFCidade : GUI.UCModDeFormCadastro
    {
        private int closeCadCidade = 1;

        private static UCCadastroUFCidade _instancia;

        public static UCCadastroUFCidade Instancia
        {
            get
            {
                if (_instancia == null) { _instancia = new UCCadastroUFCidade(); }

                return _instancia;
            }
        }
        public UCCadastroUFCidade()
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
            if (closeCadCidade != 1)
            {
                if (MessageBox.Show("Um Cadastro de Cidade está sendo editado! Deseja cancelar esse cadastro em operação?", "Cancelar operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    UCCadastroUFCidade.Instancia.BringToFront();
                }
            }
        }


        public void LimpaTela()
        {
            txtCityCod.Clear();
            txtCityNome.Clear();
            txtCityData.Clear();
            txtCityCodFed.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btInserir.ImageIndex = 1;

            this.alteraBotoes(2);
            closeCadCidade = 2;
            this.operacao = "inserir";
            txtCityData.Text = DateTime.Now.ToShortDateString();
        }

        private void UCCadastroUFCidade_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            DLLEstado dll = new DLLEstado(cx);
            cbCityEstadoCod.DataSource = dll.Localizar("");
            cbCityEstadoCod.DisplayMember = "estado_nome";
            cbCityEstadoCod.ValueMember = "estado_cod";
            cbCityEstadoCod.SelectedItem = dll.Localizar("Goiás");
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btLocalizar.ImageIndex = 3;

            frmConsultaCidade frmCCity = new frmConsultaCidade();
            frmCCity.ShowDialog();
            if (frmCCity.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLCidade dll = new DLLCidade(cx);
                ModeloCidade modelo = dll.CarregaModeloCidade(frmCCity.codigo);
                txtCityCod.Text = modelo.CityCod.ToString();
                txtCityNome.Text = modelo.CityNome;
                txtCityData.Text = modelo.CityData;
                txtCityCodFed.Text = modelo.CityCodFed.ToString();
                cbCityEstadoCod.SelectedValue = Convert.ToString(modelo.CityEstadoCod);
                label1.Visible = true;
                this.alteraBotoes(3);
                closeCadCidade = 3;

            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
                btLocalizar.ImageIndex = 2;
            }
            frmCCity.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btAlterar.ImageIndex = 5;

            this.operacao = "alterar";
            this.alteraBotoes(2);
            closeCadCidade = 2;
            txtCityData.Text = DateTime.Now.ToShortDateString();

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
                    DLLCidade dll = new DLLCidade(cx);
                    dll.Excluir(Convert.ToInt32(txtCityCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    closeCadCidade = 1;
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
                closeCadCidade = 3;
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

                ModeloCidade modelo = new ModeloCidade();
                modelo.CityEstadoCod = Convert.ToInt32(cbCityEstadoCod.SelectedValue);
                modelo.CityNome = txtCityNome.Text;
                modelo.CityCodFed = Convert.ToInt32(txtCityCodFed.Text);
                modelo.CityData = DateTime.Now.ToShortDateString();
                modelo.CityTime = DateTime.Now.ToShortTimeString();
                modelo.CityStatus = "local";

                //Obj para gravar os dados da conexão
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLCidade dll = new DLLCidade(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar nova categoria
                    dll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Código " + modelo.CityCod.ToString());
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + modelo.CityCod.ToString() + " cadastrado!";
                }
                else
                {
                    //Alterar Categoria
                    modelo.CityCod = Convert.ToInt32(txtCityCod.Text);
                    dll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado!");
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + txtCityCod.Text + " alterado!";
                    label1.Visible = false;
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                closeCadCidade = 1;
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
                closeCadCidade = 1;
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
