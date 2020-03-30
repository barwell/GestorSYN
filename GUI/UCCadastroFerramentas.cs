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
    public partial class UCCadastroFerramentas : GUI.UCModDeFormCadastro
    {
        //variável de verificação do evento close
        private int closeCadFerramentas = 1;

        private static UCCadastroFerramentas _instancia;

        public static UCCadastroFerramentas Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new UCCadastroFerramentas();

                return _instancia;
            }
        }


        public UCCadastroFerramentas()
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
            if (closeCadFerramentas != 1)
            {
                if (MessageBox.Show("Um Cadastro de ferramentas está sendo editado! Deseja cancelar esse cadastro em operação?", "Cancelar operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    UCCadastroFerramentas.Instancia.BringToFront();
                }
            }
        }


        public void LimpaTela()
        {
            txtferrcod.Clear();
            txtferrnome.Clear();
            txtferrdata.Clear();
            txtferrvalor.Clear();
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
            closeCadFerramentas = 2;
            //Insere a data que será realizado o cadastro
            txtferrdata.Text = DateTime.Now.ToShortDateString();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btLocalizar.ImageIndex = 3;

            //Abre o cadastro do item retornado nos campos 
            frmConsultaFerramentas frmCFerr = new frmConsultaFerramentas();
            frmCFerr.ShowDialog();
            if (frmCFerr.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLFerramentas dll = new DLLFerramentas(cx);
                ModeloFerramentas modelo = dll.CarregaModeloFerramentas(frmCFerr.codigo);
                txtferrcod.Text = modelo.FerrCod.ToString();
                txtferrnome.Text = modelo.FerrNome;
                txtferrvalor.Text = Convert.ToString(modelo.FerrValor);
                txtferrdata.Text = modelo.FerrData;
                txtferrcod.Text = Convert.ToString(modelo.FerrCod);
                label1.Visible = true;
                this.alteraBotoes(3);
                if (txtferrvalor.Text.Contains(","))
                {
                    txtferrvalor.Text = txtferrvalor.Text.Replace(',','.');
                }

            }
            else
            {
                //Limpa os campos
                this.LimpaTela();
                //Altera os botões
                this.alteraBotoes(1);
                //Altera se o controle pode ser fechado
                closeCadFerramentas = 1;
                //Altera Imagem do botão
                btLocalizar.ImageIndex = 2;
            }
            frmCFerr.Dispose();
            
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
            closeCadFerramentas = 2;
            //Insere a data atual para o novo cadastro
            txtferrdata.Text = DateTime.Now.ToShortDateString();
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
                    DLLFerramentas dll = new DLLFerramentas(cx);
                    dll.Excluir(Convert.ToInt32(txtferrcod.Text));
                    //Limpa os campos
                    this.LimpaTela();
                    //Habilita os botões
                    this.alteraBotoes(1);
                    //Habilita o fechamento do User Control
                    closeCadFerramentas = 1;
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
                closeCadFerramentas = 3;

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

                ModeloFerramentas modelo = new ModeloFerramentas();
                modelo.FerrNome = txtferrnome.Text;
                modelo.FerrValor = Convert.ToDouble(txtferrvalor.Text);
                modelo.FerrData = DateTime.Now.ToShortDateString();
                modelo.FerrTime = DateTime.Now.ToShortTimeString();
                modelo.FerrStatus = "local";

                //Obj para gravar os dados da conexão
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLFerramentas dll = new DLLFerramentas(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar nova categoria
                    dll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Código " + modelo.FerrCod.ToString());
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + modelo.FerrCod.ToString() + " cadastrado!";
                }
                else
                {
                    //Alterar Categoria
                    modelo.FerrCod = Convert.ToInt32(txtferrcod.Text);
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
                closeCadFerramentas = 0;
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
                closeCadFerramentas = 1;
                //Esconde a palavra código
                label1.Visible = false;
            }

            btCancelar.ImageIndex = 10;
            btInserir.ImageIndex = 0;
            btLocalizar.ImageIndex = 2;
            
        }

        private void UCCadastroFerramentas_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void txtferrvalor_Leave(object sender, EventArgs e)
        {
            
            if(txtferrvalor.Text.Contains(".") == false)
            {
                txtferrvalor.Text += ".00";
            }
            else
            {
                if (txtferrvalor.Text == "" || txtferrvalor.Text == ".00")
                {
                    txtferrvalor.Text = "0.00";
                }
                else
                {
                    if (txtferrvalor.Text.IndexOf(".") == txtferrvalor.Text.Length - 1 && txtferrvalor.Text.Contains(".00") == false)
                    {
                        txtferrvalor.Text += "00";
                    }
                }
                
            }
            try
            {
                Double d = Convert.ToDouble(txtferrvalor.Text);
            }
            catch
            {
                if (this.operacao == "inserir" || txtferrvalor.Text == "" || txtferrvalor.Text == ".00")
                {
                    txtferrvalor.Text = "0.00";
                }
                
            }

            //txtferrvalor.Text = Convert.ToDouble(txtferrvalor.Text).ToString("C");
        }

        private void txtferrvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                //e.KeyChar = (Char)0;
                e.Handled = true;
            }
            else
            {*/
                
                if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtferrvalor.Text.Contains("."))
                    {
                        e.KeyChar = '.';
                    }
                    else e.Handled = true;
               // }
            }
        }

       



        
    }
}
