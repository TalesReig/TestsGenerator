namespace TestsGenerator.QuestionModule
{
    partial class QuestionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnRegisterQuestion = new System.Windows.Forms.ToolStripButton();
            this.BtnEditQuestion = new System.Windows.Forms.ToolStripButton();
            this.BtnDeleteQuestion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.GridQuestions = new System.Windows.Forms.DataGridView();
            this.ClnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnBimester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAddAlternatives = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(34, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 49);
            this.panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRegisterQuestion,
            this.BtnEditQuestion,
            this.BtnDeleteQuestion,
            this.BtnAddAlternatives,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(971, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnRegisterQuestion
            // 
            this.BtnRegisterQuestion.AutoSize = false;
            this.BtnRegisterQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRegisterQuestion.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegisterQuestion.Image")));
            this.BtnRegisterQuestion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRegisterQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRegisterQuestion.Name = "BtnRegisterQuestion";
            this.BtnRegisterQuestion.Size = new System.Drawing.Size(50, 45);
            this.BtnRegisterQuestion.Text = "Cadastrar Questão";
            this.BtnRegisterQuestion.Click += new System.EventHandler(this.BtnRegisterQuestion_Click);
            // 
            // BtnEditQuestion
            // 
            this.BtnEditQuestion.AutoSize = false;
            this.BtnEditQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEditQuestion.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditQuestion.Image")));
            this.BtnEditQuestion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnEditQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditQuestion.Name = "BtnEditQuestion";
            this.BtnEditQuestion.Size = new System.Drawing.Size(50, 45);
            this.BtnEditQuestion.Text = "Editar Questão";
            this.BtnEditQuestion.Click += new System.EventHandler(this.BtnEditQuestion_Click);
            // 
            // BtnDeleteQuestion
            // 
            this.BtnDeleteQuestion.AutoSize = false;
            this.BtnDeleteQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDeleteQuestion.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteQuestion.Image")));
            this.BtnDeleteQuestion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDeleteQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeleteQuestion.Name = "BtnDeleteQuestion";
            this.BtnDeleteQuestion.Size = new System.Drawing.Size(50, 45);
            this.BtnDeleteQuestion.Text = "Deletar Questão";
            this.BtnDeleteQuestion.Click += new System.EventHandler(this.BtnDeleteQuestion_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(146, 44);
            this.toolStripLabel1.Text = "Questões Registradas";
            // 
            // GridQuestions
            // 
            this.GridQuestions.AllowUserToAddRows = false;
            this.GridQuestions.AllowUserToDeleteRows = false;
            this.GridQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridQuestions.BackgroundColor = System.Drawing.Color.White;
            this.GridQuestions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridQuestions.ColumnHeadersHeight = 45;
            this.GridQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnId,
            this.ClnName,
            this.ClnGrade,
            this.ClnBimester,
            this.ClnMateria,
            this.ClnDiscipline});
            this.GridQuestions.EnableHeadersVisualStyles = false;
            this.GridQuestions.GridColor = System.Drawing.Color.White;
            this.GridQuestions.Location = new System.Drawing.Point(34, 100);
            this.GridQuestions.Name = "GridQuestions";
            this.GridQuestions.ReadOnly = true;
            this.GridQuestions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridQuestions.RowHeadersVisible = false;
            this.GridQuestions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.GridQuestions.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GridQuestions.RowTemplate.Height = 35;
            this.GridQuestions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridQuestions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridQuestions.Size = new System.Drawing.Size(973, 475);
            this.GridQuestions.TabIndex = 5;
            // 
            // ClnId
            // 
            this.ClnId.DataPropertyName = "Id";
            this.ClnId.HeaderText = "Identificador";
            this.ClnId.Name = "ClnId";
            this.ClnId.ReadOnly = true;
            this.ClnId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnName
            // 
            this.ClnName.DataPropertyName = "Description";
            this.ClnName.HeaderText = "Enunciado";
            this.ClnName.Name = "ClnName";
            this.ClnName.ReadOnly = true;
            this.ClnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnGrade
            // 
            this.ClnGrade.DataPropertyName = "Grade";
            this.ClnGrade.HeaderText = "Série";
            this.ClnGrade.Name = "ClnGrade";
            this.ClnGrade.ReadOnly = true;
            this.ClnGrade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnBimester
            // 
            this.ClnBimester.DataPropertyName = "Bimester";
            this.ClnBimester.HeaderText = "Bimestre";
            this.ClnBimester.Name = "ClnBimester";
            this.ClnBimester.ReadOnly = true;
            this.ClnBimester.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnMateria
            // 
            this.ClnMateria.DataPropertyName = "Materia";
            this.ClnMateria.HeaderText = "Matéria";
            this.ClnMateria.Name = "ClnMateria";
            this.ClnMateria.ReadOnly = true;
            // 
            // ClnDiscipline
            // 
            this.ClnDiscipline.DataPropertyName = "Discipline";
            this.ClnDiscipline.HeaderText = "Disciplina";
            this.ClnDiscipline.Name = "ClnDiscipline";
            this.ClnDiscipline.ReadOnly = true;
            this.ClnDiscipline.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BtnAddAlternatives
            // 
            this.BtnAddAlternatives.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAddAlternatives.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddAlternatives.Image")));
            this.BtnAddAlternatives.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnAddAlternatives.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAddAlternatives.Name = "BtnAddAlternatives";
            this.BtnAddAlternatives.Size = new System.Drawing.Size(28, 44);
            this.BtnAddAlternatives.Text = "toolStripButton1";
            this.BtnAddAlternatives.ToolTipText = "Adicionar Alternativas";
            this.BtnAddAlternatives.Click += new System.EventHandler(this.BtnAddAlternatives_Click);
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridQuestions);
            this.Controls.Add(this.panel1);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(1041, 605);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton BtnRegisterQuestion;
        private ToolStripButton BtnEditQuestion;
        private ToolStripButton BtnDeleteQuestion;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private DataGridView GridQuestions;
        private DataGridViewTextBoxColumn ClnId;
        private DataGridViewTextBoxColumn ClnName;
        private DataGridViewTextBoxColumn ClnGrade;
        private DataGridViewTextBoxColumn ClnBimester;
        private DataGridViewTextBoxColumn ClnMateria;
        private DataGridViewTextBoxColumn ClnDiscipline;
        private ToolStripButton BtnAddAlternatives;
    }
}
