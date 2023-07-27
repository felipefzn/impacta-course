
namespace Lab.WinForms.UI
{
    partial class Principal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadCliente = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.sexoComboBox = new System.Windows.Forms.ComboBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ruaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idadeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.Label();
            this.tabCadContas = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.incluirContaButton = new System.Windows.Forms.Button();
            this.especialRadioButton = new System.Windows.Forms.RadioButton();
            this.comumRadioButton = new System.Windows.Forms.RadioButton();
            this.limiteTextBox = new System.Windows.Forms.TextBox();
            this.limiteLabel = new System.Windows.Forms.Label();
            this.contaTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.agenciaTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabOperacoes = new System.Windows.Forms.TabPage();
            this.btnExtrato = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboOperacao = new System.Windows.Forms.ComboBox();
            this.cboConta = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.Label();
            this.txtOperacao = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.Label();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabCadCliente.SuspendLayout();
            this.tabCadContas.SuspendLayout();
            this.tabOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadCliente);
            this.tabControl1.Controls.Add(this.tabCadContas);
            this.tabControl1.Controls.Add(this.tabOperacoes);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 426);
            this.tabControl1.TabIndex = 18;
            // 
            // tabCadCliente
            // 
            this.tabCadCliente.Controls.Add(this.btnSalvar);
            this.tabCadCliente.Controls.Add(this.sexoComboBox);
            this.tabCadCliente.Controls.Add(this.cepTextBox);
            this.tabCadCliente.Controls.Add(this.label7);
            this.tabCadCliente.Controls.Add(this.cidadeTextBox);
            this.tabCadCliente.Controls.Add(this.label8);
            this.tabCadCliente.Controls.Add(this.numeroTextBox);
            this.tabCadCliente.Controls.Add(this.label4);
            this.tabCadCliente.Controls.Add(this.ruaTextBox);
            this.tabCadCliente.Controls.Add(this.label5);
            this.tabCadCliente.Controls.Add(this.label6);
            this.tabCadCliente.Controls.Add(this.idadeTextBox);
            this.tabCadCliente.Controls.Add(this.label3);
            this.tabCadCliente.Controls.Add(this.nomeTextBox);
            this.tabCadCliente.Controls.Add(this.label2);
            this.tabCadCliente.Controls.Add(this.cpfTextBox);
            this.tabCadCliente.Controls.Add(this.txtDocumento);
            this.tabCadCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCadCliente.Name = "tabCadCliente";
            this.tabCadCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadCliente.Size = new System.Drawing.Size(557, 400);
            this.tabCadCliente.TabIndex = 0;
            this.tabCadCliente.Text = "Cadastro de Cliente";
            this.tabCadCliente.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Image = global::Lab.WinForms.UI.Properties.Resources.Save_37110;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(107, 257);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(183, 80);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "INCLUIR CLIENTE";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // sexoComboBox
            // 
            this.sexoComboBox.FormattingEnabled = true;
            this.sexoComboBox.Location = new System.Drawing.Point(107, 103);
            this.sexoComboBox.Name = "sexoComboBox";
            this.sexoComboBox.Size = new System.Drawing.Size(203, 21);
            this.sexoComboBox.TabIndex = 33;
            // 
            // cepTextBox
            // 
            this.cepTextBox.Location = new System.Drawing.Point(107, 231);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(204, 20);
            this.cepTextBox.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "CEP:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(107, 200);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(204, 20);
            this.cidadeTextBox.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "CIDADE:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(107, 169);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(204, 20);
            this.numeroTextBox.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "NÚMERO:";
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.Location = new System.Drawing.Point(107, 138);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(204, 20);
            this.ruaTextBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "RUA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "SEXO:";
            // 
            // idadeTextBox
            // 
            this.idadeTextBox.Location = new System.Drawing.Point(107, 74);
            this.idadeTextBox.Name = "idadeTextBox";
            this.idadeTextBox.Size = new System.Drawing.Size(204, 20);
            this.idadeTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "IDADE:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(107, 43);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(204, 20);
            this.nomeTextBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "NOME:";
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Location = new System.Drawing.Point(107, 8);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(204, 20);
            this.cpfTextBox.TabIndex = 19;
            // 
            // txtDocumento
            // 
            this.txtDocumento.AutoSize = true;
            this.txtDocumento.Location = new System.Drawing.Point(20, 11);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(80, 13);
            this.txtDocumento.TabIndex = 18;
            this.txtDocumento.Text = "DOCUMENTO:";
            // 
            // tabCadContas
            // 
            this.tabCadContas.Controls.Add(this.clienteComboBox);
            this.tabCadContas.Controls.Add(this.label14);
            this.tabCadContas.Controls.Add(this.incluirContaButton);
            this.tabCadContas.Controls.Add(this.especialRadioButton);
            this.tabCadContas.Controls.Add(this.comumRadioButton);
            this.tabCadContas.Controls.Add(this.limiteTextBox);
            this.tabCadContas.Controls.Add(this.limiteLabel);
            this.tabCadContas.Controls.Add(this.contaTextBox);
            this.tabCadContas.Controls.Add(this.label12);
            this.tabCadContas.Controls.Add(this.agenciaTextBox);
            this.tabCadContas.Controls.Add(this.label11);
            this.tabCadContas.Controls.Add(this.bancoTextBox);
            this.tabCadContas.Controls.Add(this.label10);
            this.tabCadContas.Controls.Add(this.label9);
            this.tabCadContas.Location = new System.Drawing.Point(4, 22);
            this.tabCadContas.Name = "tabCadContas";
            this.tabCadContas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadContas.Size = new System.Drawing.Size(557, 400);
            this.tabCadContas.TabIndex = 1;
            this.tabCadContas.Text = "Cadastro de Contas";
            this.tabCadContas.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(73, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "TIPO:";
            // 
            // incluirContaButton
            // 
            this.incluirContaButton.Location = new System.Drawing.Point(114, 169);
            this.incluirContaButton.Name = "incluirContaButton";
            this.incluirContaButton.Size = new System.Drawing.Size(136, 42);
            this.incluirContaButton.TabIndex = 12;
            this.incluirContaButton.Text = "INCLUIR CONTA";
            this.incluirContaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.incluirContaButton.UseVisualStyleBackColor = true;
            this.incluirContaButton.Click += new System.EventHandler(this.incluirContaButton_Click);
            // 
            // especialRadioButton
            // 
            this.especialRadioButton.AutoSize = true;
            this.especialRadioButton.Location = new System.Drawing.Point(197, 139);
            this.especialRadioButton.Name = "especialRadioButton";
            this.especialRadioButton.Size = new System.Drawing.Size(76, 17);
            this.especialRadioButton.TabIndex = 11;
            this.especialRadioButton.TabStop = true;
            this.especialRadioButton.Text = "ESPECIAL";
            this.especialRadioButton.UseVisualStyleBackColor = true;
            this.especialRadioButton.CheckedChanged += new System.EventHandler(this.especialRadioButton_CheckedChanged);
            // 
            // comumRadioButton
            // 
            this.comumRadioButton.AutoSize = true;
            this.comumRadioButton.Location = new System.Drawing.Point(114, 139);
            this.comumRadioButton.Name = "comumRadioButton";
            this.comumRadioButton.Size = new System.Drawing.Size(66, 17);
            this.comumRadioButton.TabIndex = 10;
            this.comumRadioButton.TabStop = true;
            this.comumRadioButton.Text = "COMUM";
            this.comumRadioButton.UseVisualStyleBackColor = true;
            // 
            // limiteTextBox
            // 
            this.limiteTextBox.Location = new System.Drawing.Point(114, 217);
            this.limiteTextBox.Name = "limiteTextBox";
            this.limiteTextBox.Size = new System.Drawing.Size(100, 20);
            this.limiteTextBox.TabIndex = 9;
            // 
            // limiteLabel
            // 
            this.limiteLabel.AutoSize = true;
            this.limiteLabel.Location = new System.Drawing.Point(66, 220);
            this.limiteLabel.Name = "limiteLabel";
            this.limiteLabel.Size = new System.Drawing.Size(42, 13);
            this.limiteLabel.TabIndex = 8;
            this.limiteLabel.Text = "LIMITE";
            // 
            // contaTextBox
            // 
            this.contaTextBox.Location = new System.Drawing.Point(114, 108);
            this.contaTextBox.Name = "contaTextBox";
            this.contaTextBox.Size = new System.Drawing.Size(100, 20);
            this.contaTextBox.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "NÚM. CONTA:";
            // 
            // agenciaTextBox
            // 
            this.agenciaTextBox.Location = new System.Drawing.Point(114, 78);
            this.agenciaTextBox.Name = "agenciaTextBox";
            this.agenciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.agenciaTextBox.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "NÚM. AGÊNCIA";
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.Location = new System.Drawing.Point(114, 48);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(100, 20);
            this.bancoTextBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "NÚM. BANCO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "CLIENTE:";
            // 
            // tabOperacoes
            // 
            this.tabOperacoes.Controls.Add(this.btnExtrato);
            this.tabOperacoes.Controls.Add(this.btnExecutar);
            this.tabOperacoes.Controls.Add(this.textBox1);
            this.tabOperacoes.Controls.Add(this.cboOperacao);
            this.tabOperacoes.Controls.Add(this.cboConta);
            this.tabOperacoes.Controls.Add(this.txtValor);
            this.tabOperacoes.Controls.Add(this.txtOperacao);
            this.tabOperacoes.Controls.Add(this.txtConta);
            this.tabOperacoes.Location = new System.Drawing.Point(4, 22);
            this.tabOperacoes.Name = "tabOperacoes";
            this.tabOperacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabOperacoes.Size = new System.Drawing.Size(557, 400);
            this.tabOperacoes.TabIndex = 2;
            this.tabOperacoes.Text = "Operações Bancárias";
            this.tabOperacoes.UseVisualStyleBackColor = true;
            // 
            // btnExtrato
            // 
            this.btnExtrato.Location = new System.Drawing.Point(228, 142);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Size = new System.Drawing.Size(107, 29);
            this.btnExtrato.TabIndex = 7;
            this.btnExtrato.Text = "E&xtrato";
            this.btnExtrato.UseVisualStyleBackColor = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(100, 142);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(107, 29);
            this.btnExecutar.TabIndex = 6;
            this.btnExecutar.Text = "&Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(100, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 5;
            // 
            // cboOperacao
            // 
            this.cboOperacao.FormattingEnabled = true;
            this.cboOperacao.Location = new System.Drawing.Point(100, 66);
            this.cboOperacao.Name = "cboOperacao";
            this.cboOperacao.Size = new System.Drawing.Size(196, 21);
            this.cboOperacao.TabIndex = 4;
            // 
            // cboConta
            // 
            this.cboConta.FormattingEnabled = true;
            this.cboConta.Location = new System.Drawing.Point(100, 30);
            this.cboConta.Name = "cboConta";
            this.cboConta.Size = new System.Drawing.Size(196, 21);
            this.cboConta.TabIndex = 3;
            // 
            // txtValor
            // 
            this.txtValor.AutoSize = true;
            this.txtValor.Location = new System.Drawing.Point(37, 104);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(46, 13);
            this.txtValor.TabIndex = 2;
            this.txtValor.Text = "VALOR:";
            this.txtValor.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtOperacao
            // 
            this.txtOperacao.AutoSize = true;
            this.txtOperacao.Location = new System.Drawing.Point(14, 69);
            this.txtOperacao.Name = "txtOperacao";
            this.txtOperacao.Size = new System.Drawing.Size(69, 13);
            this.txtOperacao.TabIndex = 1;
            this.txtOperacao.Text = "OPERAÇÃO:";
            // 
            // txtConta
            // 
            this.txtConta.AutoSize = true;
            this.txtConta.Location = new System.Drawing.Point(36, 33);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(47, 13);
            this.txtConta.TabIndex = 0;
            this.txtConta.Text = "CONTA:";
            this.txtConta.Click += new System.EventHandler(this.label13_Click);
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(114, 11);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(205, 21);
            this.clienteComboBox.TabIndex = 14;
            // 
            // Principal
            // 
            this.AcceptButton = this.btnExecutar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabCadCliente.ResumeLayout(false);
            this.tabCadCliente.PerformLayout();
            this.tabCadContas.ResumeLayout(false);
            this.tabCadContas.PerformLayout();
            this.tabOperacoes.ResumeLayout(false);
            this.tabOperacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadCliente;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox sexoComboBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ruaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idadeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.Label txtDocumento;
        private System.Windows.Forms.TabPage tabCadContas;
        private System.Windows.Forms.TabPage tabOperacoes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button incluirContaButton;
        private System.Windows.Forms.RadioButton especialRadioButton;
        private System.Windows.Forms.RadioButton comumRadioButton;
        private System.Windows.Forms.TextBox limiteTextBox;
        private System.Windows.Forms.Label limiteLabel;
        private System.Windows.Forms.TextBox contaTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox agenciaTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtConta;
        private System.Windows.Forms.Label txtValor;
        private System.Windows.Forms.Label txtOperacao;
        private System.Windows.Forms.Button btnExtrato;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboOperacao;
        private System.Windows.Forms.ComboBox cboConta;
        private System.Windows.Forms.ComboBox clienteComboBox;
    }
}

