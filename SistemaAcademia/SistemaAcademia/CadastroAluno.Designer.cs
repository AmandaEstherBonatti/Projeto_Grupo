
namespace SistemaAcademia
{
    partial class CadastroAluno
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTurno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancelarA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mbxTelefoneAluno = new System.Windows.Forms.MaskedTextBox();
            this.mbxCpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cbxPagamento = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxModalidade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Modalidade";
            // 
            // cbxTurno
            // 
            this.cbxTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurno.FormattingEnabled = true;
            this.cbxTurno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.cbxTurno.Location = new System.Drawing.Point(56, 95);
            this.cbxTurno.Name = "cbxTurno";
            this.cbxTurno.Size = new System.Drawing.Size(121, 21);
            this.cbxTurno.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Turno";
            // 
            // btncancelarA
            // 
            this.btncancelarA.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btncancelarA.Location = new System.Drawing.Point(17, 189);
            this.btncancelarA.Name = "btncancelarA";
            this.btncancelarA.Size = new System.Drawing.Size(75, 23);
            this.btncancelarA.TabIndex = 8;
            this.btncancelarA.Text = "Cancel";
            this.btncancelarA.UseVisualStyleBackColor = true;
            this.btncancelarA.Click += new System.EventHandler(this.btnSalvarAluno_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefone";
            // 
            // mbxTelefoneAluno
            // 
            this.mbxTelefoneAluno.Location = new System.Drawing.Point(69, 63);
            this.mbxTelefoneAluno.Mask = "(00)00000-0000";
            this.mbxTelefoneAluno.Name = "mbxTelefoneAluno";
            this.mbxTelefoneAluno.Size = new System.Drawing.Size(100, 20);
            this.mbxTelefoneAluno.TabIndex = 3;
            // 
            // mbxCpfAluno
            // 
            this.mbxCpfAluno.Location = new System.Drawing.Point(47, 36);
            this.mbxCpfAluno.Mask = "000,000,000-00";
            this.mbxCpfAluno.Name = "mbxCpfAluno";
            this.mbxCpfAluno.Size = new System.Drawing.Size(100, 20);
            this.mbxCpfAluno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "CPF";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(55, 10);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(100, 20);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // modalidadeBindingSource
            // 
            this.modalidadeBindingSource.DataSource = typeof(SistemaAcademia.Dominio.Modalidade);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Pagamento";
            // 
            // cbxPagamento
            // 
            this.cbxPagamento.AutoSize = true;
            this.cbxPagamento.Location = new System.Drawing.Point(82, 160);
            this.cbxPagamento.Name = "cbxPagamento";
            this.cbxPagamento.Size = new System.Drawing.Size(79, 17);
            this.cbxPagamento.TabIndex = 6;
            this.cbxPagamento.Text = "Confirmado";
            this.cbxPagamento.UseVisualStyleBackColor = true;
            this.cbxPagamento.CheckedChanged += new System.EventHandler(this.cbxPagamento_CheckedChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Location = new System.Drawing.Point(118, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbxModalidade
            // 
            this.cbxModalidade.DataSource = this.modalidadeBindingSource;
            this.cbxModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModalidade.FormattingEnabled = true;
            this.cbxModalidade.Location = new System.Drawing.Point(82, 125);
            this.cbxModalidade.Name = "cbxModalidade";
            this.cbxModalidade.Size = new System.Drawing.Size(121, 21);
            this.cbxModalidade.TabIndex = 24;
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 224);
            this.Controls.Add(this.cbxModalidade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTurno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncancelarA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mbxTelefoneAluno);
            this.Controls.Add(this.mbxCpfAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAluno";
            this.Text = "CadastroAluno";
            this.Load += new System.EventHandler(this.CadastroAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTurno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancelarA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mbxTelefoneAluno;
        private System.Windows.Forms.MaskedTextBox mbxCpfAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxPagamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource modalidadeBindingSource;
        private System.Windows.Forms.ComboBox cbxModalidade;
    }
}