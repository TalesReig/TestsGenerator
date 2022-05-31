namespace TestsGenerator.MateriaModule
{
    partial class RegisterMateriaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterMateriaForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CbxDiscipline = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxBimester = new System.Windows.Forms.ComboBox();
            this.TxbGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nova Matéria";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CbxDiscipline);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CbxBimester);
            this.panel2.Controls.Add(this.TxbGrade);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TxbName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(23, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 160);
            this.panel2.TabIndex = 11;
            // 
            // CbxDiscipline
            // 
            this.CbxDiscipline.DisplayMember = "Name";
            this.CbxDiscipline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDiscipline.FormattingEnabled = true;
            this.CbxDiscipline.Location = new System.Drawing.Point(77, 118);
            this.CbxDiscipline.Name = "CbxDiscipline";
            this.CbxDiscipline.Size = new System.Drawing.Size(121, 23);
            this.CbxDiscipline.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Disciplina:";
            // 
            // CbxBimester
            // 
            this.CbxBimester.DisplayMember = "Bimester";
            this.CbxBimester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxBimester.FormattingEnabled = true;
            this.CbxBimester.Location = new System.Drawing.Point(77, 83);
            this.CbxBimester.Name = "CbxBimester";
            this.CbxBimester.Size = new System.Drawing.Size(121, 23);
            this.CbxBimester.TabIndex = 12;
            // 
            // TxbGrade
            // 
            this.TxbGrade.Location = new System.Drawing.Point(56, 49);
            this.TxbGrade.Name = "TxbGrade";
            this.TxbGrade.Size = new System.Drawing.Size(142, 23);
            this.TxbGrade.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bimestre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Série:";
            // 
            // TxbName
            // 
            this.TxbName.Location = new System.Drawing.Point(64, 16);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(302, 23);
            this.TxbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(231, 208);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(114, 45);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnRegister
            // 
            this.BtnRegister.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnRegister.Location = new System.Drawing.Point(89, 208);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(114, 45);
            this.BtnRegister.TabIndex = 13;
            this.BtnRegister.Text = "Cadastrar";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // RegisterMateriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(432, 272);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterMateriaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrando Matéria";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel2;
        private ComboBox CbxBimester;
        private TextBox TxbGrade;
        private Label label4;
        private Label label3;
        private TextBox TxbName;
        private Label label2;
        private Button BtnCancel;
        private Button BtnRegister;
        private ComboBox CbxDiscipline;
        private Label label5;
    }
}