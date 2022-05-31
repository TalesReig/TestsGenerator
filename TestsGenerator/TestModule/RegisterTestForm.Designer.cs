namespace TestsGenerator.TestModule
{
    partial class RegisterTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterTestForm));
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxBimester = new System.Windows.Forms.ComboBox();
            this.CbxDiscipline = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxMateria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbxGrade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxbTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClbxAvailableQuestions = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRegister
            // 
            this.BtnRegister.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnRegister.Location = new System.Drawing.Point(88, 524);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(114, 45);
            this.BtnRegister.TabIndex = 5;
            this.BtnRegister.Text = "Cadastrar";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(230, 524);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(114, 45);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(74, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 60);
            this.panel1.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.CausesValidation = false;
            this.label10.Location = new System.Drawing.Point(5, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(326, 47);
            this.label10.TabIndex = 0;
            this.label10.Text = "Após finalizar a criação do teste, na listagem de testes, selecione o teste que d" +
    "eseja gerar o pdf e clique no botão com o simbolo PDF para gerar o arquivo do te" +
    "ste.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CbxBimester);
            this.panel2.Controls.Add(this.CbxDiscipline);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CbxMateria);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.CbxGrade);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TxbTitle);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(26, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 174);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bimestre:";
            // 
            // CbxBimester
            // 
            this.CbxBimester.DisplayMember = "Bimester";
            this.CbxBimester.FormattingEnabled = true;
            this.CbxBimester.Location = new System.Drawing.Point(265, 94);
            this.CbxBimester.Name = "CbxBimester";
            this.CbxBimester.Size = new System.Drawing.Size(98, 23);
            this.CbxBimester.TabIndex = 13;
            this.CbxBimester.SelectedIndexChanged += new System.EventHandler(this.CbxBimester_SelectedIndexChanged);
            // 
            // CbxDiscipline
            // 
            this.CbxDiscipline.DisplayMember = "Name";
            this.CbxDiscipline.FormattingEnabled = true;
            this.CbxDiscipline.Location = new System.Drawing.Point(82, 56);
            this.CbxDiscipline.Name = "CbxDiscipline";
            this.CbxDiscipline.Size = new System.Drawing.Size(281, 23);
            this.CbxDiscipline.TabIndex = 12;
            this.CbxDiscipline.SelectedIndexChanged += new System.EventHandler(this.CbxDiscipline_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Série:";
            // 
            // CbxMateria
            // 
            this.CbxMateria.DisplayMember = "Name";
            this.CbxMateria.FormattingEnabled = true;
            this.CbxMateria.Location = new System.Drawing.Point(117, 131);
            this.CbxMateria.Name = "CbxMateria";
            this.CbxMateria.Size = new System.Drawing.Size(246, 23);
            this.CbxMateria.TabIndex = 6;
            this.CbxMateria.SelectedIndexChanged += new System.EventHandler(this.CbxMateria_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Matéria do Teste:";
            // 
            // CbxGrade
            // 
            this.CbxGrade.DisplayMember = "Grade";
            this.CbxGrade.FormattingEnabled = true;
            this.CbxGrade.Location = new System.Drawing.Point(56, 94);
            this.CbxGrade.Name = "CbxGrade";
            this.CbxGrade.Size = new System.Drawing.Size(93, 23);
            this.CbxGrade.TabIndex = 4;
            this.CbxGrade.SelectedIndexChanged += new System.EventHandler(this.CbxGrade_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Disciplina:";
            // 
            // TxbTitle
            // 
            this.TxbTitle.Location = new System.Drawing.Point(61, 17);
            this.TxbTitle.Name = "TxbTitle";
            this.TxbTitle.Size = new System.Drawing.Size(302, 23);
            this.TxbTitle.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Título:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Configurações";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Questões Disponíveis";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ClbxAvailableQuestions);
            this.panel3.Location = new System.Drawing.Point(26, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 198);
            this.panel3.TabIndex = 11;
            // 
            // ClbxAvailableQuestions
            // 
            this.ClbxAvailableQuestions.CheckOnClick = true;
            this.ClbxAvailableQuestions.FormattingEnabled = true;
            this.ClbxAvailableQuestions.Location = new System.Drawing.Point(4, 8);
            this.ClbxAvailableQuestions.Name = "ClbxAvailableQuestions";
            this.ClbxAvailableQuestions.Size = new System.Drawing.Size(376, 184);
            this.ClbxAvailableQuestions.TabIndex = 0;
            // 
            // RegisterTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(436, 589);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Novo Teste";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button BtnRegister;
        private Button BtnCancel;
        private Panel panel1;
        private Label label10;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ComboBox CbxGrade;
        private Label label6;
        private TextBox TxbTitle;
        private Label label3;
        private Label label2;
        private ComboBox CbxMateria;
        private Label label7;
        private Label label9;
        private Panel panel3;
        private ComboBox CbxDiscipline;
        private Label label4;
        private Label label5;
        private ComboBox CbxBimester;
        private CheckedListBox ClbxAvailableQuestions;
    }
}