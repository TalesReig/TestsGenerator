namespace TestsGenerator.MateriaModule
{
    partial class MateriaControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriaControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnRegisterMateria = new System.Windows.Forms.ToolStripButton();
            this.BtnEditMateria = new System.Windows.Forms.ToolStripButton();
            this.BtnDeleteMateria = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.GridMaterias = new System.Windows.Forms.DataGridView();
            this.ClnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnBimester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnDiscipline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMaterias)).BeginInit();
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
            this.panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRegisterMateria,
            this.BtnEditMateria,
            this.BtnDeleteMateria,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(971, 48);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnRegisterMateria
            // 
            this.BtnRegisterMateria.AutoSize = false;
            this.BtnRegisterMateria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRegisterMateria.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegisterMateria.Image")));
            this.BtnRegisterMateria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRegisterMateria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRegisterMateria.Name = "BtnRegisterMateria";
            this.BtnRegisterMateria.Size = new System.Drawing.Size(50, 45);
            this.BtnRegisterMateria.Text = "Cadastrar Matéria";
            this.BtnRegisterMateria.Click += new System.EventHandler(this.BtnRegisterMateria_Click);
            // 
            // BtnEditMateria
            // 
            this.BtnEditMateria.AutoSize = false;
            this.BtnEditMateria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEditMateria.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditMateria.Image")));
            this.BtnEditMateria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnEditMateria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditMateria.Name = "BtnEditMateria";
            this.BtnEditMateria.Size = new System.Drawing.Size(50, 45);
            this.BtnEditMateria.Text = "Editar Matéria";
            this.BtnEditMateria.Click += new System.EventHandler(this.BtnEditMateria_Click);
            // 
            // BtnDeleteMateria
            // 
            this.BtnDeleteMateria.AutoSize = false;
            this.BtnDeleteMateria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDeleteMateria.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteMateria.Image")));
            this.BtnDeleteMateria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDeleteMateria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeleteMateria.Name = "BtnDeleteMateria";
            this.BtnDeleteMateria.Size = new System.Drawing.Size(50, 45);
            this.BtnDeleteMateria.Text = "Deletar Matéria";
            this.BtnDeleteMateria.Click += new System.EventHandler(this.BtnDeleteMateria_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(144, 45);
            this.toolStripLabel1.Text = "Matérias Registradas";
            // 
            // GridMaterias
            // 
            this.GridMaterias.AllowUserToAddRows = false;
            this.GridMaterias.AllowUserToDeleteRows = false;
            this.GridMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMaterias.BackgroundColor = System.Drawing.Color.White;
            this.GridMaterias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridMaterias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridMaterias.ColumnHeadersHeight = 45;
            this.GridMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnId,
            this.ClnName,
            this.ClnGrade,
            this.ClnBimester,
            this.ClnDiscipline});
            this.GridMaterias.EnableHeadersVisualStyles = false;
            this.GridMaterias.GridColor = System.Drawing.Color.White;
            this.GridMaterias.Location = new System.Drawing.Point(34, 100);
            this.GridMaterias.Name = "GridMaterias";
            this.GridMaterias.ReadOnly = true;
            this.GridMaterias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridMaterias.RowHeadersVisible = false;
            this.GridMaterias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.GridMaterias.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridMaterias.RowTemplate.Height = 35;
            this.GridMaterias.RowTemplate.ReadOnly = true;
            this.GridMaterias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMaterias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMaterias.Size = new System.Drawing.Size(973, 475);
            this.GridMaterias.TabIndex = 4;
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
            this.ClnName.DataPropertyName = "Name";
            this.ClnName.HeaderText = "Nome";
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
            // ClnDiscipline
            // 
            this.ClnDiscipline.DataPropertyName = "Discipline";
            this.ClnDiscipline.HeaderText = "Disciplina";
            this.ClnDiscipline.Name = "ClnDiscipline";
            this.ClnDiscipline.ReadOnly = true;
            this.ClnDiscipline.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MateriaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridMaterias);
            this.Controls.Add(this.panel1);
            this.Name = "MateriaControl";
            this.Size = new System.Drawing.Size(1041, 605);
            this.Load += new System.EventHandler(this.MateriaControl_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton BtnRegisterMateria;
        private ToolStripButton BtnEditMateria;
        private ToolStripButton BtnDeleteMateria;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private DataGridView GridMaterias;
        private DataGridViewTextBoxColumn ClnId;
        private DataGridViewTextBoxColumn ClnName;
        private DataGridViewTextBoxColumn ClnGrade;
        private DataGridViewTextBoxColumn ClnBimester;
        private DataGridViewTextBoxColumn ClnDiscipline;
    }
}
