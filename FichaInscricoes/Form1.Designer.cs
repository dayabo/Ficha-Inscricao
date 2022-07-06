namespace FichaInscricoes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtEscolaridade = new System.Windows.Forms.TextBox();
            this.labelEscoladridade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtValorCurso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorDesconto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorMulta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.listCadastro = new System.Windows.Forms.ListBox();
            this.txtCadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(161, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(248, 27);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(482, 46);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(248, 27);
            this.txtCurso.TabIndex = 3;
            // 
            // txtEscolaridade
            // 
            this.txtEscolaridade.Location = new System.Drawing.Point(132, 132);
            this.txtEscolaridade.Name = "txtEscolaridade";
            this.txtEscolaridade.Size = new System.Drawing.Size(248, 27);
            this.txtEscolaridade.TabIndex = 5;
            // 
            // labelEscoladridade
            // 
            this.labelEscoladridade.AutoSize = true;
            this.labelEscoladridade.Location = new System.Drawing.Point(132, 90);
            this.labelEscoladridade.Name = "labelEscoladridade";
            this.labelEscoladridade.Size = new System.Drawing.Size(94, 20);
            this.labelEscoladridade.TabIndex = 4;
            this.labelEscoladridade.Text = "Escolaridade";
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtIdade.Location = new System.Drawing.Point(679, 132);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(69, 27);
            this.txtIdade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data de Nascimento";
            // 
            // dtDataDeNascimento
            // 
            this.dtDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataDeNascimento.Location = new System.Drawing.Point(453, 132);
            this.dtDataDeNascimento.Name = "dtDataDeNascimento";
            this.dtDataDeNascimento.Size = new System.Drawing.Size(137, 27);
            this.dtDataDeNascimento.TabIndex = 9;
            this.dtDataDeNascimento.Leave += new System.EventHandler(this.dtDataDeNascimento_Leave);
            // 
            // txtValorCurso
            // 
            this.txtValorCurso.Location = new System.Drawing.Point(227, 223);
            this.txtValorCurso.Name = "txtValorCurso";
            this.txtValorCurso.Size = new System.Drawing.Size(106, 27);
            this.txtValorCurso.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor do Curso";
            // 
            // txtValorDesconto
            // 
            this.txtValorDesconto.Location = new System.Drawing.Point(417, 223);
            this.txtValorDesconto.Name = "txtValorDesconto";
            this.txtValorDesconto.Size = new System.Drawing.Size(106, 27);
            this.txtValorDesconto.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor do Desconto";
            // 
            // txtValorMulta
            // 
            this.txtValorMulta.Location = new System.Drawing.Point(594, 223);
            this.txtValorMulta.Name = "txtValorMulta";
            this.txtValorMulta.Size = new System.Drawing.Size(106, 27);
            this.txtValorMulta.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(594, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Valor da Multa";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(147, 282);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(281, 43);
            this.btnCadastrar.TabIndex = 16;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(443, 282);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(281, 43);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // listCadastro
            // 
            this.listCadastro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listCadastro.FormattingEnabled = true;
            this.listCadastro.ItemHeight = 20;
            this.listCadastro.Location = new System.Drawing.Point(212, 428);
            this.listCadastro.Name = "listCadastro";
            this.listCadastro.Size = new System.Drawing.Size(732, 104);
            this.listCadastro.TabIndex = 18;
            // 
            // txtCadastro
            // 
            this.txtCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCadastro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCadastro.Location = new System.Drawing.Point(115, 367);
            this.txtCadastro.Multiline = true;
            this.txtCadastro.Name = "txtCadastro";
            this.txtCadastro.Size = new System.Drawing.Size(815, 37);
            this.txtCadastro.TabIndex = 17;
            this.txtCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = " Aluno Cadastrado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Lista de Alunos Cadastrados";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(956, 544);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCadastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listCadastro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtValorMulta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValorDesconto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValorCurso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtDataDeNascimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEscolaridade);
            this.Controls.Add(this.labelEscoladridade);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCurso;
        private TextBox txtEscolaridade;
        private Label labelEscoladridade;
        private TextBox txtIdade;
        private Label label4;
        private Label label5;
        private DateTimePicker dtDataDeNascimento;
        private TextBox txtValorCurso;
        private Label label6;
        private TextBox txtValorDesconto;
        private Label label7;
        private TextBox txtValorMulta;
        private Label label8;
        private Button btnCadastrar;
        private Button btnLimpar;
        private ListBox listCadastro;
        private TextBox txtCadastro;
        private Label label3;
        private Label label10;
    }
}