
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvarModalidade = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxVezesPorSemanaModalidade = new System.Windows.Forms.ComboBox();
            this.txtPrecoHora = new System.Windows.Forms.TextBox();
            this.txtNomeModalidade = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxProfessorModalidade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 22);
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
            this.btnSalvarModalidade.TabIndex = 5;
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
            // professorBindingSource
            // 
            this.professorBindingSource.DataSource = typeof(SistemaAcademia.Dominio.Professor);
            // 
            // cbxVezesPorSemanaModalidade
            // 
            this.cbxVezesPorSemanaModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVezesPorSemanaModalidade.FormattingEnabled = true;
            this.cbxVezesPorSemanaModalidade.ItemHeight = 13;
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
            this.txtPrecoHora.TabIndex = 4;
            // 
            // txtNomeModalidade
            // 
            this.txtNomeModalidade.Location = new System.Drawing.Point(56, 19);
            this.txtNomeModalidade.Name = "txtNomeModalidade";
            this.txtNomeModalidade.Size = new System.Drawing.Size(100, 20);
            this.txtNomeModalidade.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.Location = new System.Drawing.Point(118, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxProfessorModalidade
            // 
            this.cbxProfessorModalidade.DataSource = this.professorBindingSource;
            this.cbxProfessorModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProfessorModalidade.FormattingEnabled = true;
            this.cbxProfessorModalidade.Location = new System.Drawing.Point(72, 59);
            this.cbxProfessorModalidade.Name = "cbxProfessorModalidade";
            this.cbxProfessorModalidade.Size = new System.Drawing.Size(121, 21);
            this.cbxProfessorModalidade.TabIndex = 2;
            this.cbxProfessorModalidade.SelectedIndexChanged += new System.EventHandler(this.cbxProfessorModalidade_SelectedIndexChanged_1);
            // 
            // CadastroModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 195);
            this.Controls.Add(this.cbxProfessorModalidade);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtNomeModalidade);
            this.Controls.Add(this.txtPrecoHora);
            this.Controls.Add(this.cbxVezesPorSemanaModalidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalvarModalidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CadastroModalidade";
            this.Text = "Modalidade";
            this.Load += new System.EventHandler(this.CadastroModalidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvarModalidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxVezesPorSemanaModalidade;
        private System.Windows.Forms.TextBox txtPrecoHora;
        private System.Windows.Forms.TextBox txtNomeModalidade;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private System.Windows.Forms.ComboBox cbxProfessorModalidade;
    }
}