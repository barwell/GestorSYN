/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 16/12/2015
 *Data da Ultima Revisão: 16/12/2015
 *
 * Descrição: UC utilizada para controle do cadastro das unidades de medidas
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
    public partial class UCCadastroUndMedida : GUI.UCModDeFormCadastro
    {
        private int closeCadUndMedida = 1;

        private static UCCadastroUndMedida _instancia;

        public static UCCadastroUndMedida Instancia
        {
            get
            {
                if (_instancia == null) { _instancia = new UCCadastroUndMedida(); }

                return _instancia;
            }
        }

        public UCCadastroUndMedida()
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
            if (closeCadUndMedida != 1)
            {
                if (MessageBox.Show("Um Cadastro da Unidade de Medida está sendo editado! Deseja cancelar esse cadastro em operação?", "Cancelar operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    UCCadastroUndMedida.Instancia.BringToFront();
                }
            }
        }


        public void LimpaTela()
        {
            txtUmedCod.Clear();
            txtUmedNome.Clear();
            txtUmedData.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btInserir.ImageIndex = 1;

            this.operacao = "inserir";
            this.alteraBotoes(2);
            closeCadUndMedida = 2;
            txtUmedData.Text = DateTime.Now.ToShortDateString();

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btLocalizar.ImageIndex = 3;

            frmConsultaUndMedida frmUmed = new frmConsultaUndMedida();
            frmUmed.ShowDialog();
            if (frmUmed.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLUndMedida dll = new DLLUndMedida(cx);
                ModeloUndMedida modelo = dll.CarregaModeloUndMedida(frmUmed.codigo);
                txtUmedCod.Text = modelo.UmedCod.ToString();
                txtUmedNome.Text = modelo.UmedNome;
                txtUmedData.Text = modelo.UmedData;
                label1.Visible = true;
                this.alteraBotoes(3);
                closeCadUndMedida = 3;

            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
                closeCadUndMedida = 1;
                btLocalizar.ImageIndex = 2;
            }
            frmUmed.Dispose();
            

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btAlterar.ImageIndex = 5;


            this.operacao = "alterar";
            this.alteraBotoes(2);
            closeCadUndMedida = 2;
            txtUmedData.Text = DateTime.Now.ToShortDateString();
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
                    DLLUndMedida dll = new DLLUndMedida(cx);
                    dll.Excluir(Convert.ToInt32(txtUmedCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    closeCadUndMedida = 1;
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
                closeCadUndMedida = 3;
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

                ModeloUndMedida modelo = new ModeloUndMedida();
                modelo.UmedNome = txtUmedNome.Text;
                modelo.UmedData = DateTime.Now.ToShortDateString();
                modelo.UmedTime = DateTime.Now.ToShortTimeString();
                modelo.UmedStatus = "local";

                //Obj para gravar os dados da conexão
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLUndMedida dll = new DLLUndMedida(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar nova categoria
                    dll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Código " + modelo.UmedCod.ToString());
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + modelo.CatCod.ToString() + " cadastrado!";
                }
                else
                {
                    //Alterar Unidade de medida
                    modelo.UmedCod = Convert.ToInt32(txtUmedCod.Text);
                    dll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado!");
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + txtcodigo.Text + " alterado!";
                    label1.Visible = false;
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                closeCadUndMedida = 1;
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
                closeCadUndMedida = 1;
                //Esconde a palavra código
                label1.Visible = false;
            }

            btCancelar.ImageIndex = 10;
            btInserir.ImageIndex = 0;
            btLocalizar.ImageIndex = 2;
        }

        private void UCCadastroUndMedida_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void txtUmedNome_Leave(object sender, EventArgs e)
        {
            if(this.operacao == "inserir")
            {
                int r = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLUndMedida dll = new DLLUndMedida(cx);
                r = dll.VerificaUndMedida(txtUmedNome.Text);
                if(r > 0)
                {
                    DialogResult d = MessageBox.Show("Já existe um registro com este valor, deseja alterar o registro?", "Modificar?", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloUndMedida modelo = dll.CarregaModeloUndMedida(r);
                        txtUmedCod.Text = modelo.UmedCod.ToString();
                        txtUmedNome.Text = modelo.UmedNome;
                        txtUmedData.Text = modelo.UmedData;
                        label1.Visible = true;
                        //this.alteraBotoes(3);
                        closeCadUndMedida = 3;

                    }
                }
            }
        }

    }
}
