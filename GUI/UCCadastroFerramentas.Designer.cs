namespace GUI
{
    partial class UCCadastroFerramentas
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtferrdata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtferrnome = new System.Windows.Forms.TextBox();
            this.txtferrcod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtferrvalor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtferrvalor);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtferrdata);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.txtferrnome);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtferrcod);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cadastro de Ferramentas";
            // 
            // txtferrdata
            // 
            this.txtferrdata.BackColor = System.Drawing.Color.Aquamarine;
            this.txtferrdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtferrdata.Enabled = false;
            this.txtferrdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtferrdata.ForeColor = System.Drawing.SystemColors.Window;
            this.txtferrdata.Location = new System.Drawing.Point(17, 35);
            this.txtferrdata.Name = "txtferrdata";
            this.txtferrdata.Size = new System.Drawing.Size(118, 19);
            this.txtferrdata.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data";
            // 
            // txtferrnome
            // 
            this.txtferrnome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtferrnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtferrnome.Location = new System.Drawing.Point(17, 89);
            this.txtferrnome.Name = "txtferrnome";
            this.txtferrnome.Size = new System.Drawing.Size(512, 19);
            this.txtferrnome.TabIndex = 9;
            // 
            // txtferrcod
            // 
            this.txtferrcod.BackColor = System.Drawing.Color.Aquamarine;
            this.txtferrcod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtferrcod.Enabled = false;
            this.txtferrcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtferrcod.Location = new System.Drawing.Point(190, 35);
            this.txtferrcod.Name = "txtferrcod";
            this.txtferrcod.Size = new System.Drawing.Size(100, 19);
            this.txtferrcod.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome da Ferramenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            this.label1.Visible = false;
            // 
            // txtferrvalor
            // 
            this.txtferrvalor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtferrvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtferrvalor.Location = new System.Drawing.Point(42, 147);
            this.txtferrvalor.Name = "txtferrvalor";
            this.txtferrvalor.Size = new System.Drawing.Size(159, 19);
            this.txtferrvalor.TabIndex = 13;
            this.txtferrvalor.Text = "0.00";
            this.txtferrvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtferrvalor_KeyPress);
            this.txtferrvalor.Leave += new System.EventHandler(this.txtferrvalor_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor da Ferramenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "R$";
            // 
            // UCCadastroFerramentas
            // 
            this.Controls.Add(this.label4);
            this.Name = "UCCadastroFerramentas";
            this.Load += new System.EventHandler(this.UCCadastroFerramentas_Load);
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
        private System.Windows.Forms.TextBox txtferrdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtferrnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtferrcod;
        private System.Windows.Forms.TextBox txtferrvalor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
