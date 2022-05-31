namespace TestsGenerator.TestModule
{
    partial class TestControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnRegisterTest = new System.Windows.Forms.ToolStripButton();
            this.BtnDuplicate = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnGeneratePDF = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.GridTests = new System.Windows.Forms.DataGridView();
            this.ClnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnBimester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTests)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(973, 50);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRegisterTest,
            this.BtnDuplicate,
            this.BtnDelete,
            this.toolStripSeparator1,
            this.BtnGeneratePDF,
            this.toolStripSeparator2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(971, 48);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnRegisterTest
            // 
            this.BtnRegisterTest.AutoSize = false;
            this.BtnRegisterTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRegisterTest.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegisterTest.Image")));
            this.BtnRegisterTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRegisterTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRegisterTest.Name = "BtnRegisterTest";
            this.BtnRegisterTest.Size = new System.Drawing.Size(50, 45);
            this.BtnRegisterTest.Text = "Cadastrar Teste";
            this.BtnRegisterTest.Click += new System.EventHandler(this.BtnRegisterTest_Click);
            // 
            // BtnDuplicate
            // 
            this.BtnDuplicate.AutoSize = false;
            this.BtnDuplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDuplicate.Image = ((System.Drawing.Image)(resources.GetObject("BtnDuplicate.Image")));
            this.BtnDuplicate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDuplicate.Name = "BtnDuplicate";
            this.BtnDuplicate.Size = new System.Drawing.Size(50, 45);
            this.BtnDuplicate.Text = "Duplicar Teste";
            this.BtnDuplicate.Click += new System.EventHandler(this.BtnDuplicate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = false;
            this.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(50, 45);
            this.BtnDelete.Text = "Deletar Teste";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDeleteTest_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // BtnGeneratePDF
            // 
            this.BtnGeneratePDF.AutoSize = false;
            this.BtnGeneratePDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnGeneratePDF.Image = ((System.Drawing.Image)(resources.GetObject("BtnGeneratePDF.Image")));
            this.BtnGeneratePDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnGeneratePDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGeneratePDF.Name = "BtnGeneratePDF";
            this.BtnGeneratePDF.Size = new System.Drawing.Size(50, 45);
            this.BtnGeneratePDF.Text = "Gerar PDF ";
            this.BtnGeneratePDF.Click += new System.EventHandler(this.BtnGeneratePDF_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(127, 45);
            this.toolStripLabel1.Text = "Testes Registrados";
            // 
            // GridTests
            // 
            this.GridTests.AllowUserToAddRows = false;
            this.GridTests.AllowUserToDeleteRows = false;
            this.GridTests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridTests.BackgroundColor = System.Drawing.Color.White;
            this.GridTests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridTests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridTests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridTests.ColumnHeadersHeight = 45;
            this.GridTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnId,
            this.ClnTestName,
            this.ClnGrade,
            this.ClnBimester,
            this.ClnDiscipline});
            this.GridTests.EnableHeadersVisualStyles = false;
            this.GridTests.GridColor = System.Drawing.Color.White;
            this.GridTests.Location = new System.Drawing.Point(34, 100);
            this.GridTests.Name = "GridTests";
            this.GridTests.ReadOnly = true;
            this.GridTests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridTests.RowHeadersVisible = false;
            this.GridTests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.GridTests.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GridTests.RowTemplate.Height = 35;
            this.GridTests.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridTests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridTests.Size = new System.Drawing.Size(973, 475);
            this.GridTests.TabIndex = 6;
            // 
            // ClnId
            // 
            this.ClnId.DataPropertyName = "Id";
            this.ClnId.HeaderText = "Identificador";
            this.ClnId.Name = "ClnId";
            this.ClnId.ReadOnly = true;
            this.ClnId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ClnTestName
            // 
            this.ClnTestName.DataPropertyName = "Name";
            this.ClnTestName.HeaderText = "Nome";
            this.ClnTestName.Name = "ClnTestName";
            this.ClnTestName.ReadOnly = true;
            this.ClnTestName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // ClnDiscipline
            // 
            this.ClnDiscipline.DataPropertyName = "Discipline";
            this.ClnDiscipline.HeaderText = "Disciplina";
            this.ClnDiscipline.Name = "ClnDiscipline";
            this.ClnDiscipline.ReadOnly = true;
            this.ClnDiscipline.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridTests);
            this.Controls.Add(this.panel1);
            this.Name = "TestControl";
            this.Size = new System.Drawing.Size(1041, 605);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton BtnRegisterTest;
        private ToolStripButton BtnDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton BtnGeneratePDF;
        private ToolStripSeparator toolStripSeparator2;
        private DataGridView GridTests;
        private ToolStripButton BtnDuplicate;
        private DataGridViewTextBoxColumn ClnId;
        private DataGridViewTextBoxColumn ClnTestName;
        private DataGridViewTextBoxColumn ClnGrade;
        private DataGridViewTextBoxColumn ClnBimester;
        private DataGridViewTextBoxColumn ClnDiscipline;
    }
}
