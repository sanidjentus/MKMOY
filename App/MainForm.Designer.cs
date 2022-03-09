
namespace App
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.selectN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iValueBox = new System.Windows.Forms.TextBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.qDoneLabel = new System.Windows.Forms.Label();
            this.qLabel = new System.Windows.Forms.Label();
            this.qValueBox = new System.Windows.Forms.TextBox();
            this.qCheckBox = new System.Windows.Forms.CheckBox();
            this.iDoneLabel = new System.Windows.Forms.Label();
            this.iNameLabel = new System.Windows.Forms.Label();
            this.iCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lipBox1 = new System.Windows.Forms.TextBox();
            this.l1Name = new System.Windows.Forms.Label();
            this.lipBox0 = new System.Windows.Forms.TextBox();
            this.l1Check = new System.Windows.Forms.CheckBox();
            this.l0Check = new System.Windows.Forms.CheckBox();
            this.errMsgL = new System.Windows.Forms.Label();
            this.l0Name = new System.Windows.Forms.Label();
            this.lambdaRootsBox = new System.Windows.Forms.GroupBox();
            this.rootBox2 = new System.Windows.Forms.TextBox();
            this.root2 = new System.Windows.Forms.Label();
            this.rootBox1 = new System.Windows.Forms.TextBox();
            this.root1 = new System.Windows.Forms.Label();
            this.rootStateLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sigmasTable = new System.Windows.Forms.GroupBox();
            this.kBox3 = new System.Windows.Forms.TextBox();
            this.sigmaBox3 = new System.Windows.Forms.TextBox();
            this.kLabel3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kBox2 = new System.Windows.Forms.TextBox();
            this.sigmaBox2 = new System.Windows.Forms.TextBox();
            this.kLabel2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kBox1 = new System.Windows.Forms.TextBox();
            this.sigmaBox1 = new System.Windows.Forms.TextBox();
            this.kLabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iBlockLabel = new System.Windows.Forms.Label();
            this.formulaPic1 = new System.Windows.Forms.PictureBox();
            this.formulaPic2 = new System.Windows.Forms.PictureBox();
            this.diffurPic2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.diffurPic1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.coeff1TextBox = new System.Windows.Forms.TextBox();
            this.coeff2TextBox = new System.Windows.Forms.TextBox();
            this.coeff1Name = new System.Windows.Forms.Label();
            this.coeff2Name = new System.Windows.Forms.Label();
            this.checkCoeff1 = new System.Windows.Forms.CheckBox();
            this.checkCoeff2 = new System.Windows.Forms.CheckBox();
            this.errMsg = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.qualityBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.lambdaRootsBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sigmasTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulaPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulaPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diffurPic2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diffurPic1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Tan;
            this.TopPanel.Controls.Add(this.qualityBox);
            this.TopPanel.Controls.Add(this.selectN);
            this.TopPanel.Controls.Add(this.label3);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(725, 37);
            this.TopPanel.TabIndex = 0;
            // 
            // selectN
            // 
            this.selectN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.selectN.FormattingEnabled = true;
            this.selectN.Location = new System.Drawing.Point(240, 8);
            this.selectN.Name = "selectN";
            this.selectN.Size = new System.Drawing.Size(227, 21);
            this.selectN.TabIndex = 1;
            this.selectN.Text = "Порядок Диффура";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Порядок дифференциального уравнения";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.MainPanel.Controls.Add(this.panel5);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 37);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(725, 412);
            this.MainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 45);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(177, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Проверить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.iValueBox);
            this.groupBox2.Controls.Add(this.AnswerLabel);
            this.groupBox2.Controls.Add(this.qDoneLabel);
            this.groupBox2.Controls.Add(this.qLabel);
            this.groupBox2.Controls.Add(this.qValueBox);
            this.groupBox2.Controls.Add(this.qCheckBox);
            this.groupBox2.Controls.Add(this.iDoneLabel);
            this.groupBox2.Controls.Add(this.iNameLabel);
            this.groupBox2.Controls.Add(this.iCheckBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(0, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Основные условия";
            // 
            // iValueBox
            // 
            this.iValueBox.Location = new System.Drawing.Point(240, 47);
            this.iValueBox.Name = "iValueBox";
            this.iValueBox.ReadOnly = true;
            this.iValueBox.Size = new System.Drawing.Size(79, 22);
            this.iValueBox.TabIndex = 1;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerLabel.ForeColor = System.Drawing.Color.Red;
            this.AnswerLabel.Location = new System.Drawing.Point(8, 70);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(355, 47);
            this.AnswerLabel.TabIndex = 2;
            this.AnswerLabel.Text = "Итог";
            // 
            // qDoneLabel
            // 
            this.qDoneLabel.AutoSize = true;
            this.qDoneLabel.Location = new System.Drawing.Point(140, 24);
            this.qDoneLabel.Name = "qDoneLabel";
            this.qDoneLabel.Size = new System.Drawing.Size(77, 13);
            this.qDoneLabel.TabIndex = 0;
            this.qDoneLabel.Text = "ВЫПОЛНЕНО";
            // 
            // qLabel
            // 
            this.qLabel.AutoSize = true;
            this.qLabel.Location = new System.Drawing.Point(6, 24);
            this.qLabel.Name = "qLabel";
            this.qLabel.Size = new System.Drawing.Size(109, 13);
            this.qLabel.TabIndex = 0;
            this.qLabel.Text = "Частотное условие";
            // 
            // qValueBox
            // 
            this.qValueBox.Location = new System.Drawing.Point(240, 21);
            this.qValueBox.Name = "qValueBox";
            this.qValueBox.ReadOnly = true;
            this.qValueBox.Size = new System.Drawing.Size(79, 22);
            this.qValueBox.TabIndex = 1;
            // 
            // qCheckBox
            // 
            this.qCheckBox.AutoCheck = false;
            this.qCheckBox.AutoSize = true;
            this.qCheckBox.Location = new System.Drawing.Point(323, 24);
            this.qCheckBox.Name = "qCheckBox";
            this.qCheckBox.Size = new System.Drawing.Size(15, 14);
            this.qCheckBox.TabIndex = 3;
            this.qCheckBox.UseVisualStyleBackColor = true;
            // 
            // iDoneLabel
            // 
            this.iDoneLabel.AutoSize = true;
            this.iDoneLabel.Location = new System.Drawing.Point(140, 51);
            this.iDoneLabel.Name = "iDoneLabel";
            this.iDoneLabel.Size = new System.Drawing.Size(77, 13);
            this.iDoneLabel.TabIndex = 0;
            this.iDoneLabel.Text = "ВЫПОЛНЕНО";
            // 
            // iNameLabel
            // 
            this.iNameLabel.Location = new System.Drawing.Point(6, 51);
            this.iNameLabel.Name = "iNameLabel";
            this.iNameLabel.Size = new System.Drawing.Size(133, 23);
            this.iNameLabel.TabIndex = 0;
            this.iNameLabel.Text = "Итегральное условие";
            // 
            // iCheckBox
            // 
            this.iCheckBox.AutoCheck = false;
            this.iCheckBox.AutoSize = true;
            this.iCheckBox.Location = new System.Drawing.Point(323, 50);
            this.iCheckBox.Name = "iCheckBox";
            this.iCheckBox.Size = new System.Drawing.Size(15, 14);
            this.iCheckBox.TabIndex = 3;
            this.iCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lipBox1);
            this.groupBox1.Controls.Add(this.l1Name);
            this.groupBox1.Controls.Add(this.lipBox0);
            this.groupBox1.Controls.Add(this.l1Check);
            this.groupBox1.Controls.Add(this.l0Check);
            this.groupBox1.Controls.Add(this.errMsgL);
            this.groupBox1.Controls.Add(this.l0Name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Постоянные Липшеца";
            // 
            // lipBox1
            // 
            this.lipBox1.Location = new System.Drawing.Point(196, 34);
            this.lipBox1.Name = "lipBox1";
            this.lipBox1.Size = new System.Drawing.Size(123, 22);
            this.lipBox1.TabIndex = 1;
            this.lipBox1.TextChanged += new System.EventHandler(this.lipBox1_TextChanged);
            // 
            // l1Name
            // 
            this.l1Name.AutoSize = true;
            this.l1Name.Location = new System.Drawing.Point(193, 18);
            this.l1Name.Name = "l1Name";
            this.l1Name.Size = new System.Drawing.Size(16, 13);
            this.l1Name.TabIndex = 0;
            this.l1Name.Text = "L1";
            // 
            // lipBox0
            // 
            this.lipBox0.Location = new System.Drawing.Point(23, 34);
            this.lipBox0.Name = "lipBox0";
            this.lipBox0.Size = new System.Drawing.Size(123, 22);
            this.lipBox0.TabIndex = 1;
            this.lipBox0.TextChanged += new System.EventHandler(this.lipBox0_TextChanged);
            // 
            // l1Check
            // 
            this.l1Check.AutoCheck = false;
            this.l1Check.AutoSize = true;
            this.l1Check.Location = new System.Drawing.Point(325, 37);
            this.l1Check.Name = "l1Check";
            this.l1Check.Size = new System.Drawing.Size(15, 14);
            this.l1Check.TabIndex = 3;
            this.l1Check.UseVisualStyleBackColor = true;
            // 
            // l0Check
            // 
            this.l0Check.AutoCheck = false;
            this.l0Check.AutoSize = true;
            this.l0Check.Location = new System.Drawing.Point(152, 37);
            this.l0Check.Name = "l0Check";
            this.l0Check.Size = new System.Drawing.Size(15, 14);
            this.l0Check.TabIndex = 3;
            this.l0Check.UseVisualStyleBackColor = true;
            // 
            // errMsgL
            // 
            this.errMsgL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.errMsgL.AutoSize = true;
            this.errMsgL.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.errMsgL.ForeColor = System.Drawing.Color.Red;
            this.errMsgL.Location = new System.Drawing.Point(20, 60);
            this.errMsgL.Name = "errMsgL";
            this.errMsgL.Size = new System.Drawing.Size(58, 15);
            this.errMsgL.TabIndex = 2;
            this.errMsgL.Text = "ОШИБКА";
            this.errMsgL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // l0Name
            // 
            this.l0Name.AutoSize = true;
            this.l0Name.Location = new System.Drawing.Point(20, 18);
            this.l0Name.Name = "l0Name";
            this.l0Name.Size = new System.Drawing.Size(18, 13);
            this.l0Name.TabIndex = 0;
            this.l0Name.Text = "L0";
            // 
            // lambdaRootsBox
            // 
            this.lambdaRootsBox.BackColor = System.Drawing.Color.Moccasin;
            this.lambdaRootsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lambdaRootsBox.Controls.Add(this.rootBox2);
            this.lambdaRootsBox.Controls.Add(this.root2);
            this.lambdaRootsBox.Controls.Add(this.rootBox1);
            this.lambdaRootsBox.Controls.Add(this.root1);
            this.lambdaRootsBox.Controls.Add(this.rootStateLabel);
            this.lambdaRootsBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lambdaRootsBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lambdaRootsBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lambdaRootsBox.Location = new System.Drawing.Point(0, 79);
            this.lambdaRootsBox.Name = "lambdaRootsBox";
            this.lambdaRootsBox.Size = new System.Drawing.Size(369, 81);
            this.lambdaRootsBox.TabIndex = 1;
            this.lambdaRootsBox.TabStop = false;
            this.lambdaRootsBox.Text = "Корни характеристического уравнения";
            // 
            // rootBox2
            // 
            this.rootBox2.Location = new System.Drawing.Point(196, 34);
            this.rootBox2.Name = "rootBox2";
            this.rootBox2.ReadOnly = true;
            this.rootBox2.Size = new System.Drawing.Size(123, 22);
            this.rootBox2.TabIndex = 1;
            // 
            // root2
            // 
            this.root2.AutoSize = true;
            this.root2.Location = new System.Drawing.Point(193, 18);
            this.root2.Name = "root2";
            this.root2.Size = new System.Drawing.Size(47, 13);
            this.root2.TabIndex = 0;
            this.root2.Text = "Корень";
            // 
            // rootBox1
            // 
            this.rootBox1.Location = new System.Drawing.Point(23, 34);
            this.rootBox1.Name = "rootBox1";
            this.rootBox1.ReadOnly = true;
            this.rootBox1.Size = new System.Drawing.Size(123, 22);
            this.rootBox1.TabIndex = 1;
            // 
            // root1
            // 
            this.root1.AutoSize = true;
            this.root1.Location = new System.Drawing.Point(20, 18);
            this.root1.Name = "root1";
            this.root1.Size = new System.Drawing.Size(47, 13);
            this.root1.TabIndex = 0;
            this.root1.Text = "Корень";
            // 
            // rootStateLabel
            // 
            this.rootStateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rootStateLabel.AutoSize = true;
            this.rootStateLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.rootStateLabel.ForeColor = System.Drawing.Color.Green;
            this.rootStateLabel.Location = new System.Drawing.Point(20, 59);
            this.rootStateLabel.Name = "rootStateLabel";
            this.rootStateLabel.Size = new System.Drawing.Size(58, 15);
            this.rootStateLabel.TabIndex = 2;
            this.rootStateLabel.Text = "ОШИБКА";
            this.rootStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.formulaPic1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.formulaPic2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(369, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 412);
            this.panel1.TabIndex = 0;
            // 
            // sigmasTable
            // 
            this.sigmasTable.BackColor = System.Drawing.Color.PapayaWhip;
            this.sigmasTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sigmasTable.Controls.Add(this.kBox3);
            this.sigmasTable.Controls.Add(this.sigmaBox3);
            this.sigmasTable.Controls.Add(this.kLabel3);
            this.sigmasTable.Controls.Add(this.label4);
            this.sigmasTable.Controls.Add(this.kBox2);
            this.sigmasTable.Controls.Add(this.sigmaBox2);
            this.sigmasTable.Controls.Add(this.kLabel2);
            this.sigmasTable.Controls.Add(this.label5);
            this.sigmasTable.Controls.Add(this.kBox1);
            this.sigmasTable.Controls.Add(this.sigmaBox1);
            this.sigmasTable.Controls.Add(this.kLabel1);
            this.sigmasTable.Controls.Add(this.label6);
            this.sigmasTable.Controls.Add(this.label2);
            this.sigmasTable.Controls.Add(this.iBlockLabel);
            this.sigmasTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sigmasTable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sigmasTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sigmasTable.Location = new System.Drawing.Point(0, 0);
            this.sigmasTable.Name = "sigmasTable";
            this.sigmasTable.Size = new System.Drawing.Size(352, 147);
            this.sigmasTable.TabIndex = 1;
            this.sigmasTable.TabStop = false;
            this.sigmasTable.Text = "Найденные величины";
            // 
            // kBox3
            // 
            this.kBox3.Location = new System.Drawing.Point(230, 108);
            this.kBox3.Name = "kBox3";
            this.kBox3.ReadOnly = true;
            this.kBox3.Size = new System.Drawing.Size(108, 22);
            this.kBox3.TabIndex = 1;
            // 
            // sigmaBox3
            // 
            this.sigmaBox3.Location = new System.Drawing.Point(230, 50);
            this.sigmaBox3.Name = "sigmaBox3";
            this.sigmaBox3.ReadOnly = true;
            this.sigmaBox3.Size = new System.Drawing.Size(108, 22);
            this.sigmaBox3.TabIndex = 1;
            // 
            // kLabel3
            // 
            this.kLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kLabel3.Location = new System.Drawing.Point(230, 92);
            this.kLabel3.Name = "kLabel3";
            this.kLabel3.Size = new System.Drawing.Size(100, 23);
            this.kLabel3.TabIndex = 0;
            this.kLabel3.Text = "k";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(230, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "s2";
            // 
            // kBox2
            // 
            this.kBox2.Location = new System.Drawing.Point(118, 108);
            this.kBox2.Name = "kBox2";
            this.kBox2.ReadOnly = true;
            this.kBox2.Size = new System.Drawing.Size(108, 22);
            this.kBox2.TabIndex = 1;
            // 
            // sigmaBox2
            // 
            this.sigmaBox2.Location = new System.Drawing.Point(118, 50);
            this.sigmaBox2.Name = "sigmaBox2";
            this.sigmaBox2.ReadOnly = true;
            this.sigmaBox2.Size = new System.Drawing.Size(108, 22);
            this.sigmaBox2.TabIndex = 1;
            // 
            // kLabel2
            // 
            this.kLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kLabel2.Location = new System.Drawing.Point(118, 92);
            this.kLabel2.Name = "kLabel2";
            this.kLabel2.Size = new System.Drawing.Size(100, 23);
            this.kLabel2.TabIndex = 0;
            this.kLabel2.Text = "k";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(118, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "s1";
            // 
            // kBox1
            // 
            this.kBox1.Location = new System.Drawing.Point(6, 108);
            this.kBox1.Name = "kBox1";
            this.kBox1.ReadOnly = true;
            this.kBox1.Size = new System.Drawing.Size(108, 22);
            this.kBox1.TabIndex = 1;
            // 
            // sigmaBox1
            // 
            this.sigmaBox1.Location = new System.Drawing.Point(6, 50);
            this.sigmaBox1.Name = "sigmaBox1";
            this.sigmaBox1.ReadOnly = true;
            this.sigmaBox1.Size = new System.Drawing.Size(108, 22);
            this.sigmaBox1.TabIndex = 1;
            // 
            // kLabel1
            // 
            this.kLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kLabel1.Location = new System.Drawing.Point(6, 92);
            this.kLabel1.Name = "kLabel1";
            this.kLabel1.Size = new System.Drawing.Size(100, 23);
            this.kLabel1.TabIndex = 0;
            this.kLabel1.Text = "k";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "s0";
            // 
            // iBlockLabel
            // 
            this.iBlockLabel.Location = new System.Drawing.Point(6, 76);
            this.iBlockLabel.Name = "iBlockLabel";
            this.iBlockLabel.Size = new System.Drawing.Size(157, 23);
            this.iBlockLabel.TabIndex = 0;
            this.iBlockLabel.Text = "Интегральные постоянные:";
            // 
            // formulaPic1
            // 
            this.formulaPic1.Image = ((System.Drawing.Image)(resources.GetObject("formulaPic1.Image")));
            this.formulaPic1.ImageLocation = "";
            this.formulaPic1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.formulaPic1.InitialImage = null;
            this.formulaPic1.Location = new System.Drawing.Point(1, 243);
            this.formulaPic1.Name = "formulaPic1";
            this.formulaPic1.Size = new System.Drawing.Size(217, 74);
            this.formulaPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formulaPic1.TabIndex = 2;
            this.formulaPic1.TabStop = false;
            // 
            // formulaPic2
            // 
            this.formulaPic2.Image = ((System.Drawing.Image)(resources.GetObject("formulaPic2.Image")));
            this.formulaPic2.ImageLocation = "";
            this.formulaPic2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.formulaPic2.InitialImage = null;
            this.formulaPic2.Location = new System.Drawing.Point(1, 243);
            this.formulaPic2.Name = "formulaPic2";
            this.formulaPic2.Size = new System.Drawing.Size(217, 165);
            this.formulaPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.formulaPic2.TabIndex = 2;
            this.formulaPic2.TabStop = false;
            // 
            // diffurPic2
            // 
            this.diffurPic2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffurPic2.Image = ((System.Drawing.Image)(resources.GetObject("diffurPic2.Image")));
            this.diffurPic2.ImageLocation = "";
            this.diffurPic2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.diffurPic2.InitialImage = null;
            this.diffurPic2.Location = new System.Drawing.Point(0, 0);
            this.diffurPic2.Name = "diffurPic2";
            this.diffurPic2.Size = new System.Drawing.Size(352, 97);
            this.diffurPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diffurPic2.TabIndex = 2;
            this.diffurPic2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.diffurPic1);
            this.panel3.Controls.Add(this.diffurPic2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 97);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sigmasTable);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 147);
            this.panel4.TabIndex = 4;
            // 
            // diffurPic1
            // 
            this.diffurPic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffurPic1.Image = ((System.Drawing.Image)(resources.GetObject("diffurPic1.Image")));
            this.diffurPic1.ImageLocation = "";
            this.diffurPic1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.diffurPic1.InitialImage = null;
            this.diffurPic1.Location = new System.Drawing.Point(0, 0);
            this.diffurPic1.Name = "diffurPic1";
            this.diffurPic1.Size = new System.Drawing.Size(352, 97);
            this.diffurPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diffurPic1.TabIndex = 3;
            this.diffurPic1.TabStop = false;
            // 
            // label2
            // 
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(4, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Частотные постоянные:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox3.Controls.Add(this.checkCoeff2);
            this.groupBox3.Controls.Add(this.checkCoeff1);
            this.groupBox3.Controls.Add(this.coeff2Name);
            this.groupBox3.Controls.Add(this.coeff1Name);
            this.groupBox3.Controls.Add(this.coeff2TextBox);
            this.groupBox3.Controls.Add(this.errMsg);
            this.groupBox3.Controls.Add(this.coeff1TextBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 79);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Коэффициенты уравнения";
            // 
            // coeff1TextBox
            // 
            this.coeff1TextBox.Location = new System.Drawing.Point(23, 32);
            this.coeff1TextBox.Name = "coeff1TextBox";
            this.coeff1TextBox.Size = new System.Drawing.Size(123, 22);
            this.coeff1TextBox.TabIndex = 0;
            this.coeff1TextBox.TextChanged += new System.EventHandler(this.coeff1TextBox_TextChanged);
            // 
            // coeff2TextBox
            // 
            this.coeff2TextBox.Location = new System.Drawing.Point(196, 32);
            this.coeff2TextBox.Name = "coeff2TextBox";
            this.coeff2TextBox.Size = new System.Drawing.Size(123, 22);
            this.coeff2TextBox.TabIndex = 0;
            this.coeff2TextBox.TextChanged += new System.EventHandler(this.coeff2TextBox_TextChanged);
            // 
            // coeff1Name
            // 
            this.coeff1Name.AutoSize = true;
            this.coeff1Name.Location = new System.Drawing.Point(20, 16);
            this.coeff1Name.Name = "coeff1Name";
            this.coeff1Name.Size = new System.Drawing.Size(42, 13);
            this.coeff1Name.TabIndex = 1;
            this.coeff1Name.Text = "Коэфф";
            // 
            // coeff2Name
            // 
            this.coeff2Name.AutoSize = true;
            this.coeff2Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.coeff2Name.Location = new System.Drawing.Point(196, 16);
            this.coeff2Name.Name = "coeff2Name";
            this.coeff2Name.Size = new System.Drawing.Size(42, 13);
            this.coeff2Name.TabIndex = 1;
            this.coeff2Name.Text = "Коэфф";
            // 
            // checkCoeff1
            // 
            this.checkCoeff1.AutoSize = true;
            this.checkCoeff1.Location = new System.Drawing.Point(152, 35);
            this.checkCoeff1.Name = "checkCoeff1";
            this.checkCoeff1.Size = new System.Drawing.Size(15, 14);
            this.checkCoeff1.TabIndex = 2;
            this.checkCoeff1.UseVisualStyleBackColor = true;
            // 
            // checkCoeff2
            // 
            this.checkCoeff2.AutoSize = true;
            this.checkCoeff2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkCoeff2.Location = new System.Drawing.Point(323, 35);
            this.checkCoeff2.Name = "checkCoeff2";
            this.checkCoeff2.Size = new System.Drawing.Size(15, 14);
            this.checkCoeff2.TabIndex = 2;
            this.checkCoeff2.UseVisualStyleBackColor = true;
            // 
            // errMsg
            // 
            this.errMsg.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.errMsg.AutoSize = true;
            this.errMsg.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.errMsg.ForeColor = System.Drawing.Color.Red;
            this.errMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errMsg.Location = new System.Drawing.Point(20, 57);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(58, 15);
            this.errMsg.TabIndex = 2;
            this.errMsg.Text = "ОШИБКА";
            this.errMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.lambdaRootsBox);
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 367);
            this.panel5.TabIndex = 5;
            // 
            // qualityBox
            // 
            this.qualityBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.qualityBox.FormattingEnabled = true;
            this.qualityBox.Location = new System.Drawing.Point(648, 8);
            this.qualityBox.Name = "qualityBox";
            this.qualityBox.Size = new System.Drawing.Size(71, 21);
            this.qualityBox.TabIndex = 1;
            this.qualityBox.Text = "Точность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Точность округлений";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(725, 449);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск решений";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.lambdaRootsBox.ResumeLayout(false);
            this.lambdaRootsBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.sigmasTable.ResumeLayout(false);
            this.sigmasTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulaPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulaPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diffurPic2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diffurPic1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox selectN;
        private System.Windows.Forms.GroupBox lambdaRootsBox;
        private System.Windows.Forms.TextBox rootBox2;
        private System.Windows.Forms.Label root2;
        private System.Windows.Forms.TextBox rootBox1;
        private System.Windows.Forms.Label root1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox sigmasTable;
        private System.Windows.Forms.TextBox sigmaBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sigmaBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sigmaBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lipBox1;
        private System.Windows.Forms.Label l1Name;
        private System.Windows.Forms.TextBox lipBox0;
        private System.Windows.Forms.Label l0Name;
        private System.Windows.Forms.CheckBox l1Check;
        private System.Windows.Forms.CheckBox l0Check;
        private System.Windows.Forms.Label errMsgL;
        private System.Windows.Forms.CheckBox qCheckBox;
        private System.Windows.Forms.Label qLabel;
        private System.Windows.Forms.TextBox iValueBox;
        private System.Windows.Forms.TextBox qValueBox;
        private System.Windows.Forms.CheckBox iCheckBox;
        private System.Windows.Forms.Label iNameLabel;
        private System.Windows.Forms.Label rootStateLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox kBox3;
        private System.Windows.Forms.Label kLabel3;
        private System.Windows.Forms.TextBox kBox2;
        private System.Windows.Forms.Label kLabel2;
        private System.Windows.Forms.TextBox kBox1;
        private System.Windows.Forms.Label kLabel1;
        private System.Windows.Forms.Label iBlockLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label qDoneLabel;
        private System.Windows.Forms.Label iDoneLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox diffurPic2;
        private System.Windows.Forms.PictureBox formulaPic2;
        private System.Windows.Forms.PictureBox formulaPic1;
        private System.Windows.Forms.PictureBox diffurPic1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkCoeff2;
        private System.Windows.Forms.CheckBox checkCoeff1;
        private System.Windows.Forms.Label coeff2Name;
        private System.Windows.Forms.Label coeff1Name;
        private System.Windows.Forms.TextBox coeff2TextBox;
        private System.Windows.Forms.Label errMsg;
        private System.Windows.Forms.TextBox coeff1TextBox;
        private System.Windows.Forms.ComboBox qualityBox;
        private System.Windows.Forms.Label label3;
    }
}

