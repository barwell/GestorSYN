/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 03/01/2016
 *Data da Ultima Revisão: 
 *
 * Descrição: UC utilizada para controle do cadastro dos tipos de cobrança
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
    public partial class UCCadastroTipoCobranca : GUI.UCModDeFormCadastro
    {
        private int closeCadTipoCobranca = 1;

        private static UCCadastroTipoCobranca _instancia;

        public static UCCadastroTipoCobranca Instancia
        {
            get
            {
                if (_instancia == null) { _instancia = new UCCadastroTipoCobranca(); }

                return _instancia;
            }
        }

        public UCCadastroTipoCobranca()
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
            if (closeCadTipoCobranca != 1)
            {
                if (MessageBox.Show("Um Cadastro do Tipo de Cobrança está sendo editado! Deseja cancelar esse cadastro em operação?", "Cancelar operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    UCCadastroUndMedida.Instancia.BringToFront();
                }
            }
        }


        public void LimpaTela()
        {
            txtTipoCobCod.Clear();
            txtTipoCobNome.Clear();
            txtTipoCobData.Clear();
        }


        private void btInserir_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btInserir.ImageIndex = 1;

            this.operacao = "inserir";
            this.alteraBotoes(2);
            closeCadTipoCobranca = 2;
            txtTipoCobData.Text = DateTime.Now.ToShortDateString();

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btLocalizar.ImageIndex = 3;

            frmConsultaTipoCobranca frmTipoCob = new frmConsultaTipoCobranca();
            frmTipoCob.ShowDialog();
            if (frmTipoCob.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLTipoCobranca dll = new DLLTipoCobranca(cx);
                ModeloTipoCobranca modelo = dll.CarregaModeloTipoCobranca(frmTipoCob.codigo);
                txtTipoCobCod.Text = modelo.TipoCobCod.ToString();
                txtTipoCobNome.Text = modelo.TipoCobNome;
                txtTipoCobData.Text = modelo.TipoCobData;
                label1.Visible = true;
                this.alteraBotoes(3);
                closeCadTipoCobranca = 3;

            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
                closeCadTipoCobranca = 1;
                btLocalizar.ImageIndex = 2;
            }
            frmTipoCob.Dispose();
            
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btAlterar.ImageIndex = 5;


            this.operacao = "alterar";
            this.alteraBotoes(2);
            closeCadTipoCobranca = 2;
            txtTipoCobData.Text = DateTime.Now.ToShortDateString();
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
                    DLLTipoCobranca dll = new DLLTipoCobranca(cx);
                    dll.Excluir(Convert.ToInt32(txtTipoCobCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    closeCadTipoCobranca = 1;
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
                closeCadTipoCobranca = 3;
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

                ModeloTipoCobranca modelo = new ModeloTipoCobranca();
                modelo.TipoCobNome = txtTipoCobNome.Text;
                modelo.TipoCobData = DateTime.Now.ToShortDateString();
                modelo.TipoCobTime = DateTime.Now.ToShortTimeString();
                modelo.TipoCobStatus = "local";

                //Obj para gravar os dados da conexão
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLTipoCobranca dll = new DLLTipoCobranca(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar nova categoria
                    dll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Código " + modelo.TipoCobCod.ToString());
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + modelo.CatCod.ToString() + " cadastrado!";
                }
                else
                {
                    //Alterar Unidade de medida
                    modelo.TipoCobCod = Convert.ToInt32(txtTipoCobCod.Text);
                    dll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado!");
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + txtcodigo.Text + " alterado!";
                    label1.Visible = false;
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                closeCadTipoCobranca = 1;
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
                closeCadTipoCobranca = 1;
                //Esconde a palavra código
                label1.Visible = false;
            }

            btCancelar.ImageIndex = 10;
            btInserir.ImageIndex = 0;
            btLocalizar.ImageIndex = 2;
        }

        private void UCCadastroTipoCobranca_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void txtTipoCobNome_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                int r = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLTipoCobranca dll = new DLLTipoCobranca(cx);
                r = dll.VerificaTipoCobranca(txtTipoCobNome.Text);
                if (r > 0)
                {
                    DialogResult d = MessageBox.Show("Já existe um registro com este valor, deseja alterar o registro?", "Modificar?", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloTipoCobranca modelo = dll.CarregaModeloTipoCobranca(r);
                        txtTipoCobCod.Text = modelo.TipoCobCod.ToString();
                        txtTipoCobNome.Text = modelo.TipoCobNome;
                        txtTipoCobData.Text = modelo.TipoCobData;
                        label1.Visible = true;
                        //this.alteraBotoes(3);
                        closeCadTipoCobranca = 3;

                    }
                }
            }
        }
    }
}
