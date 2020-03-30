/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 31/12/2015
 *Data da Ultima Revisão: 
 *
 * Descrição: UC utilizada para controle do cadastro dos Planos de Contas
 * 
 * 
 * Modificações da Revisão: Nenhuma
 */



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
    public partial class UCCadastroPlanoContas : GUI.UCModDeFormCadastro
    {
        //variável de verificação do evento close
        private int closeCadPlanoContas = 1;

        private static UCCadastroPlanoContas _instancia;

        public static UCCadastroPlanoContas Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new UCCadastroPlanoContas();

                return _instancia;
            }
        }


        public UCCadastroPlanoContas()
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
            if (closeCadPlanoContas != 1)
            {
                if (MessageBox.Show("Um Cadastro do Plano de Contas está sendo editado! Deseja cancelar esse cadastro em operação?", "Cancelar operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    UCCadastroPlanoContas.Instancia.BringToFront();
                }
            }
        }


        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtPContaData.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            //Altera imagem do botão
            btInserir.ImageIndex = 1;
            //Determina o tipo como deve ser salvo a edição ao clicar no botão salvar
            this.operacao = "inserir";
            //Habilita botões
            this.alteraBotoes(2);
            //Determina se o User Control pode ser fechado
            closeCadPlanoContas = 2;
            //Insere a data que será realizado o cadastro
            txtPContaData.Text = DateTime.Now.ToShortDateString();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btLocalizar.ImageIndex = 3;

            //Abre o cadastro do item retornado nos campos 
            frmConsultaPlanoContas frmCPContas = new frmConsultaPlanoContas();
            frmCPContas.ShowDialog();
            if (frmCPContas.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLPlanoContas dll = new DLLPlanoContas(cx);
                ModeloPlanoContas modelo = dll.CarregaModeloPlanoContas(frmCPContas.codigo);
                txtCodigo.Text = modelo.PlanContaCod.ToString();
                txtNome.Text = modelo.PlanContaNome;
                txtPContaData.Text = modelo.PlanContaData;
                label1.Visible = true;
                this.alteraBotoes(3);

            }
            else
            {
                //Limpa os campos
                this.LimpaTela();
                //Altera os botões
                this.alteraBotoes(1);
                //Altera se o controle pode ser fechado
                closeCadPlanoContas= 1;
                //Altera Imagem do botão
                btLocalizar.ImageIndex = 2;
            }
            frmCPContas.Dispose();
            

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btAlterar.ImageIndex = 5;
            //Altera a forma como deve ser salvo os dados ao clicar no botão close
            this.operacao = "alterar";
            //Habilita os botões
            this.alteraBotoes(2);
            //Habilita o fechamento do User Control
            closeCadPlanoContas = 2;
            //Insere a data atual para o novo cadastro
            txtPContaData.Text = DateTime.Now.ToShortDateString();
            //Altera a imagem do botão 
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
                    //Exclui o registro
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    DLLPlanoContas dll = new DLLPlanoContas(cx);
                    dll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    //Limpa os campos
                    this.LimpaTela();
                    //Habilita os botões
                    this.alteraBotoes(1);
                    //Habilita o fechamento do User Control
                    closeCadPlanoContas = 1;
                }
                else
                {
                    MessageBox.Show("Erro no valor passado!" + d.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.");
                //Habilita botões
                this.alteraBotoes(3);
                //Habilita o fechamento do User Control
                closeCadPlanoContas = 3;

                //FormPrincipal.toolStripBarStatus.Text = "ERRO! Impossível excluir o registro.";
            }
            //Altera imagens dos botões
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

                ModeloPlanoContas modelo = new ModeloPlanoContas();
                modelo.PlanContaNome = txtNome.Text;
                modelo.PlanContaData = DateTime.Now.ToShortDateString();
                modelo.PlanContaTime = DateTime.Now.ToShortTimeString();
                modelo.PlanContaStatus = "local";

                //Obj para gravar os dados da conexão
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLPlanoContas dll = new DLLPlanoContas(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar nova Plano de Contas
                    dll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Código " + modelo.PlanContaCod.ToString());
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + modelo.PlanContaCod.ToString() + " cadastrado!";
                }
                else
                {
                    //Alterar Plano de Contas
                    modelo.PlanContaCod = Convert.ToInt32(txtCodigo.Text);
                    dll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado!");
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + txtcodigo.Text + " alterado!";
                    label1.Visible = false;
                }
                //Limpa os campos do formulário
                this.LimpaTela();
                //Habilita botões
                this.alteraBotoes(1);
                //Habilita o fechamento da janela
                closeCadPlanoContas = 0;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //toolStripBarStatus.Text = "Erro! Cadastro não realizado!";
            }
            //Altera imagens dos botões
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
                //Habilita fechamento da janela
                closeCadPlanoContas = 1;
                //Esconde a palavra código
                label1.Visible = false;
            }

            btCancelar.ImageIndex = 10;
            btInserir.ImageIndex = 0;
            btLocalizar.ImageIndex = 2;
            
        }

        private void UCCadastroPlanoContas_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

    }
}
