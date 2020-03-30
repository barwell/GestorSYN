namespace GUI
{
    partial class UCCadastroTipoCobranca
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipoCobData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipoCobNome = new System.Windows.Forms.TextBox();
            this.txtTipoCobCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBotoes.SuspendLayout();
            this.pnDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtTipoCobData);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtTipoCobNome);
            this.pnDados.Controls.Add(this.txtTipoCobCod);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cadastro de Tipo de Cobrança";
            // 
            // txtTipoCobData
            // 
            this.txtTipoCobData.BackColor = System.Drawing.Color.Aquamarine;
            this.txtTipoCobData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoCobData.Enabled = false;
            this.txtTipoCobData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCobData.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTipoCobData.Location = new System.Drawing.Point(8, 32);
            this.txtTipoCobData.Name = "txtTipoCobData";
            this.txtTipoCobData.Size = new System.Drawing.Size(118, 19);
            this.txtTipoCobData.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data";
            // 
            // txtTipoCobNome
            // 
            this.txtTipoCobNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoCobNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCobNome.Location = new System.Drawing.Point(8, 86);
            this.txtTipoCobNome.Name = "txtTipoCobNome";
            this.txtTipoCobNome.Size = new System.Drawing.Size(512, 19);
            this.txtTipoCobNome.TabIndex = 15;
            this.txtTipoCobNome.Leave += new System.EventHandler(this.txtTipoCobNome_Leave);
            // 
            // txtTipoCobCod
            // 
            this.txtTipoCobCod.BackColor = System.Drawing.Color.Aquamarine;
            this.txtTipoCobCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoCobCod.Enabled = false;
            this.txtTipoCobCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCobCod.Location = new System.Drawing.Point(181, 32);
            this.txtTipoCobCod.Name = "txtTipoCobCod";
            this.txtTipoCobCod.Size = new System.Drawing.Size(100, 19);
            this.txtTipoCobCod.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome do Tipo de Cobrança";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código";
            this.label1.Visible = false;
            // 
            // UCCadastroTipoCobranca
            // 
            this.Controls.Add(this.label5);
            this.Name = "UCCadastroTipoCobranca";
            this.Load += new System.EventHandler(this.UCCadastroTipoCobranca_Load);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.pnBotoes.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipoCobData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipoCobNome;
        private System.Windows.Forms.TextBox txtTipoCobCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
