
namespace SistemaAcademia
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idModalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vezesSemanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovoProfessor = new System.Windows.Forms.Button();
            this.bntAlterarProfessor = new System.Windows.Forms.Button();
            this.btnExcluirProfessor = new System.Windows.Forms.Button();
            this.btnAlterarAluno = new System.Windows.Forms.Button();
            this.btnNovoAluno = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnNovoModalidade = new System.Windows.Forms.Button();
            this.btnAlterarModalidade = new System.Windows.Forms.Button();
            this.btnExcluirModalidade = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aluno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pessoaBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.Location = new System.Drawing.Point(15, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(249, 272);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(SistemaAcademia.Dominio.Pessoa);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.Modalidade,
            this.Pagou,
            this.nomeDataGridViewTextBoxColumn1,
            this.cpfDataGridViewTextBoxColumn1,
            this.telefoneDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.pessoaBindingSource1;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.Location = new System.Drawing.Point(288, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(249, 272);
            this.dataGridView2.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // Modalidade
            // 
            this.Modalidade.DataPropertyName = "Modalidade";
            this.Modalidade.HeaderText = "Modalidade";
            this.Modalidade.Name = "Modalidade";
            // 
            // Pagou
            // 
            this.Pagou.DataPropertyName = "Pagou";
            this.Pagou.HeaderText = "Pagou";
            this.Pagou.Name = "Pagou";
            this.Pagou.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            // 
            // cpfDataGridViewTextBoxColumn1
            // 
            this.cpfDataGridViewTextBoxColumn1.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn1.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn1.Name = "cpfDataGridViewTextBoxColumn1";
            // 
            // telefoneDataGridViewTextBoxColumn1
            // 
            this.telefoneDataGridViewTextBoxColumn1.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn1.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn1.Name = "telefoneDataGridViewTextBoxColumn1";
            // 
            // pessoaBindingSource1
            // 
            this.pessoaBindingSource1.DataSource = typeof(SistemaAcademia.Dominio.Aluno);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modalidade";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idModalidadeDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn,
            this.vezesSemanaDataGridViewTextBoxColumn,
            this.precoHoraDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.modalidadeBindingSource;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView3.Location = new System.Drawing.Point(555, 40);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(249, 272);
            this.dataGridView3.TabIndex = 5;
            // 
            // idModalidadeDataGridViewTextBoxColumn
            // 
            this.idModalidadeDataGridViewTextBoxColumn.DataPropertyName = "IdModalidade";
            this.idModalidadeDataGridViewTextBoxColumn.HeaderText = "IdModalidade";
            this.idModalidadeDataGridViewTextBoxColumn.Name = "idModalidadeDataGridViewTextBoxColumn";
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            // 
            // vezesSemanaDataGridViewTextBoxColumn
            // 
            this.vezesSemanaDataGridViewTextBoxColumn.DataPropertyName = "VezesSemana";
            this.vezesSemanaDataGridViewTextBoxColumn.HeaderText = "VezesSemana";
            this.vezesSemanaDataGridViewTextBoxColumn.Name = "vezesSemanaDataGridViewTextBoxColumn";
            // 
            // precoHoraDataGridViewTextBoxColumn
            // 
            this.precoHoraDataGridViewTextBoxColumn.DataPropertyName = "PrecoHora";
            this.precoHoraDataGridViewTextBoxColumn.HeaderText = "PrecoHora";
            this.precoHoraDataGridViewTextBoxColumn.Name = "precoHoraDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn2
            // 
            this.nomeDataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn2.Name = "nomeDataGridViewTextBoxColumn2";
            // 
            // modalidadeBindingSource
            // 
            this.modalidadeBindingSource.DataSource = typeof(SistemaAcademia.Dominio.Modalidade);
            // 
            // btnNovoProfessor
            // 
            this.btnNovoProfessor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovoProfessor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNovoProfessor.Location = new System.Drawing.Point(15, 328);
            this.btnNovoProfessor.Name = "btnNovoProfessor";
            this.btnNovoProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnNovoProfessor.TabIndex = 6;
            this.btnNovoProfessor.Text = "Novo";
            this.btnNovoProfessor.UseVisualStyleBackColor = false;
            this.btnNovoProfessor.Click += new System.EventHandler(this.btnNovoProfessor_Click);
            // 
            // bntAlterarProfessor
            // 
            this.bntAlterarProfessor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntAlterarProfessor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntAlterarProfessor.Location = new System.Drawing.Point(96, 328);
            this.bntAlterarProfessor.Name = "bntAlterarProfessor";
            this.bntAlterarProfessor.Size = new System.Drawing.Size(75, 23);
            this.bntAlterarProfessor.TabIndex = 7;
            this.bntAlterarProfessor.Text = "Alterar";
            this.bntAlterarProfessor.UseVisualStyleBackColor = false;
            this.bntAlterarProfessor.Click += new System.EventHandler(this.btnNovoProfessor_Click);
            // 
            // btnExcluirProfessor
            // 
            this.btnExcluirProfessor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirProfessor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluirProfessor.Location = new System.Drawing.Point(177, 328);
            this.btnExcluirProfessor.Name = "btnExcluirProfessor";
            this.btnExcluirProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirProfessor.TabIndex = 8;
            this.btnExcluirProfessor.Text = "Excluir";
            this.btnExcluirProfessor.UseVisualStyleBackColor = false;
            this.btnExcluirProfessor.Click += new System.EventHandler(this.btnExcluirProfessor_Click);
            // 
            // btnAlterarAluno
            // 
            this.btnAlterarAluno.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlterarAluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterarAluno.Location = new System.Drawing.Point(369, 328);
            this.btnAlterarAluno.Name = "btnAlterarAluno";
            this.btnAlterarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarAluno.TabIndex = 9;
            this.btnAlterarAluno.Text = "Alterar";
            this.btnAlterarAluno.UseVisualStyleBackColor = false;
            this.btnAlterarAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // btnNovoAluno
            // 
            this.btnNovoAluno.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovoAluno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovoAluno.Location = new System.Drawing.Point(288, 328);
            this.btnNovoAluno.Name = "btnNovoAluno";
            this.btnNovoAluno.Size = new System.Drawing.Size(75, 23);
            this.btnNovoAluno.TabIndex = 10;
            this.btnNovoAluno.Text = "Novo";
            this.btnNovoAluno.UseVisualStyleBackColor = false;
            this.btnNovoAluno.Click += new System.EventHandler(this.btnNovoAluno_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirAluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluirAluno.Location = new System.Drawing.Point(450, 328);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAluno.TabIndex = 11;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = false;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnNovoModalidade
            // 
            this.btnNovoModalidade.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovoModalidade.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovoModalidade.Location = new System.Drawing.Point(555, 328);
            this.btnNovoModalidade.Name = "btnNovoModalidade";
            this.btnNovoModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnNovoModalidade.TabIndex = 12;
            this.btnNovoModalidade.Text = "Novo";
            this.btnNovoModalidade.UseVisualStyleBackColor = false;
            this.btnNovoModalidade.Click += new System.EventHandler(this.btnNovoModalidade_Click);
            // 
            // btnAlterarModalidade
            // 
            this.btnAlterarModalidade.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlterarModalidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterarModalidade.Location = new System.Drawing.Point(636, 328);
            this.btnAlterarModalidade.Name = "btnAlterarModalidade";
            this.btnAlterarModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarModalidade.TabIndex = 13;
            this.btnAlterarModalidade.Text = "Alterar";
            this.btnAlterarModalidade.UseVisualStyleBackColor = false;
            this.btnAlterarModalidade.Click += new System.EventHandler(this.btnNovoModalidade_Click);
            // 
            // btnExcluirModalidade
            // 
            this.btnExcluirModalidade.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluirModalidade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluirModalidade.Location = new System.Drawing.Point(717, 328);
            this.btnExcluirModalidade.Name = "btnExcluirModalidade";
            this.btnExcluirModalidade.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirModalidade.TabIndex = 14;
            this.btnExcluirModalidade.Text = "Excluir";
            this.btnExcluirModalidade.UseVisualStyleBackColor = false;
            this.btnExcluirModalidade.Click += new System.EventHandler(this.btnExcluirModalidade_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Modalidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Modalidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(827, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Relatórios";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(816, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Alunos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(816, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "Professores";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.Color.AliceBlue;
            this.button3.Location = new System.Drawing.Point(816, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 37);
            this.button3.TabIndex = 18;
            this.button3.Text = "Mensalidades";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(816, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 37);
            this.button4.TabIndex = 19;
            this.button4.Text = "Financeiro";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 373);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluirModalidade);
            this.Controls.Add(this.btnAlterarModalidade);
            this.Controls.Add(this.btnNovoModalidade);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnNovoAluno);
            this.Controls.Add(this.btnAlterarAluno);
            this.Controls.Add(this.btnExcluirProfessor);
            this.Controls.Add(this.bntAlterarProfessor);
            this.Controls.Add(this.btnNovoProfessor);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modalidadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.BindingSource pessoaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vezesSemanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource modalidadeBindingSource;
        private System.Windows.Forms.Button btnNovoProfessor;
        private System.Windows.Forms.Button bntAlterarProfessor;
        private System.Windows.Forms.Button btnExcluirProfessor;
        private System.Windows.Forms.Button btnAlterarAluno;
        private System.Windows.Forms.Button btnNovoAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnNovoModalidade;
        private System.Windows.Forms.Button btnAlterarModalidade;
        private System.Windows.Forms.Button btnExcluirModalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagou;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

