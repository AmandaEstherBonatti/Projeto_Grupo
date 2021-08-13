
namespace SistemaAcademia
{
    partial class CadastroModalidade
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarModalidade = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdModalidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxProfessorModalidade = new System.Windows.Forms.ComboBox();
            this.cbxVezesPorSemanaModalidade = new System.Windows.Forms.ComboBox();
            this.txtPrecoHora = new System.Windows.Forms.TextBox();
            this.txtNomeModalidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Preço Hora";
            // 
            // btnSalvarModalidade
            // 
            this.btnSalvarModalidade.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSalvarModalidade.Location = new System.Drawing.Point(12, 156);
            this.btnSalvarModalidade.Name = "btnSalvarModalidade";
            this.btnSalvarModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarModalidade.TabIndex = 6;
            this.btnSalvarModalidade.Text = "Ok";
            this.btnSalvarModalidade.UseVisualStyleBackColor = true;
            this.btnSalvarModalidade.Click += new System.EventHandler(this.btnSalvarModalidade_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Vezes por semana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Professor";
            // 
            // txtIdModalidade
            // 
            this.txtIdModalidade.Location = new System.Drawing.Point(56, 36);
            this.txtIdModalidade.Name = "txtIdModalidade";
            this.txtIdModalidade.ReadOnly = true;
            this.txtIdModalidade.Size = new System.Drawing.Size(100, 20);
            this.txtIdModalidade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Id ";
            // 
            // cbxProfessorModalidade
            // 
            this.cbxProfessorModalidade.FormattingEnabled = true;
            this.cbxProfessorModalidade.Location = new System.Drawing.Point(72, 59);
            this.cbxProfessorModalidade.Name = "cbxProfessorModalidade";
            this.cbxProfessorModalidade.Size = new System.Drawing.Size(121, 21);
            this.cbxProfessorModalidade.TabIndex = 3;
            // 
            // cbxVezesPorSemanaModalidade
            // 
            this.cbxVezesPorSemanaModalidade.FormattingEnabled = true;
            this.cbxVezesPorSemanaModalidade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbxVezesPorSemanaModalidade.Location = new System.Drawing.Point(115, 89);
            this.cbxVezesPorSemanaModalidade.Name = "cbxVezesPorSemanaModalidade";
            this.cbxVezesPorSemanaModalidade.Size = new System.Drawing.Size(62, 21);
            this.cbxVezesPorSemanaModalidade.TabIndex = 4;
            // 
            // txtPrecoHora
            // 
            this.txtPrecoHora.Location = new System.Drawing.Point(77, 118);
            this.txtPrecoHora.Name = "txtPrecoHora";
            this.txtPrecoHora.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoHora.TabIndex = 5;
            // 
            // txtNomeModalidade
            // 
            this.txtNomeModalidade.Location = new System.Drawing.Point(53, 6);
            this.txtNomeModalidade.Name = "txtNomeModalidade";
            this.txtNomeModalidade.Size = new System.Drawing.Size(100, 20);
            this.txtNomeModalidade.TabIndex = 1;
            // 
            // CadastroModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 195);
            this.Controls.Add(this.txtNomeModalidade);
            this.Controls.Add(this.txtPrecoHora);
            this.Controls.Add(this.cbxVezesPorSemanaModalidade);
            this.Controls.Add(this.cbxProfessorModalidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalvarModalidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdModalidade);
            this.Controls.Add(this.label1);
            this.Name = "CadastroModalidade";
            this.Text = "Modalidade";
            this.Load += new System.EventHandler(this.CadastroModalidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvarModalidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdModalidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProfessorModalidade;
        private System.Windows.Forms.ComboBox cbxVezesPorSemanaModalidade;
        private System.Windows.Forms.TextBox txtPrecoHora;
        private System.Windows.Forms.TextBox txtNomeModalidade;
    }
}