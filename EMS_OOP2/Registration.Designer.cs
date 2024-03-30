namespace EMS_OOP2
{
    partial class Registration
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
            this.R1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.register_email = new System.Windows.Forms.TextBox();
            this.register_user = new System.Windows.Forms.TextBox();
            this.register_pass = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.register_checkpass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_click = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // R1
            // 
            this.R1.AutoSize = true;
            this.R1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R1.Location = new System.Drawing.Point(483, 33);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(205, 38);
            this.R1.TabIndex = 1;
            this.R1.Text = "Get Started!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.label1.Location = new System.Drawing.Point(531, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.label2.Location = new System.Drawing.Point(481, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.label3.Location = new System.Drawing.Point(485, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // register_email
            // 
            this.register_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.register_email.Location = new System.Drawing.Point(617, 121);
            this.register_email.Multiline = true;
            this.register_email.Name = "register_email";
            this.register_email.Size = new System.Drawing.Size(291, 29);
            this.register_email.TabIndex = 5;
            // 
            // register_user
            // 
            this.register_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.register_user.Location = new System.Drawing.Point(617, 182);
            this.register_user.Multiline = true;
            this.register_user.Name = "register_user";
            this.register_user.Size = new System.Drawing.Size(291, 29);
            this.register_user.TabIndex = 6;
            // 
            // register_pass
            // 
            this.register_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.register_pass.Location = new System.Drawing.Point(617, 251);
            this.register_pass.Multiline = true;
            this.register_pass.Name = "register_pass";
            this.register_pass.PasswordChar = '*';
            this.register_pass.Size = new System.Drawing.Size(291, 29);
            this.register_pass.TabIndex = 7;
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.register_btn.Location = new System.Drawing.Point(680, 352);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(141, 65);
            this.register_btn.TabIndex = 8;
            this.register_btn.Text = "SignUp";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // register_checkpass
            // 
            this.register_checkpass.AutoSize = true;
            this.register_checkpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.register_checkpass.Location = new System.Drawing.Point(617, 300);
            this.register_checkpass.Name = "register_checkpass";
            this.register_checkpass.Size = new System.Drawing.Size(157, 24);
            this.register_checkpass.TabIndex = 9;
            this.register_checkpass.Text = "Check Password";
            this.register_checkpass.UseVisualStyleBackColor = true;
            this.register_checkpass.CheckedChanged += new System.EventHandler(this.register_checkpass_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.label4.Location = new System.Drawing.Point(535, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Already have an account?";
            // 
            // login_click
            // 
            this.login_click.AutoSize = true;
            this.login_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_click.Location = new System.Drawing.Point(747, 460);
            this.login_click.Name = "login_click";
            this.login_click.Size = new System.Drawing.Size(88, 20);
            this.login_click.TabIndex = 11;
            this.login_click.TabStop = true;
            this.login_click.Text = "Login here";
            this.login_click.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_click_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EMS_OOP2.Properties.Resources.Untitled_design;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 502);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 499);
            this.Controls.Add(this.login_click);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_checkpass);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.register_pass);
            this.Controls.Add(this.register_user);
            this.Controls.Add(this.register_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registration";
            this.Text = "EMS | Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label R1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox register_email;
        private System.Windows.Forms.TextBox register_user;
        private System.Windows.Forms.TextBox register_pass;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.CheckBox register_checkpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel login_click;
    }
}