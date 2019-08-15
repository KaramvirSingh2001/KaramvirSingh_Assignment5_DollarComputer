namespace KaramvirAssignment5_DollarComputer
{
    partial class StartForm
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
            this.ExitApplicationButton = new System.Windows.Forms.Button();
            this.LoadSavedOrderButton = new System.Windows.Forms.Button();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitApplicationButton
            // 
            this.ExitApplicationButton.Location = new System.Drawing.Point(86, 226);
            this.ExitApplicationButton.Name = "ExitApplicationButton";
            this.ExitApplicationButton.Size = new System.Drawing.Size(117, 23);
            this.ExitApplicationButton.TabIndex = 7;
            this.ExitApplicationButton.Text = "Exit";
            this.ExitApplicationButton.UseVisualStyleBackColor = true;
            this.ExitApplicationButton.Click += new System.EventHandler(this.ExitApplicationButton_Click);
            // 
            // LoadSavedOrderButton
            // 
            this.LoadSavedOrderButton.Location = new System.Drawing.Point(86, 197);
            this.LoadSavedOrderButton.Name = "LoadSavedOrderButton";
            this.LoadSavedOrderButton.Size = new System.Drawing.Size(117, 23);
            this.LoadSavedOrderButton.TabIndex = 6;
            this.LoadSavedOrderButton.Text = "Open a Saved Order";
            this.LoadSavedOrderButton.UseVisualStyleBackColor = true;
            this.LoadSavedOrderButton.Click += new System.EventHandler(this.LoadSavedOrderButton_Click);
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Location = new System.Drawing.Point(86, 168);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(117, 23);
            this.NewOrderButton.TabIndex = 5;
            this.NewOrderButton.Text = "Start New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KaramvirAssignment5_DollarComputer.Properties.Resources.startImage2;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.ExitApplicationButton);
            this.Controls.Add(this.LoadSavedOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitApplicationButton;
        private System.Windows.Forms.Button LoadSavedOrderButton;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}