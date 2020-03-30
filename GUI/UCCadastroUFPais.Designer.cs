namespace GUI
{
    partial class UCCadastroUFPais
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtpaisdata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtpaiscodigo = new System.Windows.Forms.TextBox();
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
            this.pnDados.Controls.Add(this.txtpaisdata);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.txtnome);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtpaiscodigo);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cadastro de País";
            // 
            // txtpaisdata
            // 
            this.txtpaisdata.BackColor = System.Drawing.Color.Aquamarine;
            this.txtpaisdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpaisdata.Enabled = false;
            this.txtpaisdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaisdata.ForeColor = System.Drawing.SystemColors.Window;
            this.txtpaisdata.Location = new System.Drawing.Point(14, 41);
            this.txtpaisdata.Name = "txtpaisdata";
            this.txtpaisdata.Size = new System.Drawing.Size(118, 19);
            this.txtpaisdata.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data";
            // 
            // txtnome
            // 
            this.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(14, 95);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(512, 19);
            this.txtnome.TabIndex = 9;
            // 
            // txtpaiscodigo
            // 
            this.txtpaiscodigo.BackColor = System.Drawing.Color.Aquamarine;
            this.txtpaiscodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpaiscodigo.Enabled = false;
            this.txtpaiscodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaiscodigo.Location = new System.Drawing.Point(187, 41);
            this.txtpaiscodigo.Name = "txtpaiscodigo";
            this.txtpaiscodigo.Size = new System.Drawing.Size(100, 19);
            this.txtpaiscodigo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do País";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            this.label1.Visible = false;
            // 
            // UCCadastroUFPais
            // 
            this.Controls.Add(this.label4);
            this.Name = "UCCadastroUFPais";
            this.Load += new System.EventHandler(this.UCCadastroUFPais_Load);
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

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpaisdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpaiscodigo;
    }
}
