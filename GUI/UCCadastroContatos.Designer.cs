namespace GUI
{
    partial class UCCadastroContatos
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
            this.txtContatoData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContatoNome = new System.Windows.Forms.TextBox();
            this.txtContatoCod = new System.Windows.Forms.TextBox();
            this.cbForCod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContatoTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContatoCel1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbContatoOper1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbContatoOper2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContatoCel2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContatoEnd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbContatoPais = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbContatoEstado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbContatoCity = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbCliCod = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtContatoEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtContatoCep = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chbFornecedor = new System.Windows.Forms.CheckBox();
            this.chbCliente = new System.Windows.Forms.CheckBox();
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
            this.pnDados.Controls.Add(this.chbCliente);
            this.pnDados.Controls.Add(this.chbFornecedor);
            this.pnDados.Controls.Add(this.txtContatoCep);
            this.pnDados.Controls.Add(this.label17);
            this.pnDados.Controls.Add(this.txtContatoEmail);
            this.pnDados.Controls.Add(this.label16);
            this.pnDados.Controls.Add(this.cbCliCod);
            this.pnDados.Controls.Add(this.label15);
            this.pnDados.Controls.Add(this.cbContatoCity);
            this.pnDados.Controls.Add(this.label14);
            this.pnDados.Controls.Add(this.cbContatoEstado);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.cbContatoPais);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.txtContatoEnd);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.cbContatoOper2);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.txtContatoCel2);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.cbContatoOper1);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.txtContatoCel1);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtContatoTel);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtContatoData);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtContatoNome);
            this.pnDados.Controls.Add(this.txtContatoCod);
            this.pnDados.Controls.Add(this.cbForCod);
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
            this.label5.Size = new System.Drawing.Size(223, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cadastro de Contatos";
            // 
            // txtContatoData
            // 
            this.txtContatoData.BackColor = System.Drawing.Color.Aquamarine;
            this.txtContatoData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContatoData.Enabled = false;
            this.txtContatoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatoData.Location = new System.Drawing.Point(7, 37);
            this.txtContatoData.Name = "txtContatoData";
            this.txtContatoData.Size = new System.Drawing.Size(136, 19);
            this.txtContatoData.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data";
            // 
            // txtContatoNome
            // 
            this.txtContatoNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContatoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatoNome.Location = new System.Drawing.Point(8, 86);
            this.txtContatoNome.Name = "txtContatoNome";
            this.txtContatoNome.Size = new System.Drawing.Size(488, 19);
            this.txtContatoNome.TabIndex = 13;
            // 
            // txtContatoCod
            // 
            this.txtContatoCod.BackColor = System.Drawing.Color.Aquamarine;
            this.txtContatoCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContatoCod.Enabled = false;
            this.txtContatoCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatoCod.Location = new System.Drawing.Point(156, 37);
            this.txtContatoCod.Name = "txtContatoCod";
            this.txtContatoCod.Size = new System.Drawing.Size(81, 19);
            this.txtContatoCod.TabIndex = 12;
            // 
            // cbForCod
            // 
            this.cbForCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbForCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbForCod.FormattingEnabled = true;
            this.cbForCod.Location = new System.Drawing.Point(544, 86);
            this.cbForCod.Name = "cbForCod";
            this.cbForCod.Size = new System.Drawing.Size(196, 28);
            this.cbForCod.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vincular ao Fornecedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome do Contato";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código";
            // 
            // txtContatoTel
            // 
            this.txtContatoTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContatoTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatoTel.Location = new System.Drawing.Point(9, 207);
            this.txtContatoTel.Name = "txtContatoTel";
            this.txtContatoTel.Size = new System.Drawing.Size(170, 19);
            this.txtContatoTel.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefone";
            // 
            // txtContatoCel1
            // 
            this.txtContatoCel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContatoCel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatoCel1.Location = new System.Drawing.Point(10, 267);
            this.txtContatoCel1.Name = "txtContatoCel1";
            this.txtContatoCel1.Size = new System.Drawing.Size(170, 19);
            this.txtContatoCel1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Celular1";
            // 
            // cbContatoOper1
            // 
            this.cbContatoOper1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContatoOper1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbContatoOper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContatoOper1.FormattingEnabled = true;
            this.cbContatoOper1.Location = new System.Drawing.Point(207, 267);
            this.cbContatoOper1.Name = "cbContatoOper1";
            this.cbContatoOper1.Size = new System.Drawing.Size(170, 28);
            this.cbContatoOper1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(204, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Operadora";
            // 
            // cbContatoOper2
            // 
            this.cbContatoOper2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContatoOper2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbContatoOper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContatoOper2.FormattingEnabled = true;
            this.cbContatoOper2.Location = new System.Drawing.Point(207, 328);
            this.cbContatoOper2.Name = "cbContatoOper2";
            this.cbContatoOper2.Size = new System.Drawing.Size(170, 28);
            this.cbContatoOper2.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(203, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Operadora";
            // 
            // txtContatoCel2
            // 
            this.txtContatoCel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContatoCel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatoCel2.Location = new System.Drawing.Point(9, 328);
            this.txtContatoCel2.Name = "txtContatoCel2";
            this.txtContatoCel2.Size = new System.Drawing.Size(170, 19);
            this.txtContatoCel2.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Celular2";
            // 
            // txtContatoEnd
            // 
            this.txtContatoEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContatoEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatoEnd.Location = new System.Drawing.Point(9, 440);
            this.txtContatoEnd.Name = "txtContatoEnd";
            this.txtContatoEnd.Size = new System.Drawing.Size(545, 19);
            this.txtContatoEnd.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Endereço";
            // 
            // cbContatoPais
            // 
            this.cbContatoPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbContatoPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContatoPais.FormattingEnabled = true;
            this.cbContatoPais.Location = new System.Drawing.Point(10, 498);
            this.cbContatoPais.Name = "cbContatoPais";
            this.cbContatoPais.Size = new System.Drawing.Size(170, 28);
            this.cbContatoPais.TabIndex = 29;
            this.cbContatoPais.SelectedIndexChanged += new System.EventHandler(this.cbContatoPais_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "País";
            // 
            // cbContatoEstado
            // 
            this.cbContatoEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbContatoEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContatoEstado.FormattingEnabled = true;
            this.cbContatoEstado.Location = new System.Drawing.Point(197, 498);
            this.cbContatoEstado.Name = "cbContatoEstado";
            this.cbContatoEstado.Size = new System.Drawing.Size(170, 28);
            this.cbContatoEstado.TabIndex = 31;
            this.cbContatoEstado.SelectedIndexChanged += new System.EventHandler(this.cbContatoEstado_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(193, 476);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Estado";
            // 
            // cbContatoCity
            // 
            this.cbContatoCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbContatoCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContatoCity.FormattingEnabled = true;
            this.cbContatoCity.Location = new System.Drawing.Point(384, 498);
            this.cbContatoCity.Name = "cbContatoCity";
            this.cbContatoCity.Size = new System.Drawing.Size(170, 28);
            this.cbContatoCity.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(380, 476);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Cidade";
            // 
            // cbCliCod
            // 
            this.cbCliCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCliCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliCod.FormattingEnabled = true;
            this.cbCliCod.Location = new System.Drawing.Point(544, 149);
            this.cbCliCod.Name = "cbCliCod";
            this.cbCliCod.Size = new System.Drawing.Size(196, 28);
            this.cbCliCod.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(540, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "Vincular ao Cliente";
            // 
            // txtContatoEmail
            // 
            this.txtContatoEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContatoEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatoEmail.Location = new System.Drawing.Point(8, 149);
            this.txtContatoEmail.Name = "txtContatoEmail";
            this.txtContatoEmail.Size = new System.Drawing.Size(488, 19);
            this.txtContatoEmail.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 20);
            this.label16.TabIndex = 36;
            this.label16.Text = "email";
            // 
            // txtContatoCep
            // 
            this.txtContatoCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContatoCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatoCep.Location = new System.Drawing.Point(8, 387);
            this.txtContatoCep.Name = "txtContatoCep";
            this.txtContatoCep.Size = new System.Drawing.Size(170, 19);
            this.txtContatoCep.TabIndex = 39;
            this.txtContatoCep.Leave += new System.EventHandler(this.txtContatoCep_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 364);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 20);
            this.label17.TabIndex = 38;
            this.label17.Text = "CEP";
            // 
            // chbFornecedor
            // 
            this.chbFornecedor.AutoSize = true;
            this.chbFornecedor.Location = new System.Drawing.Point(524, 67);
            this.chbFornecedor.Name = "chbFornecedor";
            this.chbFornecedor.Size = new System.Drawing.Size(15, 14);
            this.chbFornecedor.TabIndex = 40;
            this.chbFornecedor.UseVisualStyleBackColor = true;
            this.chbFornecedor.CheckedChanged += new System.EventHandler(this.chbFornecedor_CheckedChanged);
            // 
            // chbCliente
            // 
            this.chbCliente.AutoSize = true;
            this.chbCliente.Location = new System.Drawing.Point(524, 131);
            this.chbCliente.Name = "chbCliente";
            this.chbCliente.Size = new System.Drawing.Size(15, 14);
            this.chbCliente.TabIndex = 41;
            this.chbCliente.UseVisualStyleBackColor = true;
            this.chbCliente.CheckedChanged += new System.EventHandler(this.chbCliente_CheckedChanged);
            // 
            // UCCadastroContatos
            // 
            this.Controls.Add(this.label5);
            this.Name = "UCCadastroContatos";
            this.Load += new System.EventHandler(this.UCCadastroContatos_Load);
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
        private System.Windows.Forms.TextBox txtContatoData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContatoNome;
        private System.Windows.Forms.TextBox txtContatoCod;
        private System.Windows.Forms.ComboBox cbForCod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContatoEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbCliCod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbContatoCity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbContatoEstado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbContatoPais;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtContatoEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbContatoOper2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContatoCel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbContatoOper1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContatoCel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContatoTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContatoCep;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chbCliente;
        private System.Windows.Forms.CheckBox chbFornecedor;
    }
}
