﻿namespace KaramvirAssignment5_DollarComputer
{
    partial class ProductInfoForm
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.InfoSelectProductButton = new System.Windows.Forms.Button();
            this.InfoCancelButton = new System.Windows.Forms.Button();
            this.InfoNextButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WebcamTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.GpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.hddTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CpuSpeedTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CpuNumberTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.LcdTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CpuTypeTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CpuBrandTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MemoryTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OsTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ManufacTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoSelectProductButton
            // 
            this.InfoSelectProductButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.InfoSelectProductButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoSelectProductButton.Location = new System.Drawing.Point(452, 418);
            this.InfoSelectProductButton.Name = "InfoSelectProductButton";
            this.InfoSelectProductButton.Size = new System.Drawing.Size(167, 32);
            this.InfoSelectProductButton.TabIndex = 25;
            this.InfoSelectProductButton.Text = "Select Another Product";
            this.InfoSelectProductButton.UseVisualStyleBackColor = false;
            this.InfoSelectProductButton.Click += new System.EventHandler(this.InfoSelectProductButton_Click);
            // 
            // InfoCancelButton
            // 
            this.InfoCancelButton.BackColor = System.Drawing.Color.Salmon;
            this.InfoCancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoCancelButton.Location = new System.Drawing.Point(636, 418);
            this.InfoCancelButton.Name = "InfoCancelButton";
            this.InfoCancelButton.Size = new System.Drawing.Size(76, 32);
            this.InfoCancelButton.TabIndex = 24;
            this.InfoCancelButton.Text = "Cancel";
            this.InfoCancelButton.UseVisualStyleBackColor = false;
            this.InfoCancelButton.Click += new System.EventHandler(this.InfoCancelButton_Click);
            // 
            // InfoNextButton
            // 
            this.InfoNextButton.BackColor = System.Drawing.Color.PaleGreen;
            this.InfoNextButton.Enabled = false;
            this.InfoNextButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoNextButton.Location = new System.Drawing.Point(735, 418);
            this.InfoNextButton.Name = "InfoNextButton";
            this.InfoNextButton.Size = new System.Drawing.Size(75, 32);
            this.InfoNextButton.TabIndex = 23;
            this.InfoNextButton.Text = "Next";
            this.InfoNextButton.UseVisualStyleBackColor = false;
            this.InfoNextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Click Next To Confirm Your Selection";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WebcamTextBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.GpuTypeTextBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.hddTextBox);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.CpuSpeedTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.CpuNumberTextBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.LcdTextBox);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.CpuTypeTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CpuBrandTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.MemoryTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(75, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 156);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tech Specs";
            // 
            // WebcamTextBox
            // 
            this.WebcamTextBox.BackColor = System.Drawing.Color.White;
            this.WebcamTextBox.Enabled = false;
            this.WebcamTextBox.Location = new System.Drawing.Point(491, 112);
            this.WebcamTextBox.Name = "WebcamTextBox";
            this.WebcamTextBox.Size = new System.Drawing.Size(217, 25);
            this.WebcamTextBox.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(420, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "WebCam";
            // 
            // GpuTypeTextBox
            // 
            this.GpuTypeTextBox.BackColor = System.Drawing.Color.White;
            this.GpuTypeTextBox.Enabled = false;
            this.GpuTypeTextBox.Location = new System.Drawing.Point(491, 75);
            this.GpuTypeTextBox.Name = "GpuTypeTextBox";
            this.GpuTypeTextBox.Size = new System.Drawing.Size(217, 25);
            this.GpuTypeTextBox.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(420, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "GPU Type";
            // 
            // hddTextBox
            // 
            this.hddTextBox.BackColor = System.Drawing.Color.White;
            this.hddTextBox.Enabled = false;
            this.hddTextBox.Location = new System.Drawing.Point(491, 38);
            this.hddTextBox.Name = "hddTextBox";
            this.hddTextBox.Size = new System.Drawing.Size(217, 25);
            this.hddTextBox.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(420, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 17);
            this.label17.TabIndex = 27;
            this.label17.Text = "HDD";
            // 
            // CpuSpeedTextBox
            // 
            this.CpuSpeedTextBox.BackColor = System.Drawing.Color.White;
            this.CpuSpeedTextBox.Enabled = false;
            this.CpuSpeedTextBox.Location = new System.Drawing.Point(273, 112);
            this.CpuSpeedTextBox.Name = "CpuSpeedTextBox";
            this.CpuSpeedTextBox.Size = new System.Drawing.Size(127, 25);
            this.CpuSpeedTextBox.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "CPU Speed";
            // 
            // CpuNumberTextBox
            // 
            this.CpuNumberTextBox.BackColor = System.Drawing.Color.White;
            this.CpuNumberTextBox.Enabled = false;
            this.CpuNumberTextBox.Location = new System.Drawing.Point(273, 75);
            this.CpuNumberTextBox.Name = "CpuNumberTextBox";
            this.CpuNumberTextBox.Size = new System.Drawing.Size(127, 25);
            this.CpuNumberTextBox.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(190, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "CPU Number";
            // 
            // LcdTextBox
            // 
            this.LcdTextBox.BackColor = System.Drawing.Color.White;
            this.LcdTextBox.Enabled = false;
            this.LcdTextBox.Location = new System.Drawing.Point(273, 38);
            this.LcdTextBox.Name = "LcdTextBox";
            this.LcdTextBox.Size = new System.Drawing.Size(127, 25);
            this.LcdTextBox.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(202, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "LCD Size";
            // 
            // CpuTypeTextBox
            // 
            this.CpuTypeTextBox.BackColor = System.Drawing.Color.White;
            this.CpuTypeTextBox.Enabled = false;
            this.CpuTypeTextBox.Location = new System.Drawing.Point(91, 112);
            this.CpuTypeTextBox.Name = "CpuTypeTextBox";
            this.CpuTypeTextBox.Size = new System.Drawing.Size(99, 25);
            this.CpuTypeTextBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "CPU Type";
            // 
            // CpuBrandTextBox
            // 
            this.CpuBrandTextBox.BackColor = System.Drawing.Color.White;
            this.CpuBrandTextBox.Enabled = false;
            this.CpuBrandTextBox.Location = new System.Drawing.Point(91, 75);
            this.CpuBrandTextBox.Name = "CpuBrandTextBox";
            this.CpuBrandTextBox.Size = new System.Drawing.Size(99, 25);
            this.CpuBrandTextBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "CPU Brand";
            // 
            // MemoryTextBox
            // 
            this.MemoryTextBox.BackColor = System.Drawing.Color.White;
            this.MemoryTextBox.Enabled = false;
            this.MemoryTextBox.Location = new System.Drawing.Point(91, 38);
            this.MemoryTextBox.Name = "MemoryTextBox";
            this.MemoryTextBox.Size = new System.Drawing.Size(99, 25);
            this.MemoryTextBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Memory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Model";
            // 
            // OsTextBox
            // 
            this.OsTextBox.BackColor = System.Drawing.Color.White;
            this.OsTextBox.Enabled = false;
            this.OsTextBox.Location = new System.Drawing.Point(423, 29);
            this.OsTextBox.Name = "OsTextBox";
            this.OsTextBox.Size = new System.Drawing.Size(285, 25);
            this.OsTextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "OS";
            // 
            // ManufacTextBox
            // 
            this.ManufacTextBox.BackColor = System.Drawing.Color.White;
            this.ManufacTextBox.Enabled = false;
            this.ManufacTextBox.Location = new System.Drawing.Point(91, 78);
            this.ManufacTextBox.Name = "ManufacTextBox";
            this.ManufacTextBox.Size = new System.Drawing.Size(163, 25);
            this.ManufacTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Manufacturer";
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.BackColor = System.Drawing.Color.White;
            this.PlatformTextBox.Enabled = false;
            this.PlatformTextBox.Location = new System.Drawing.Point(91, 29);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(163, 25);
            this.PlatformTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Platform";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.InfoCancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectToolStripMenuItem.Text = "Select Another Product";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.InfoSelectProductButton_Click);
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.BackColor = System.Drawing.Color.White;
            this.ModelTextBox.Enabled = false;
            this.ModelTextBox.Location = new System.Drawing.Point(423, 78);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(285, 25);
            this.ModelTextBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModelTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.OsTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ManufacTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PlatformTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(75, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 124);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.Color.White;
            this.CostTextBox.Enabled = false;
            this.CostTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTextBox.Location = new System.Drawing.Point(647, 50);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(163, 25);
            this.CostTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(593, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cost";
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.BackColor = System.Drawing.Color.White;
            this.ConditionTextBox.Enabled = false;
            this.ConditionTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionTextBox.Location = new System.Drawing.Point(405, 50);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(163, 25);
            this.ConditionTextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Condition";
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.BackColor = System.Drawing.Color.White;
            this.ProductIdTextBox.Enabled = false;
            this.ProductIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdTextBox.Location = new System.Drawing.Point(143, 50);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.Size = new System.Drawing.Size(163, 25);
            this.ProductIdTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Product ID";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.InfoSelectProductButton);
            this.Controls.Add(this.InfoCancelButton);
            this.Controls.Add(this.InfoNextButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductIdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ProductInfoForm";
            this.Text = "ProductInfoForm";
            this.Load += new System.EventHandler(this.ProductInfoForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button InfoSelectProductButton;
        private System.Windows.Forms.Button InfoCancelButton;
        private System.Windows.Forms.Button InfoNextButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox WebcamTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox GpuTypeTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox hddTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox CpuSpeedTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CpuNumberTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox LcdTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CpuTypeTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CpuBrandTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MemoryTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OsTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ManufacTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PlatformTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductIdTextBox;
        private System.Windows.Forms.Label label1;
    }
}