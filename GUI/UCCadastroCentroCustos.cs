/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 03/01/2016
 *Data da Ultima Revisão: 
 *
 * Descrição: UC utilizada para controle do cadastro dos centros de custos
 * 
 * 
 * Modificações da Revisão: Nenhuma
 */


using DAL;
using Modelo;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCCadastroCentroCustos : GUI.UCModDeFormCadastro
    {
        private int closeCadCentroCustos = 1;

        private static UCCadastroCentroCustos _instancia;

        public static UCCadastroCentroCustos Instancia
        {
            get
            {
                if (_instancia == null) { _instancia = new UCCadastroCentroCustos(); }

                return _instancia;
            }
        }

        public UCCadastroCentroCustos()
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
            if (closeCadCentroCustos != 1)
            {
                if (MessageBox.Show("Um Cadastro do Centro de Custos está sendo editado! Deseja cancelar esse cadastro em operação?", "Cancelar operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    UCCadastroCentroCustos.Instancia.BringToFront();
                }
            }
        }


        public void LimpaTela()
        {
            txtCentroCustCod.Clear();
            txtCentroCustData.Clear();
            txtCentroCustNome.Clear();
        }


        private void btInserir_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btInserir.ImageIndex = 1;

            this.operacao = "inserir";
            this.alteraBotoes(2);
            closeCadCentroCustos = 2;
            txtCentroCustData.Text = DateTime.Now.ToShortDateString();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btLocalizar.ImageIndex = 3;

            frmConsultaCentroCustos frmCentroCusto = new frmConsultaCentroCustos();
            frmCentroCusto.ShowDialog();
            if (frmCentroCusto.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLCentroCustos dll = new DLLCentroCustos(cx);
                ModeloCentroCustos modelo = dll.CarregaModeloCentroCustos(frmCentroCusto.codigo);
                txtCentroCustCod.Text = modelo.CentroCustCod.ToString();
                txtCentroCustNome.Text = modelo.CentroCustNome;
                txtCentroCustData.Text = modelo.CentroCustData;
                label1.Visible = true;
                this.alteraBotoes(3);
                closeCadCentroCustos = 3;

            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
                closeCadCentroCustos = 1;
                btLocalizar.ImageIndex = 2;
            }
            frmCentroCusto.Dispose();
            
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btAlterar.ImageIndex = 5;


            this.operacao = "alterar";
            this.alteraBotoes(2);
            closeCadCentroCustos = 2;
            txtCentroCustData.Text = DateTime.Now.ToShortDateString();
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
                    DLLCentroCustos dll = new DLLCentroCustos(cx);
                    dll.Excluir(Convert.ToInt32(txtCentroCustCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    closeCadCentroCustos = 1;
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
                closeCadCentroCustos = 3;
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

                ModeloCentroCustos modelo = new ModeloCentroCustos();
                modelo.CentroCustNome = txtCentroCustNome.Text;
                modelo.CentroCustData = DateTime.Now.ToShortDateString();
                modelo.CentroCustTime = DateTime.Now.ToShortTimeString();
                modelo.CentroCustStatus = "local";

                //Obj para gravar os dados da conexão
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLCentroCustos dll = new DLLCentroCustos(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar nova categoria
                    dll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Código " + modelo.CentroCustCod.ToString());
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + modelo.CatCod.ToString() + " cadastrado!";
                }
                else
                {
                    //Alterar Unidade de medida
                    modelo.CentroCustCod = Convert.ToInt32(txtCentroCustCod.Text);
                    dll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado!");
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + txtcodigo.Text + " alterado!";
                    label1.Visible = false;
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                closeCadCentroCustos = 1;
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
                closeCadCentroCustos = 1;
                //Esconde a palavra código
                label1.Visible = false;
            }

            btCancelar.ImageIndex = 10;
            btInserir.ImageIndex = 0;
            btLocalizar.ImageIndex = 2;
        }

        private void UCCadastroCentroCustos_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void txtCentroCustNome_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                int r = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLCentroCustos dll = new DLLCentroCustos(cx);
                r = dll.VerificaCentroCustos(txtCentroCustNome.Text);
                if (r > 0)
                {
                    DialogResult d = MessageBox.Show("Já existe um registro com este valor, deseja alterar o registro?", "Modificar?", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloCentroCustos modelo = dll.CarregaModeloCentroCustos(r);
                        txtCentroCustCod.Text = modelo.CentroCustCod.ToString();
                        txtCentroCustNome.Text = modelo.CentroCustNome;
                        txtCentroCustData.Text = modelo.CentroCustData;
                        label1.Visible = true;
                        //this.alteraBotoes(3);
                        closeCadCentroCustos = 3;

                    }
                }
            }
        }
    }
}
