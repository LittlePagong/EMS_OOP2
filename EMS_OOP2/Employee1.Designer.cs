namespace EMS_OOP2
{
    partial class Employee1
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
            this.HomeLabel = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.PictureBox();
            this.HomeBtn = new System.Windows.Forms.PictureBox();
            this.EMS1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMS1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.Black;
            this.HomeLabel.Location = new System.Drawing.Point(123, 55);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(112, 39);
            this.HomeLabel.TabIndex = 2;
            this.HomeLabel.Text = "Home";
            // 
            // Logout
            // 
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.Image = global::EMS_OOP2.Properties.Resources.png_transparent_computer_icons_logout_angle_text_black_thumbnail;
            this.Logout.Location = new System.Drawing.Point(1120, 23);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(79, 71);
            this.Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logout.TabIndex = 3;
            this.Logout.TabStop = false;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.Image = global::EMS_OOP2.Properties.Resources.Home;
            this.HomeBtn.Location = new System.Drawing.Point(13, 23);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(90, 71);
            this.HomeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.TabStop = false;
            // 
            // EMS1
            // 
            this.EMS1.Image = global::EMS_OOP2.Properties.Resources.Untitled_design;
            this.EMS1.Location = new System.Drawing.Point(-1, 1);
            this.EMS1.Name = "EMS1";
            this.EMS1.Size = new System.Drawing.Size(1212, 697);
            this.EMS1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EMS1.TabIndex = 0;
            this.EMS1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.HomeLabel);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 129);
            this.panel1.TabIndex = 4;
            // 
            // Employee1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 696);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EMS1);
            this.Name = "Employee1";
            this.Text = "Employee Management System | Menu";
            this.Load += new System.EventHandler(this.Employee1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMS1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox EMS1;
        private System.Windows.Forms.PictureBox HomeBtn;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.PictureBox Logout;
        private System.Windows.Forms.Panel panel1;
    }
}