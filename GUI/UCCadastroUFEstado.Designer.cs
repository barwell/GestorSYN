namespace GUI
{
    partial class UCCadastroUFEstado
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
            this.txtEstadoData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstadoNome = new System.Windows.Forms.TextBox();
            this.txtEstadoCod = new System.Windows.Forms.TextBox();
            this.cbEstadoPaisCod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstadoCodFed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.pnDados.Controls.Add(this.txtEstadoCodFed);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtEstadoData);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtEstadoNome);
            this.pnDados.Controls.Add(this.txtEstadoCod);
            this.pnDados.Controls.Add(this.cbEstadoPaisCod);
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
            this.label5.Size = new System.Drawing.Size(204, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cadastro de Estado";
            // 
            // txtEstadoData
            // 
            this.txtEstadoData.BackColor = System.Drawing.Color.Aquamarine;
            this.txtEstadoData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstadoData.Enabled = false;
            this.txtEstadoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoData.Location = new System.Drawing.Point(7, 33);
            this.txtEstadoData.Name = "txtEstadoData";
            this.txtEstadoData.Size = new System.Drawing.Size(136, 19);
            this.txtEstadoData.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data";
            // 
            // txtEstadoNome
            // 
            this.txtEstadoNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstadoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoNome.Location = new System.Drawing.Point(7, 158);
            this.txtEstadoNome.Name = "txtEstadoNome";
            this.txtEstadoNome.Size = new System.Drawing.Size(488, 19);
            this.txtEstadoNome.TabIndex = 13;
            // 
            // txtEstadoCod
            // 
            this.txtEstadoCod.BackColor = System.Drawing.Color.Aquamarine;
            this.txtEstadoCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstadoCod.Enabled = false;
            this.txtEstadoCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoCod.Location = new System.Drawing.Point(171, 33);
            this.txtEstadoCod.Name = "txtEstadoCod";
            this.txtEstadoCod.Size = new System.Drawing.Size(81, 19);
            this.txtEstadoCod.TabIndex = 12;
            // 
            // cbEstadoPaisCod
            // 
            this.cbEstadoPaisCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstadoPaisCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoPaisCod.FormattingEnabled = true;
            this.cbEstadoPaisCod.Location = new System.Drawing.Point(8, 89);
            this.cbEstadoPaisCod.Name = "cbEstadoPaisCod";
            this.cbEstadoPaisCod.Size = new System.Drawing.Size(285, 28);
            this.cbEstadoPaisCod.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "País";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome do Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código";
            // 
            // txtEstadoCodFed
            // 
            this.txtEstadoCodFed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstadoCodFed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstadoCodFed.Location = new System.Drawing.Point(8, 217);
            this.txtEstadoCodFed.Name = "txtEstadoCodFed";
            this.txtEstadoCodFed.Size = new System.Drawing.Size(284, 19);
            this.txtEstadoCodFed.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Código do Estado";
            // 
            // UCCadastroUFEstado
            // 
            this.Controls.Add(this.label5);
            this.Name = "UCCadastroUFEstado";
            this.Load += new System.EventHandler(this.UCCadastroUFEstado_Load);
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
        private System.Windows.Forms.TextBox txtEstadoCodFed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstadoData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstadoNome;
        private System.Windows.Forms.TextBox txtEstadoCod;
        private System.Windows.Forms.ComboBox cbEstadoPaisCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
