namespace nlsys
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.dgvVar = new System.Windows.Forms.DataGridView();
            this.Значение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEq = new System.Windows.Forms.DataGridView();
            this.Уравнение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAcc = new System.Windows.Forms.TextBox();
            this.tbIter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbResN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbResQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudEq = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEq)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число переменных:";
            // 
            // nudN
            // 
            this.nudN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudN.Location = new System.Drawing.Point(234, 27);
            this.nudN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(256, 20);
            this.nudN.TabIndex = 2;
            this.nudN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN.ValueChanged += new System.EventHandler(this.nudN_ValueChanged);
            // 
            // dgvVar
            // 
            this.dgvVar.AllowUserToAddRows = false;
            this.dgvVar.AllowUserToDeleteRows = false;
            this.dgvVar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Значение});
            this.dgvVar.Location = new System.Drawing.Point(12, 53);
            this.dgvVar.MinimumSize = new System.Drawing.Size(342, 68);
            this.dgvVar.Name = "dgvVar";
            this.dgvVar.RowHeadersVisible = false;
            this.dgvVar.Size = new System.Drawing.Size(478, 107);
            this.dgvVar.TabIndex = 3;
            // 
            // Значение
            // 
            this.Значение.HeaderText = "Значение";
            this.Значение.Name = "Значение";
            // 
            // dgvEq
            // 
            this.dgvEq.AllowUserToAddRows = false;
            this.dgvEq.AllowUserToDeleteRows = false;
            this.dgvEq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Уравнение});
            this.dgvEq.Location = new System.Drawing.Point(12, 192);
            this.dgvEq.Name = "dgvEq";
            this.dgvEq.RowHeadersVisible = false;
            this.dgvEq.Size = new System.Drawing.Size(478, 119);
            this.dgvEq.TabIndex = 4;
            // 
            // Уравнение
            // 
            this.Уравнение.HeaderText = "Система";
            this.Уравнение.Name = "Уравнение";
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Location = new System.Drawing.Point(415, 447);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Расчет";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Точность:";
            // 
            // tbAcc
            // 
            this.tbAcc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAcc.Location = new System.Drawing.Point(234, 317);
            this.tbAcc.Name = "tbAcc";
            this.tbAcc.Size = new System.Drawing.Size(256, 20);
            this.tbAcc.TabIndex = 7;
            this.tbAcc.Text = "0,001";
            // 
            // tbIter
            // 
            this.tbIter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIter.Location = new System.Drawing.Point(234, 343);
            this.tbIter.Name = "tbIter";
            this.tbIter.Size = new System.Drawing.Size(256, 20);
            this.tbIter.TabIndex = 9;
            this.tbIter.Text = "10";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Число итераций:";
            // 
            // tbStep
            // 
            this.tbStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStep.Location = new System.Drawing.Point(234, 369);
            this.tbStep.Name = "tbStep";
            this.tbStep.Size = new System.Drawing.Size(256, 20);
            this.tbStep.TabIndex = 11;
            this.tbStep.Text = "0,1";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Размер шага:";
            // 
            // tbResN
            // 
            this.tbResN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResN.Location = new System.Drawing.Point(166, 395);
            this.tbResN.Name = "tbResN";
            this.tbResN.Size = new System.Drawing.Size(324, 20);
            this.tbResN.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Метод Ньютона-Рафсона:";
            // 
            // tbResQ
            // 
            this.tbResQ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResQ.Location = new System.Drawing.Point(166, 421);
            this.tbResQ.Name = "tbResQ";
            this.tbResQ.Size = new System.Drawing.Size(324, 20);
            this.tbResQ.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Квазиньютоновский метод:";
            // 
            // nudEq
            // 
            this.nudEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudEq.Location = new System.Drawing.Point(234, 166);
            this.nudEq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEq.Name = "nudEq";
            this.nudEq.Size = new System.Drawing.Size(256, 20);
            this.nudEq.TabIndex = 17;
            this.nudEq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEq.ValueChanged += new System.EventHandler(this.nudEq_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Число уравнений:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 482);
            this.Controls.Add(this.nudEq);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbResQ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbResN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbStep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbIter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.dgvEq);
            this.Controls.Add(this.dgvVar);
            this.Controls.Add(this.nudN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(510, 516);
            this.Name = "MainForm";
            this.Text = "Решение систем нелинейных уравнений";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvVar;
        private System.Windows.Forms.DataGridView dgvEq;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAcc;
        private System.Windows.Forms.TextBox tbIter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbResN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbResQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Уравнение;
        private System.Windows.Forms.NumericUpDown nudEq;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Значение;
    }
}

