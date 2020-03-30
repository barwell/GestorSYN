namespace GUI
{
    partial class UCCadastroCentroCustos
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
            this.txtCentroCustData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCentroCustNome = new System.Windows.Forms.TextBox();
            this.txtCentroCustCod = new System.Windows.Forms.TextBox();
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
            this.pnDados.Controls.Add(this.txtCentroCustData);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.txtCentroCustNome);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtCentroCustCod);
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
            this.label5.Size = new System.Drawing.Size(305, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cadastro de Centro de Custos";
            // 
            // txtCentroCustData
            // 
            this.txtCentroCustData.BackColor = System.Drawing.Color.Aquamarine;
            this.txtCentroCustData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCentroCustData.Enabled = false;
            this.txtCentroCustData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentroCustData.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCentroCustData.Location = new System.Drawing.Point(8, 40);
            this.txtCentroCustData.Name = "txtCentroCustData";
            this.txtCentroCustData.Size = new System.Drawing.Size(118, 19);
            this.txtCentroCustData.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data";
            // 
            // txtCentroCustNome
            // 
            this.txtCentroCustNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCentroCustNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentroCustNome.Location = new System.Drawing.Point(8, 94);
            this.txtCentroCustNome.Name = "txtCentroCustNome";
            this.txtCentroCustNome.Size = new System.Drawing.Size(512, 19);
            this.txtCentroCustNome.TabIndex = 15;
            this.txtCentroCustNome.Leave += new System.EventHandler(this.txtCentroCustNome_Leave);
            // 
            // txtCentroCustCod
            // 
            this.txtCentroCustCod.BackColor = System.Drawing.Color.Aquamarine;
            this.txtCentroCustCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCentroCustCod.Enabled = false;
            this.txtCentroCustCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentroCustCod.Location = new System.Drawing.Point(181, 40);
            this.txtCentroCustCod.Name = "txtCentroCustCod";
            this.txtCentroCustCod.Size = new System.Drawing.Size(100, 19);
            this.txtCentroCustCod.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome do Centro de Custos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código";
            this.label1.Visible = false;
            // 
            // UCCadastroCentroCustos
            // 
            this.Controls.Add(this.label5);
            this.Name = "UCCadastroCentroCustos";
            this.Load += new System.EventHandler(this.UCCadastroCentroCustos_Load);
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

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCentroCustData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCentroCustNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCentroCustCod;
    }
}
