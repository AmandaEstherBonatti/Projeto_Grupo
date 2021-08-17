
namespace SistemaAcademia
{
    partial class CadastroProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProfessor));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mbxCpfprofessor = new System.Windows.Forms.MaskedTextBox();
            this.mbxTelefoneProfessor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvarProfessor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTurnoProfessor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalarioHora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Location = new System.Drawing.Point(53, 9);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProfessor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF";
            // 
            // mbxCpfprofessor
            // 
            this.mbxCpfprofessor.Location = new System.Drawing.Point(45, 35);
            this.mbxCpfprofessor.Mask = "000,000,000-00";
            this.mbxCpfprofessor.Name = "mbxCpfprofessor";
            this.mbxCpfprofessor.Size = new System.Drawing.Size(100, 20);
            this.mbxCpfprofessor.TabIndex = 2;
            // 
            // mbxTelefoneProfessor
            // 
            this.mbxTelefoneProfessor.Location = new System.Drawing.Point(67, 62);
            this.mbxTelefoneProfessor.Mask = "(00)00000-0000";
            this.mbxTelefoneProfessor.Name = "mbxTelefoneProfessor";
            this.mbxTelefoneProfessor.Size = new System.Drawing.Size(100, 20);
            this.mbxTelefoneProfessor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // btnSalvarProfessor
            // 
            this.btnSalvarProfessor.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSalvarProfessor.Location = new System.Drawing.Point(12, 160);
            this.btnSalvarProfessor.Name = "btnSalvarProfessor";
            this.btnSalvarProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarProfessor.TabIndex = 6;
            this.btnSalvarProfessor.Text = "Salvar";
            this.btnSalvarProfessor.UseVisualStyleBackColor = true;
            this.btnSalvarProfessor.Click += new System.EventHandler(this.btnSalvarProfessor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Turno";
            // 
            // cbxTurnoProfessor
            // 
            this.cbxTurnoProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTurnoProfessor.FormattingEnabled = true;
            this.cbxTurnoProfessor.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.cbxTurnoProfessor.Location = new System.Drawing.Point(54, 94);
            this.cbxTurnoProfessor.Name = "cbxTurnoProfessor";
            this.cbxTurnoProfessor.Size = new System.Drawing.Size(121, 21);
            this.cbxTurnoProfessor.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salário p/  hora";
            // 
            // txtSalarioHora
            // 
            this.txtSalarioHora.Location = new System.Drawing.Point(98, 124);
            this.txtSalarioHora.Name = "txtSalarioHora";
            this.txtSalarioHora.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioHora.TabIndex = 5;
            // 
            // CadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(215, 195);
            this.Controls.Add(this.txtSalarioHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxTurnoProfessor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalvarProfessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mbxTelefoneProfessor);
            this.Controls.Add(this.mbxCpfprofessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeProfessor);
            this.Controls.Add(this.label1);
            this.Name = "CadastroProfessor";
            this.Text = "CadastroProfessor";
            this.Load += new System.EventHandler(this.CadastroProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mbxCpfprofessor;
        private System.Windows.Forms.MaskedTextBox mbxTelefoneProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvarProfessor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTurnoProfessor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalarioHora;
    }
}