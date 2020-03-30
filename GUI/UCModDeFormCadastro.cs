using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCModDeFormCadastro : UserControl
    {
        public String operacao;
        public UCModDeFormCadastro()
        {
            InitializeComponent();
        }

        public void alteraBotoes(int op)
        {
            //op = operações que serão feitas com os botoes
            //1  = Preparar os botoes para inserir e localizar
            //2  = preparar os para inserir/alterar um registro
            //3  = preparar a tela para excluir ou alterar
            pnDados.Visible = false;
            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {
                
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                
                pnDados.Visible = true;
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                pnDados.Visible = true;
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
        }

        private void UCModDeFormCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
