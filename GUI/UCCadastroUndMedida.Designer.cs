namespace GUI
{
    partial class UCCadastroUndMedida
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
            this.txtUmedData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUmedNome = new System.Windows.Forms.TextBox();
            this.txtUmedCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.pnDados.Controls.Add(this.txtUmedData);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtUmedNome);
            this.pnDados.Controls.Add(this.txtUmedCod);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            // 
            // txtUmedData
            // 
            this.txtUmedData.BackColor = System.Drawing.Color.Aquamarine;
            this.txtUmedData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUmedData.Enabled = false;
            this.txtUmedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUmedData.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUmedData.Location = new System.Drawing.Point(7, 49);
            this.txtUmedData.Name = "txtUmedData";
            this.txtUmedData.Size = new System.Drawing.Size(118, 19);
            this.txtUmedData.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data";
            // 
            // txtUmedNome
            // 
            this.txtUmedNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUmedNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUmedNome.Location = new System.Drawing.Point(7, 103);
            this.txtUmedNome.Name = "txtUmedNome";
            this.txtUmedNome.Size = new System.Drawing.Size(512, 19);
            this.txtUmedNome.TabIndex = 9;
            this.txtUmedNome.Leave += new System.EventHandler(this.txtUmedNome_Leave);
            // 
            // txtUmedCod
            // 
            this.txtUmedCod.BackColor = System.Drawing.Color.Aquamarine;
            this.txtUmedCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUmedCod.Enabled = false;
            this.txtUmedCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUmedCod.Location = new System.Drawing.Point(180, 49);
            this.txtUmedCod.Name = "txtUmedCod";
            this.txtUmedCod.Size = new System.Drawing.Size(100, 19);
            this.txtUmedCod.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome da Unidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            this.label1.Visible = false;
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
            this.label5.Size = new System.Drawing.Size(335, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cadastro de Unidades de Medida";
            // 
            // UCCadastroUndMedida
            // 
            this.Controls.Add(this.label5);
            this.Name = "UCCadastroUndMedida";
            this.Load += new System.EventHandler(this.UCCadastroUndMedida_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.pnBotoes.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUmedData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUmedNome;
        private System.Windows.Forms.TextBox txtUmedCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}
