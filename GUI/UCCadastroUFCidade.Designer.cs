namespace GUI
{
    partial class UCCadastroUFCidade
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
            this.txtCityCodFed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCityData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCityNome = new System.Windows.Forms.TextBox();
            this.txtCityCod = new System.Windows.Forms.TextBox();
            this.cbCityEstadoCod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pnDados.Controls.Add(this.txtCityCodFed);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtCityData);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtCityNome);
            this.pnDados.Controls.Add(this.txtCityCod);
            this.pnDados.Controls.Add(this.cbCityEstadoCod);
            this.pnDados.Controls.Add(this.label3);
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
            this.label5.Size = new System.Drawing.Size(205, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cadastro de Cidade";
            // 
            // txtCityCodFed
            // 
            this.txtCityCodFed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCityCodFed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityCodFed.Location = new System.Drawing.Point(8, 220);
            this.txtCityCodFed.Name = "txtCityCodFed";
            this.txtCityCodFed.Size = new System.Drawing.Size(284, 19);
            this.txtCityCodFed.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Código da Cidade";
            // 
            // txtCityData
            // 
            this.txtCityData.BackColor = System.Drawing.Color.Aquamarine;
            this.txtCityData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCityData.Enabled = false;
            this.txtCityData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityData.Location = new System.Drawing.Point(7, 36);
            this.txtCityData.Name = "txtCityData";
            this.txtCityData.Size = new System.Drawing.Size(136, 19);
            this.txtCityData.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data";
            // 
            // txtCityNome
            // 
            this.txtCityNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCityNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityNome.Location = new System.Drawing.Point(7, 161);
            this.txtCityNome.Name = "txtCityNome";
            this.txtCityNome.Size = new System.Drawing.Size(488, 19);
            this.txtCityNome.TabIndex = 23;
            // 
            // txtCityCod
            // 
            this.txtCityCod.BackColor = System.Drawing.Color.Aquamarine;
            this.txtCityCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCityCod.Enabled = false;
            this.txtCityCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityCod.Location = new System.Drawing.Point(171, 36);
            this.txtCityCod.Name = "txtCityCod";
            this.txtCityCod.Size = new System.Drawing.Size(81, 19);
            this.txtCityCod.TabIndex = 22;
            // 
            // cbCityEstadoCod
            // 
            this.cbCityEstadoCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCityEstadoCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCityEstadoCod.FormattingEnabled = true;
            this.cbCityEstadoCod.Location = new System.Drawing.Point(8, 92);
            this.cbCityEstadoCod.Name = "cbCityEstadoCod";
            this.cbCityEstadoCod.Size = new System.Drawing.Size(285, 28);
            this.cbCityEstadoCod.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome da Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código";
            // 
            // UCCadastroUFCidade
            // 
            this.Controls.Add(this.label5);
            this.Name = "UCCadastroUFCidade";
            this.Load += new System.EventHandler(this.UCCadastroUFCidade_Load);
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
        private System.Windows.Forms.TextBox txtCityCodFed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCityData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCityNome;
        private System.Windows.Forms.TextBox txtCityCod;
        private System.Windows.Forms.ComboBox cbCityEstadoCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
