namespace TestsGenerator.DisciplineModule
{
    partial class DisciplineControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisciplineControl));
            this.GridDisciplines = new System.Windows.Forms.DataGridView();
            this.ClnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnRegisterDiscipline = new System.Windows.Forms.ToolStripButton();
            this.BtnEditDiscipline = new System.Windows.Forms.ToolStripButton();
            this.BtnDeleteDiscipline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridDisciplines)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridDisciplines
            // 
            this.GridDisciplines.AllowUserToAddRows = false;
            this.GridDisciplines.AllowUserToDeleteRows = false;
            this.GridDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridDisciplines.BackgroundColor = System.Drawing.Color.White;
            this.GridDisciplines.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridDisciplines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDisciplines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridDisciplines.ColumnHeadersHeight = 45;
            this.GridDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridDisciplines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnId,
            this.ClnName});
            this.GridDisciplines.EnableHeadersVisualStyles = false;
            this.GridDisciplines.GridColor = System.Drawing.Color.White;
            this.GridDisciplines.Location = new System.Drawing.Point(34, 100);
            this.GridDisciplines.Name = "GridDisciplines";
            this.GridDisciplines.ReadOnly = true;
            this.GridDisciplines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridDisciplines.RowHeadersVisible = false;
            this.GridDisciplines.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.GridDisciplines.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GridDisciplines.RowTemplate.Height = 35;
            this.GridDisciplines.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDisciplines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GridDisciplines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDisciplines.Size = new System.Drawing.Size(973, 475);
            this.GridDisciplines.TabIndex = 3;
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
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRegisterDiscipline,
            this.BtnEditDiscipline,
            this.BtnDeleteDiscipline,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(971, 48);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnRegisterDiscipline
            // 
            this.BtnRegisterDiscipline.AutoSize = false;
            this.BtnRegisterDiscipline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRegisterDiscipline.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegisterDiscipline.Image")));
            this.BtnRegisterDiscipline.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRegisterDiscipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRegisterDiscipline.Name = "BtnRegisterDiscipline";
            this.BtnRegisterDiscipline.Size = new System.Drawing.Size(50, 45);
            this.BtnRegisterDiscipline.Text = "Cadastrar Disciplina";
            this.BtnRegisterDiscipline.Click += new System.EventHandler(this.BtnRegisterDiscipline_Click);
            // 
            // BtnEditDiscipline
            // 
            this.BtnEditDiscipline.AutoSize = false;
            this.BtnEditDiscipline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEditDiscipline.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditDiscipline.Image")));
            this.BtnEditDiscipline.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnEditDiscipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditDiscipline.Name = "BtnEditDiscipline";
            this.BtnEditDiscipline.Size = new System.Drawing.Size(50, 45);
            this.BtnEditDiscipline.Text = "Editar Disciplina";
            this.BtnEditDiscipline.Click += new System.EventHandler(this.BtnEditDiscipline_Click);
            // 
            // BtnDeleteDiscipline
            // 
            this.BtnDeleteDiscipline.AutoSize = false;
            this.BtnDeleteDiscipline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDeleteDiscipline.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteDiscipline.Image")));
            this.BtnDeleteDiscipline.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDeleteDiscipline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeleteDiscipline.Name = "BtnDeleteDiscipline";
            this.BtnDeleteDiscipline.Size = new System.Drawing.Size(50, 45);
            this.BtnDeleteDiscipline.Text = "Deletar Disciplina";
            this.BtnDeleteDiscipline.Click += new System.EventHandler(this.BtnDeleteDiscipline_Click);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(157, 45);
            this.toolStripLabel1.Text = "Disciplinas Registradas";
            // 
            // DisciplineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridDisciplines);
            this.Controls.Add(this.panel1);
            this.Name = "DisciplineControl";
            this.Size = new System.Drawing.Size(1041, 605);
            this.Load += new System.EventHandler(this.DisciplineControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDisciplines)).EndInit();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripButton BtnRegisterDiscipline;
        private ToolStripButton BtnEditDiscipline;
        private ToolStripButton BtnDeleteDiscipline;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private DataGridView GridDisciplines;
        private DataGridViewTextBoxColumn ClnId;
        private DataGridViewTextBoxColumn ClnName;
    }
}
