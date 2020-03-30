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
    public partial class UCCadastroAtividades : GUI.UCModDeFormCadastro
    {

        //variável de verificação do evento close
        private int closeCadAtividades = 1;
        private int ContaHoras = 0;

        private static UCCadastroAtividades _instancia;

        public static UCCadastroAtividades Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new UCCadastroAtividades();

                return _instancia;
            }
        }

        public UCCadastroAtividades()
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
            if (closeCadAtividades != 1)
            {
                if (MessageBox.Show("Um Cadastro de Atividade está sendo editado! Deseja cancelar esse cadastro em operação?", "Cancelar operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    UCCadastroAtividades.Instancia.BringToFront();
                }
            }
        }


        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtAtivData.Clear();
            txtHoras.Text = "0";
            txtMinutos.Text = "0";
            txtDias.Text = "0";
            txtHExecDias.Text = "8";
        }

        /********************************************************************/
        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtHExecDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            ContaHoras = Convert.ToInt32(txtHExecDias.Text);
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtHoras_Leave(object sender, EventArgs e)
        {
            while (Convert.ToInt32(txtHoras.Text) > Convert.ToInt32(txtHExecDias.Text))
            {
                txtDias.Text = Convert.ToString(Convert.ToInt32(txtDias.Text) + 1);
                txtHoras.Text = Convert.ToString(Convert.ToInt32(txtHoras.Text) - Convert.ToInt32(txtHExecDias.Text));
            }
        }

        private void txtHExecDias_Leave(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtHExecDias.Text) > 24)
            {
                txtHExecDias.Text = "24";
            }
            if (Convert.ToInt32(txtHExecDias.Text) == 0)
            {
                txtHExecDias.Text = "1";
            }
           if(ContaHoras != Convert.ToInt32(txtHExecDias.Text))
           {
               txtMinutos.Text = Convert.ToString(Convert.ToInt32(txtMinutos.Text) + Convert.ToInt32(txtHoras.Text) * 60 + Convert.ToInt32(txtDias.Text)*ContaHoras);
               RecalculaMInutos();
           }
            
        }

        private void txtMinutos_Leave(object sender, EventArgs e)
        {

            RecalculaMInutos();
            
        }

        public void RecalculaMInutos()
        {
            while (Convert.ToInt32(txtMinutos.Text) > 59)
            {
                txtHoras.Text = Convert.ToString(Convert.ToInt32(txtHoras.Text) + 1);
                txtMinutos.Text = Convert.ToString(Convert.ToInt32(txtMinutos.Text) - 60);
            }
            while (Convert.ToInt32(txtHoras.Text) > Convert.ToInt32(txtHExecDias.Text))
            {
                txtDias.Text = Convert.ToString(Convert.ToInt32(txtDias.Text) + 1);
                txtHoras.Text = Convert.ToString(Convert.ToInt32(txtHoras.Text) - Convert.ToInt32(txtHExecDias.Text));
            }
        }
        /********************************************************************/
        private void btInserir_Click(object sender, EventArgs e)
        {
            //Altera imagem do botão
            btInserir.ImageIndex = 1;
            //Determina o tipo como deve ser salvo a edição ao clicar no botão salvar
            this.operacao = "inserir";
            //Habilita botões
            this.alteraBotoes(2);
            //Determina se o User Control pode ser fechado
            closeCadAtividades = 2;
            //Insere a data que será realizado o cadastro
            txtAtivData.Text = DateTime.Now.ToShortDateString();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btLocalizar.ImageIndex = 3;

            //Abre o cadastro do item retornado nos campos 
            frmConsultaAtividades frmCAtiv = new frmConsultaAtividades();
            frmCAtiv.ShowDialog();
            if (frmCAtiv.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLAtividades dll = new DLLAtividades(cx);
                ModeloAtividades modelo = dll.CarregaModeloAtividades(frmCAtiv.codigo);
                txtCodigo.Text = modelo.AtivCod.ToString();
                txtNome.Text = modelo.AtivNome;
                txtAtivData.Text = modelo.AtivData;
                txtDias.Text = Convert.ToString(modelo.AtivDias);
                txtHoras.Text = Convert.ToString(modelo.AtivHoras);
                txtMinutos.Text = Convert.ToString(modelo.AtivMinutos);
                txtHExecDias.Text = Convert.ToString(modelo.AtivHorasDia);
                //txtCodigo.Text = Convert.ToString(modelo.AtivCod);
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
                closeCadAtividades = 1;
                //Altera Imagem do botão
                btLocalizar.ImageIndex = 2;
            }
            frmCAtiv.Dispose();
            
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
            closeCadAtividades = 2;
            //Insere a data atual para o novo cadastro
            txtAtivData.Text = DateTime.Now.ToShortDateString();
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
                    DLLAtividades dll = new DLLAtividades(cx);
                    dll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    //Limpa os campos
                    this.LimpaTela();
                    //Habilita os botões
                    this.alteraBotoes(1);
                    //Habilita o fechamento do User Control
                    closeCadAtividades = 1;
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
                closeCadAtividades = 3;

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

                ModeloAtividades modelo = new ModeloAtividades();
                modelo.AtivNome = txtNome.Text;
                modelo.AtivData = DateTime.Now.ToShortDateString();
                modelo.AtivDias = Convert.ToInt32(txtDias.Text);
                modelo.AtivHoras = Convert.ToInt32(txtHoras.Text);
                modelo.AtivMinutos = Convert.ToInt32(txtMinutos.Text);
                modelo.AtivHorasDia = Convert.ToInt32(txtHExecDias.Text);
                modelo.AtivTime = DateTime.Now.ToShortTimeString();
                modelo.AtivStatus = "local";

                //Obj para gravar os dados da conexão
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLAtividades dll = new DLLAtividades(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar nova categoria
                    dll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Código " + modelo.AtivCod.ToString());
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + modelo.CatCod.ToString() + " cadastrado!";
                }
                else
                {
                    //Alterar Categoria
                    modelo.AtivCod = Convert.ToInt32(txtCodigo.Text);
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
                closeCadAtividades = 0;
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
                closeCadAtividades = 1;
                //Esconde a palavra código
                label1.Visible = false;
            }

            btCancelar.ImageIndex = 10;
            btInserir.ImageIndex = 0;
            btLocalizar.ImageIndex = 2;
            
        }

        private void UCCadastroAtividades_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }
        


    }
}
