using System.Windows.Forms;
namespace GUI
{
    partial class UCCadastroCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCadastroCategoria));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcatdata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnBotoes.SuspendLayout();
            this.pnDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.ImageList = this.imageList1;
            this.toolTip1.SetToolTip(this.btCancelar, "Cancelar");
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.ImageList = this.imageList1;
            this.toolTip1.SetToolTip(this.btSalvar, "Salvar");
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.ImageList = this.imageList1;
            this.toolTip1.SetToolTip(this.btExcluir, "Excluir");
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.ImageList = this.imageList1;
            this.toolTip1.SetToolTip(this.btAlterar, "Editar");
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.ImageList = this.imageList1;
            this.toolTip1.SetToolTip(this.btLocalizar, "Localizar");
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.Color.Gainsboro;
            this.btInserir.ImageList = this.imageList1;
            this.toolTip1.SetToolTip(this.btInserir, "Inserir");
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Size = new System.Drawing.Size(794, 52);
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtcatdata);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtnome);
            this.pnDados.Controls.Add(this.txtcodigo);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Location = new System.Drawing.Point(3, 91);
            this.pnDados.Size = new System.Drawing.Size(794, 602);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 700;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.ShowAlways = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Categoria";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.Aquamarine;
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(180, 43);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 19);
            this.txtcodigo.TabIndex = 2;
            // 
            // txtnome
            // 
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(7, 97);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(512, 19);
            this.txtnome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data";
            // 
            // txtcatdata
            // 
            this.txtcatdata.BackColor = System.Drawing.Color.Aquamarine;
            this.txtcatdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcatdata.Enabled = false;
            this.txtcatdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcatdata.ForeColor = System.Drawing.SystemColors.Window;
            this.txtcatdata.Location = new System.Drawing.Point(7, 43);
            this.txtcatdata.Name = "txtcatdata";
            this.txtcatdata.Size = new System.Drawing.Size(118, 19);
            this.txtcatdata.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cadastro de Categorias";
            // 
            // UCCadastroCategoria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label4);
            this.Name = "UCCadastroCategoria";
            this.Size = new System.Drawing.Size(800, 704);
            this.Load += new System.EventHandler(this.UCCadastroCategoria_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.pnBotoes.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolTip toolTip1;
        private ImageList imageList1;
        private TextBox txtnome;
        private TextBox txtcodigo;
        private Label label2;
        private Label label1;
        private TextBox txtcatdata;
        private Label label3;
        private Label label4;
    }
}
