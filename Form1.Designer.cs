
namespace RandomMap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public static Form1 Instance;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bpm = new System.Windows.Forms.NumericUpDown();
            this.length = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.xGridNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.saveToOszCheckBox = new System.Windows.Forms.CheckBox();
            this.csNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.arNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.hpNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.odNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.creatorTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bpm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xGridNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "种子（留空随机）";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "BPM";
            // 
            // bpm
            // 
            this.bpm.DecimalPlaces = 1;
            this.bpm.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.bpm.Location = new System.Drawing.Point(128, 178);
            this.bpm.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bpm.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.bpm.Name = "bpm";
            this.bpm.Size = new System.Drawing.Size(141, 23);
            this.bpm.TabIndex = 3;
            this.bpm.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.bpm.ValueChanged += new System.EventHandler(this.bpm_ValueChanged);
            // 
            // length
            // 
            this.length.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.length.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.length.Location = new System.Drawing.Point(128, 218);
            this.length.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.length.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(141, 23);
            this.length.TabIndex = 5;
            this.length.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "长度";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xGridNumericUpDown
            // 
            this.xGridNumericUpDown.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.xGridNumericUpDown.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.xGridNumericUpDown.Location = new System.Drawing.Point(128, 258);
            this.xGridNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.xGridNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.xGridNumericUpDown.Name = "xGridNumericUpDown";
            this.xGridNumericUpDown.Size = new System.Drawing.Size(141, 23);
            this.xGridNumericUpDown.TabIndex = 8;
            this.xGridNumericUpDown.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "X Grid";
            // 
            // saveToOszCheckBox
            // 
            this.saveToOszCheckBox.AutoSize = true;
            this.saveToOszCheckBox.Location = new System.Drawing.Point(26, 374);
            this.saveToOszCheckBox.Name = "saveToOszCheckBox";
            this.saveToOszCheckBox.Size = new System.Drawing.Size(83, 21);
            this.saveToOszCheckBox.TabIndex = 10;
            this.saveToOszCheckBox.Text = "导出为osz";
            this.saveToOszCheckBox.UseVisualStyleBackColor = true;
            // 
            // csNumericUpDown
            // 
            this.csNumericUpDown.DecimalPlaces = 1;
            this.csNumericUpDown.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.csNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.csNumericUpDown.Location = new System.Drawing.Point(87, 305);
            this.csNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.csNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.csNumericUpDown.Name = "csNumericUpDown";
            this.csNumericUpDown.Size = new System.Drawing.Size(54, 23);
            this.csNumericUpDown.TabIndex = 12;
            this.csNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "CS";
            // 
            // arNumericUpDown
            // 
            this.arNumericUpDown.DecimalPlaces = 1;
            this.arNumericUpDown.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.arNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.arNumericUpDown.Location = new System.Drawing.Point(178, 305);
            this.arNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.arNumericUpDown.Name = "arNumericUpDown";
            this.arNumericUpDown.Size = new System.Drawing.Size(54, 23);
            this.arNumericUpDown.TabIndex = 14;
            this.arNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "AR";
            // 
            // hpNumericUpDown
            // 
            this.hpNumericUpDown.DecimalPlaces = 1;
            this.hpNumericUpDown.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.hpNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.hpNumericUpDown.Location = new System.Drawing.Point(178, 345);
            this.hpNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.hpNumericUpDown.Name = "hpNumericUpDown";
            this.hpNumericUpDown.Size = new System.Drawing.Size(54, 23);
            this.hpNumericUpDown.TabIndex = 18;
            this.hpNumericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "HP";
            // 
            // odNumericUpDown
            // 
            this.odNumericUpDown.DecimalPlaces = 1;
            this.odNumericUpDown.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.odNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.odNumericUpDown.Location = new System.Drawing.Point(87, 345);
            this.odNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.odNumericUpDown.Name = "odNumericUpDown";
            this.odNumericUpDown.Size = new System.Drawing.Size(54, 23);
            this.odNumericUpDown.TabIndex = 16;
            this.odNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "OD";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(128, 58);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(141, 23);
            this.titleTextBox.TabIndex = 20;
            this.titleTextBox.Text = "mute";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "标题";
            // 
            // creatorTextBox
            // 
            this.creatorTextBox.Location = new System.Drawing.Point(128, 98);
            this.creatorTextBox.Name = "creatorTextBox";
            this.creatorTextBox.Size = new System.Drawing.Size(141, 23);
            this.creatorTextBox.TabIndex = 22;
            this.creatorTextBox.Text = "SCORE V2 SUCKS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "作者";
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(128, 138);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.Size = new System.Drawing.Size(141, 23);
            this.artistTextBox.TabIndex = 24;
            this.artistTextBox.Text = "obless_noob";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "曲师";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.artistTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.creatorTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.titleTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bpm, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.xGridNumericUpDown, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.length, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 290);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.hpNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.odNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.arNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.csNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveToOszCheckBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "切指图生成";
            ((System.ComponentModel.ISupportInitialize)(this.bpm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xGridNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.NumericUpDown bpm;
        public System.Windows.Forms.NumericUpDown length;
        public System.Windows.Forms.NumericUpDown xGridNumericUpDown;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.NumericUpDown arNumericUpDown;
        public System.Windows.Forms.NumericUpDown numericUpDown3;
        public System.Windows.Forms.NumericUpDown odNumericUpDown;
        public System.Windows.Forms.TextBox titleTextBox;
        public System.Windows.Forms.TextBox creatorTextBox;
        public System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.CheckBox saveToOszCheckBox;
        public System.Windows.Forms.NumericUpDown csNumericUpDown;
        public System.Windows.Forms.NumericUpDown hpNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

