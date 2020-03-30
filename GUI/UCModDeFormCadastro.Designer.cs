using System.Windows.Forms;
namespace GUI
{
    partial class UCModDeFormCadastro
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCModDeFormCadastro));
            this.btCancelar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.pnDados = new System.Windows.Forms.Panel();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.ImageIndex = 10;
            this.btCancelar.ImageList = this.imageList1;
            this.btCancelar.Location = new System.Drawing.Point(258, 3);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(45, 45);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ico_add_resize.png");
            this.imageList1.Images.SetKeyName(1, "ico_add_press_resize.png");
            this.imageList1.Images.SetKeyName(2, "ico_localizar_resize.png");
            this.imageList1.Images.SetKeyName(3, "ico_localizar_press_resize.png");
            this.imageList1.Images.SetKeyName(4, "ico_alterar_resize.png");
            this.imageList1.Images.SetKeyName(5, "ico_alterar_press_resize.png");
            this.imageList1.Images.SetKeyName(6, "ico_excluir_resize.png");
            this.imageList1.Images.SetKeyName(7, "ico_excluir_press_resize.png");
            this.imageList1.Images.SetKeyName(8, "ico_salvar_resize.png");
            this.imageList1.Images.SetKeyName(9, "ico_salvar_press_resize.png");
            this.imageList1.Images.SetKeyName(10, "ico_cancelar_resize.png");
            this.imageList1.Images.SetKeyName(11, "ico_cancelar_press_resize.png");
            // 
            // btSalvar
            // 
            this.btSalvar.ImageIndex = 8;
            this.btSalvar.ImageList = this.imageList1;
            this.btSalvar.Location = new System.Drawing.Point(207, 3);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(45, 45);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.ImageIndex = 6;
            this.btExcluir.ImageList = this.imageList1;
            this.btExcluir.Location = new System.Drawing.Point(156, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(45, 45);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btAlterar
            // 
            this.btAlterar.ImageIndex = 4;
            this.btAlterar.ImageList = this.imageList1;
            this.btAlterar.Location = new System.Drawing.Point(105, 3);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(45, 45);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btLocalizar
            // 
            this.btLocalizar.ImageIndex = 2;
            this.btLocalizar.ImageList = this.imageList1;
            this.btLocalizar.Location = new System.Drawing.Point(54, 3);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(45, 45);
            this.btLocalizar.TabIndex = 1;
            this.btLocalizar.UseVisualStyleBackColor = true;
            // 
            // btInserir
            // 
            this.btInserir.ImageIndex = 0;
            this.btInserir.ImageList = this.imageList1;
            this.btInserir.Location = new System.Drawing.Point(3, 3);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(45, 45);
            this.btInserir.TabIndex = 0;
            this.btInserir.UseVisualStyleBackColor = true;
            // 
            // pnBotoes
            // 
            this.pnBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBotoes.Controls.Add(this.btCancelar);
            this.pnBotoes.Controls.Add(this.btSalvar);
            this.pnBotoes.Controls.Add(this.btExcluir);
            this.pnBotoes.Controls.Add(this.btAlterar);
            this.pnBotoes.Controls.Add(this.btLocalizar);
            this.pnBotoes.Controls.Add(this.btInserir);
            this.pnBotoes.Location = new System.Drawing.Point(3, 33);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(794, 51);
            this.pnBotoes.TabIndex = 3;
            // 
            // pnDados
            // 
            this.pnDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDados.BackColor = System.Drawing.Color.Aquamarine;
            this.pnDados.Location = new System.Drawing.Point(3, 90);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(794, 579);
            this.pnDados.TabIndex = 2;
            // 
            // UCModDeFormCadastro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnDados);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCModDeFormCadastro";
            this.Size = new System.Drawing.Size(800, 672);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UCModDeFormCadastro_KeyDown);
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btCancelar;
        protected System.Windows.Forms.Button btSalvar;
        protected System.Windows.Forms.Button btExcluir;
        protected System.Windows.Forms.Button btAlterar;
        protected System.Windows.Forms.Button btLocalizar;
        protected System.Windows.Forms.Button btInserir;
        protected System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Panel pnDados;
        private ImageList imageList1;
    }
}
