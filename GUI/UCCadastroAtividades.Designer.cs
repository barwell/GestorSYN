namespace GUI
{
    partial class UCCadastroAtividades
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
            this.txtAtivData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHExecDias = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.txtHExecDias);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtMinutos);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtHoras);
            this.pnDados.Controls.Add(this.txtDias);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtAtivData);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtCodigo);
            // 
            // txtAtivData
            // 
            this.txtAtivData.BackColor = System.Drawing.Color.Aquamarine;
            this.txtAtivData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAtivData.Enabled = false;
            this.txtAtivData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtivData.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAtivData.Location = new System.Drawing.Point(8, 39);
            this.txtAtivData.Name = "txtAtivData";
            this.txtAtivData.Size = new System.Drawing.Size(118, 19);
            this.txtAtivData.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(8, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(512, 19);
            this.txtNome.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Aquamarine;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(181, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 19);
            this.txtCodigo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome da Atividade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            this.label1.Visible = false;
            // 
            // txtDias
            // 
            this.txtDias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(8, 185);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(57, 19);
            this.txtDias.TabIndex = 13;
            this.txtDias.Text = "0";
            this.txtDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDias_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tempo de Execução:";
            // 
            // txtHoras
            // 
            this.txtHoras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.Location = new System.Drawing.Point(125, 185);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(57, 19);
            this.txtHoras.TabIndex = 14;
            this.txtHoras.Text = "0";
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoras_KeyPress);
            this.txtHoras.Leave += new System.EventHandler(this.txtHoras_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Horas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Minutos";
            // 
            // txtMinutos
            // 
            this.txtMinutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutos.Location = new System.Drawing.Point(242, 185);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(57, 19);
            this.txtMinutos.TabIndex = 17;
            this.txtMinutos.Text = "0";
            this.txtMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinutos_KeyPress);
            this.txtMinutos.Leave += new System.EventHandler(this.txtMinutos_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cadastro de Atividades";
            // 
            // txtHExecDias
            // 
            this.txtHExecDias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHExecDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHExecDias.Location = new System.Drawing.Point(8, 250);
            this.txtHExecDias.Name = "txtHExecDias";
            this.txtHExecDias.Size = new System.Drawing.Size(57, 19);
            this.txtHExecDias.TabIndex = 19;
            this.txtHExecDias.Text = "8";
            this.txtHExecDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHExecDias_KeyPress);
            this.txtHExecDias.Leave += new System.EventHandler(this.txtHExecDias_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Horas de Execução Por Dia";
            // 
            // UCCadastroAtividades
            // 
            this.Controls.Add(this.label8);
            this.Name = "UCCadastroAtividades";
            this.Load += new System.EventHandler(this.UCCadastroAtividades_Load);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.pnBotoes.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAtivData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHExecDias;
    }
}
