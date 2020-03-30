/*
 * WS Elétrica do Brasil
 *Projeto: GestorSYN
 *Criado por: Wendell Barbosa Silva 
 *
 * Versão:1
 *Data da Criação: 16/12/2015
 *Data da Ultima Revisão: 16/12/2015
 *
 * Descrição: UC utilizada para controle do cadastro das Categorias
 * 
 * 
 * Modificações da Revisão: Nenhuma
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using DAL;
using DLL;

namespace GUI
{
    public partial class UCCadastroCategoria : GUI.UCModDeFormCadastro
    {
        //variável de verificação do evento close
        private int closeCadCategoria = 1;

        private static UCCadastroCategoria _instancia;

        public static UCCadastroCategoria Instancia
        {
            get
            {
                if (_instancia == null)  
                    _instancia = new UCCadastroCategoria();
       
                return _instancia;
            }
        }

        public UCCadastroCategoria()
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
            if (closeCadCategoria != 1)
            {
                if (MessageBox.Show("Um Cadastro de Categoria está sendo editado! Deseja cancelar esse cadastro em operação?", "Cancelar operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    UCCadastroCategoria.Instancia.BringToFront();
                }
            }
        }

        
        public void LimpaTela()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtcatdata.Clear();
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
                closeCadCategoria = 2;
                //Insere a data que será realizado o cadastro
                txtcatdata.Text = DateTime.Now.ToShortDateString();
                 
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

            //Alterna imagens dos botões
            btLocalizar.ImageIndex = 3;
            
            //Abre o cadastro do item retornado nos campos 
            frmConsultaCategoria frmCCateg = new frmConsultaCategoria();
            frmCCateg.ShowDialog();
            if(frmCCateg.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLCategoria dll = new DLLCategoria(cx);
                ModeloCategoria modelo = dll.CarregaModeloCategoria(frmCCateg.codigo);
                txtcodigo.Text = modelo.CatCod.ToString();
                txtnome.Text = modelo.CatNome;
                txtcatdata.Text = modelo.CatData;
                txtcodigo.Text = Convert.ToString(modelo.CatCod);
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
                closeCadCategoria = 1;
                //Altera Imagem do botão
                btLocalizar.ImageIndex = 2;
            }
            frmCCateg.Dispose();
            

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
            closeCadCategoria = 2;
            //Insere a data atual para o novo cadastro
            txtcatdata.Text = DateTime.Now.ToShortDateString();
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
                if(d.ToString() == "Yes")
                {
                    //MessageBox.Show("Excluindo o registro!");
                    //Exclui o registro
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    DLLCategoria dll = new DLLCategoria(cx);
                    dll.Excluir(Convert.ToInt32(txtcodigo.Text));
                    //Limpa os campos
                    this.LimpaTela();
                    //Habilita os botões
                    this.alteraBotoes(1);
                    //Habilita o fechamento do User Control
                    closeCadCategoria = 1;
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
                closeCadCategoria = 3;

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

                ModeloCategoria modelo = new ModeloCategoria();
                modelo.CatNome = txtnome.Text;
                modelo.CatData = DateTime.Now.ToShortDateString();
                modelo.CatTime = DateTime.Now.ToShortTimeString();
                modelo.CatStatus = "local";

                //Obj para gravar os dados da conexão
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLCategoria dll = new DLLCategoria(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar nova categoria
                    dll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Código " + modelo.CatCod.ToString());
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + modelo.CatCod.ToString() + " cadastrado!";
                }
                else
                {
                    //Alterar Categoria
                    modelo.CatCod = Convert.ToInt32(txtcodigo.Text);
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
                closeCadCategoria = 0;
            }
            catch(Exception erro)
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
                closeCadCategoria = 1;
                //Esconde a palavra código
                label1.Visible = false;
            }

            btCancelar.ImageIndex = 10;
            btInserir.ImageIndex = 0;
            btLocalizar.ImageIndex = 2;
            
        }

        private void UCCadastroCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }
       
        

    }
}
