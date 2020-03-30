using DAL;
using DLL;
using Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FerramentasDeProjeto;


namespace GUI
{
    public partial class UCCadastroContatos : GUI.UCModDeFormCadastro
    {
        private int closeCadContato = 1;

        private static UCCadastroContatos _instancia;

        public static UCCadastroContatos Instancia
        {
            get
            {
                if (_instancia == null) { _instancia = new UCCadastroContatos(); }

                return _instancia;
            }
        }

        public class estrutcombobox
        {
            /// <summary>
            /// Propriedade ID
            /// </summary>
            public int ID { get; set; }
            /// <summary>
            /// Propriedade Descrição
            /// </summary>
            public string Descricao { get; set; }
            /// <summary>
            /// Método construtor com parâmetros de entrada
            /// </summary>
            /// <param name="ID">ID </param>
            /// <param name="Descricao">Descrição </param>
            public estrutcombobox(int ID, string Descricao)
            {
                this.ID = ID;
                this.Descricao = Descricao;
            }
        }

        public UCCadastroContatos()
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
            if (closeCadContato != 1)
            {
                if (MessageBox.Show("Um Cadastro de Categoria está sendo editado! Deseja cancelar esse cadastro em operação?", "Cancelar operação?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    UCCadastroSubCategoria.Instancia.BringToFront();
                }
            }
        }


        public void LimpaTela()
        {
            txtContatoCod.Clear();
            txtContatoNome.Clear();
            txtContatoData.Clear();
            txtContatoEnd.Clear();
            txtContatoEmail.Clear();
            txtContatoCel1.Clear();
            txtContatoCel2.Clear();
            txtContatoTel.Clear();
            cbContatoOper1.SelectedItem = "Indefinida";
            cbContatoOper2.SelectedItem = "Indefinida";
            this.cbForCod.Enabled = false;
            this.cbForCod.Text = "";
            this.cbCliCod.Enabled = false;
            this.cbCliCod.Text = "";
            
        }


        private void btInserir_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btInserir.ImageIndex = 1;

            this.alteraBotoes(2);
            closeCadContato = 2;
            this.operacao = "inserir";
            txtContatoData.Text = DateTime.Now.ToShortDateString();
            //txtContatoCod.Text = 
        }

        private void UCCadastroContatos_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);

            cbForCod.Enabled = false;
            cbCliCod.Enabled = false;

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            /*DLLFornecedor dllf = new DLLFornecedor(cx);
            cbForCod.DataSource = dllf.Localizar("");
            cbForCod.DisplayMember = "for_nome";
            cbForCod.ValueMember = "for_cod";

            DLLCliente dllc = new DLLCliente(cx);
            cbForCod.DataSource = dll.Localizar("");
            cbForCod.DisplayMember = "cli_nome";
            cbForCod.ValueMember = "cli_cod";*/

            DLLPais dllp = new DLLPais(cx);
            cbContatoPais.DataSource = dllp.Localizar("");
            cbContatoPais.DisplayMember = "pais_nome";
            cbContatoPais.ValueMember = "pais_cod";

            //cbContatoPais.SelectedValue = "1";

            try
            {
                this.cbContatoEstado.Text = "";
                DLLEstado dlle = new DLLEstado(cx);

                this.cbContatoEstado.DataSource = dlle.LocalizarItens((int)this.cbContatoPais.SelectedValue, "estado", "estado_pais_cod");
                this.cbContatoEstado.DisplayMember = "estado_nome";
                this.cbContatoEstado.ValueMember = "estado_cod";
            }
            catch { }
            try
            {
                this.cbContatoCity.Text = "";
                DLLCidade dllc = new DLLCidade(cx);

                this.cbContatoCity.DataSource = dllc.LocalizarItens((int)this.cbContatoEstado.SelectedValue, "cidade", "city_estado_cod");
                this.cbContatoCity.DisplayMember = "city_nome";
                this.cbContatoCity.ValueMember = "city_cod";
            }
            catch
            {

            }

            ArrayList arr = new ArrayList();
            arr.Add(new estrutcombobox(1, "Indefinida"));
            arr.Add(new estrutcombobox(2, "Claro"));
            arr.Add(new estrutcombobox(3, "CTBC Telecom"));
            arr.Add(new estrutcombobox(4, "Nextel"));
            arr.Add(new estrutcombobox(5, "Oi"));
            arr.Add(new estrutcombobox(6, "Porto Seguro Conecta"));
            arr.Add(new estrutcombobox(7, "Sercomtel"));
            arr.Add(new estrutcombobox(8, "TIM"));
            arr.Add(new estrutcombobox(9, "Vivo"));

            cbContatoOper1.DataSource = arr;
            cbContatoOper1.DisplayMember = "Descricao";
            cbContatoOper1.ValueMember = "ID";


            ArrayList arr2 = new ArrayList();
            arr2.Add(new estrutcombobox(1, "Indefinida"));
            arr2.Add(new estrutcombobox(2, "Claro"));
            arr2.Add(new estrutcombobox(3, "CTBC Telecom"));
            arr2.Add(new estrutcombobox(4, "Nextel"));
            arr2.Add(new estrutcombobox(5, "Oi"));
            arr2.Add(new estrutcombobox(6, "Porto Seguro Conecta"));
            arr2.Add(new estrutcombobox(7, "Sercomtel"));
            arr2.Add(new estrutcombobox(8, "TIM"));
            arr2.Add(new estrutcombobox(9, "Vivo"));

            cbContatoOper2.DataSource = arr2;
            cbContatoOper2.DisplayMember = "Descricao";
            cbContatoOper2.ValueMember = "ID";

            cbContatoOper1.SelectedItem = 1;
            cbContatoOper2.SelectedItem = 1;

        }



        private void btLocalizar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btLocalizar.ImageIndex = 3;

            frmConsultaContato frmContato = new frmConsultaContato();
            frmContato.ShowDialog();
            if (frmContato.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLContato dll = new DLLContato(cx);
                ModeloContato modelo = dll.CarregaModeloContato(frmContato.codigo);
                txtContatoCod.Text = modelo.ContatoCod.ToString();
                txtContatoNome.Text = modelo.ContatoNome.ToString();
                txtContatoData.Text = modelo.ContatoData.ToString();
                txtContatoEmail.Text = modelo.ContatoEmail.ToString();
                txtContatoEnd.Text = modelo.ContatoEndereco.ToString();
                txtContatoTel.Text = modelo.ContatoTelefone.ToString();
                txtContatoCel1.Text = modelo.ContatoCel1.ToString();
                txtContatoCel2.Text = modelo.ContatoCel2.ToString();
                cbContatoOper1.SelectedValue = Convert.ToInt32(modelo.ContatoCel1Oper.ToString());
                cbContatoOper2.SelectedValue = Convert.ToInt32(modelo.ContatoCel2Oper.ToString());

                if (Convert.ToInt32(modelo.ContatoForCod.ToString()) == 0)
                {
                    chbFornecedor.Checked = true;
                    cbForCod.Enabled = false;
                }
                else
                {
                    chbCliente.Checked = false;
                    cbForCod.Enabled = true;
                    /*  DLLFornecedor dllf = new DLLFornecedor(cx);
                    this.cbForCod.DataSource = dllf.Localizar("");
                    this.cbForCod.DisplayMember = "for_nome";
                    this.cbForCod.ValueMember = "for_cod";
                    this.cbForCod.SelectedValue = Convert.ToInt32(modelo.ContatoForCod.ToString());*/

                }

                if (Convert.ToInt32(modelo.ContatoForCod.ToString()) == 0)
                {
                    chbFornecedor.Checked = true;
                    cbForCod.Enabled = false;
                }
                else
                {
                    chbCliente.Checked = false;
                    cbForCod.Enabled = true;
                    /*  DLLFornecedor dllf = new DLLFornecedor(cx);
                    this.cbForCod.DataSource = dllf.Localizar("");
                    this.cbForCod.DisplayMember = "for_nome";
                    this.cbForCod.ValueMember = "for_cod";
                    this.cbForCod.SelectedValue = Convert.ToInt32(modelo.ContatoForCod.ToString());*/
                    
                }

                label1.Visible = true;
                this.alteraBotoes(3);
                closeCadContato = 3;

            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
                btLocalizar.ImageIndex = 2;
            }
            frmContato.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Alterna imagens dos botões
            btAlterar.ImageIndex = 5;

            this.operacao = "alterar";
            this.alteraBotoes(2);
            closeCadContato = 2;
            txtContatoData.Text = DateTime.Now.ToShortDateString();

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
                    DLLContato dll = new DLLContato(cx);
                    dll.Excluir(Convert.ToInt32(txtContatoCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    closeCadContato = 1;
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
                closeCadContato = 3;
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

                ModeloContato modelo = new ModeloContato();
                //modelo.ContatoCod = modelo.ContatoCod.ToString() +;
               /* if(chbFornecedor.Checked == true) modelo.ContatoForCod = Convert.ToInt32(cbForCod.SelectedValue);
                else modelo.ContatoForCod = 1;

                if (chbCliente.Checked == true) modelo.ContatoCliCod = Convert.ToInt32(cbCliCod.SelectedValue);
                else modelo.ContatoCliCod = 1;*/

                modelo.ContatoPaisCod = Convert.ToInt32(cbContatoPais.SelectedValue);
                modelo.ContatoEstadoCod = Convert.ToInt32(cbContatoEstado.SelectedValue);
                modelo.ContatoCityCod = Convert.ToInt32(cbContatoCity.SelectedValue);
                modelo.ContatoNome = txtContatoNome.Text;
                modelo.ContatoCep = txtContatoCep.Text;
                modelo.ContatoEndereco = txtContatoEnd.Text;
                modelo.ContatoEmail = txtContatoEmail.Text;
                modelo.ContatoCel1 = txtContatoCel1.Text;
                modelo.ContatoCel2 = txtContatoCel2.Text;
                //modelo.
                modelo.ContatoData = DateTime.Now.ToShortDateString();
                modelo.ContatoTime = DateTime.Now.ToShortTimeString();
                modelo.ContatoStatus = "local";

                //Obj para gravar os dados da conexão
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                DLLContato dll = new DLLContato(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar nova categoria
                    dll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado: Código " + modelo.ContatoCod.ToString());
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + modelo.CatCod.ToString() + " cadastrado!";
                }
                else
                {
                    //Alterar Categoria
                    modelo.ContatoCod = Convert.ToInt32(txtContatoCod.Text);
                    dll.Alterar(modelo);
                    MessageBox.Show("Cadastro Alterado!");
                    //toolStripBarStatus.Text = "Procedimento OK! Item " + txtcodigo.Text + " alterado!";
                    label1.Visible = false;
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                closeCadContato = 1;
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

        private void cbContatoPais_SelectedIndexChanged(object sender, EventArgs e)
        {


                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                try
                {
                    this.cbContatoEstado.Text = "";
                    DLLEstado dlle = new DLLEstado(cx);

                    this.cbContatoEstado.DataSource = dlle.LocalizarItens((int)this.cbContatoPais.SelectedValue, "estado", "estado_pais_cod");
                    this.cbContatoEstado.DisplayMember = "estado_nome";
                    this.cbContatoEstado.ValueMember = "estado_cod";
                }
                catch { }
               
            
        }

       
        private void cbContatoEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                try
                {
                    this.cbContatoCity.Text = "";
                    DLLCidade dllc = new DLLCidade(cx);

                    this.cbContatoCity.DataSource = dllc.LocalizarItens((int) this.cbContatoEstado.SelectedValue, "cidade", "city_estado_cod");
                    this.cbContatoCity.DisplayMember = "city_nome";
                    this.cbContatoCity.ValueMember = "city_cod";
                }
                catch
                {
                    
                }
                
           
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
                closeCadContato = 1;
                //Esconde a palavra código
                label1.Visible = false;
            }

            btCancelar.ImageIndex = 10;
            btInserir.ImageIndex = 0;
            btLocalizar.ImageIndex = 2;
        }

        private void txtContatoCep_Leave(object sender, EventArgs e)
        {
            if(BuscaEndereco.verificaCEP(txtContatoCep.Text) == true)
            {
                txtContatoEnd.Text = BuscaEndereco.endereco;

            }
        }

        private void chbFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFornecedor.Checked == true)
            { 
                cbForCod.Enabled = true;
              /*  DLLFornecedor dllf = new DLLFornecedor(cx);

                this.cbForCod.DataSource = dllf.Localizar("");
                this.cbForCod.DisplayMember = "for_nome";
                this.cbForCod.ValueMember = "for_cod";*/

            }
            else
            {
                this.cbForCod.Enabled = false;
                this.cbForCod.Text = "";
            }
            
        }
        
        private void chbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCliente.Checked == true) 
            { 
                cbCliCod.Enabled = true;

                /*  DLLFornecedor dllcl = new DLLFornecedor(cx);

                this.cbCliCod.DataSource = dllcl.Localizar("");
                this.cbCliCod.DisplayMember = "cli_nome";
                this.cbCliCod.ValueMember = "cli_cod";*/

            }
            else
            {
                this.cbCliCod.Enabled = false;
                this.cbCliCod.Text = "";
            } 
                
        }



    }
}
