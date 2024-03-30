namespace EMS_OOP2
{
    partial class Login
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
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.L4 = new System.Windows.Forms.Label();
            this.login_user = new System.Windows.Forms.TextBox();
            this.login_pass = new System.Windows.Forms.TextBox();
            this.login_checkpass = new System.Windows.Forms.CheckBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.register_click = new System.Windows.Forms.LinkLabel();
            this.L6 = new System.Windows.Forms.Label();
            this.EMSBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EMSBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.Color.White;
            this.L1.Location = new System.Drawing.Point(150, 29);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(488, 49);
            this.L1.TabIndex = 1;
            this.L1.Text = "Employee Management";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Arial", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.ForeColor = System.Drawing.Color.White;
            this.L2.Location = new System.Drawing.Point(306, 103);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(170, 49);
            this.L2.TabIndex = 2;
            this.L2.Text = "System";
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.L3.ForeColor = System.Drawing.Color.White;
            this.L3.Location = new System.Drawing.Point(12, 193);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(173, 37);
            this.L3.TabIndex = 3;
            this.L3.Text = "Username:";
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.L4.ForeColor = System.Drawing.Color.White;
            this.L4.Location = new System.Drawing.Point(18, 266);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(167, 37);
            this.L4.TabIndex = 4;
            this.L4.Text = "Password:";
            // 
            // login_user
            // 
            this.login_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.login_user.Location = new System.Drawing.Point(204, 188);
            this.login_user.Multiline = true;
            this.login_user.Name = "login_user";
            this.login_user.Size = new System.Drawing.Size(566, 42);
            this.login_user.TabIndex = 5;
            // 
            // login_pass
            // 
            this.login_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.login_pass.Location = new System.Drawing.Point(204, 266);
            this.login_pass.Multiline = true;
            this.login_pass.Name = "login_pass";
            this.login_pass.PasswordChar = '*';
            this.login_pass.Size = new System.Drawing.Size(566, 40);
            this.login_pass.TabIndex = 6;
            // 
            // login_checkpass
            // 
            this.login_checkpass.AutoSize = true;
            this.login_checkpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.login_checkpass.ForeColor = System.Drawing.Color.White;
            this.login_checkpass.Location = new System.Drawing.Point(204, 331);
            this.login_checkpass.Name = "login_checkpass";
            this.login_checkpass.Size = new System.Drawing.Size(157, 24);
            this.login_checkpass.TabIndex = 7;
            this.login_checkpass.Text = "Check Password";
            this.login_checkpass.UseVisualStyleBackColor = true;
            this.login_checkpass.CheckedChanged += new System.EventHandler(this.login_checkpass_CheckedChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(369, 376);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(170, 65);
            this.loginbtn.TabIndex = 8;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // register_click
            // 
            this.register_click.AutoSize = true;
            this.register_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_click.Location = new System.Drawing.Point(478, 462);
            this.register_click.Name = "register_click";
            this.register_click.Size = new System.Drawing.Size(123, 20);
            this.register_click.TabIndex = 9;
            this.register_click.TabStop = true;
            this.register_click.Text = "Register here";
            this.register_click.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_click_LinkClicked);
            // 
            // L6
            // 
            this.L6.AutoSize = true;
            this.L6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.L6.ForeColor = System.Drawing.Color.White;
            this.L6.Location = new System.Drawing.Point(286, 462);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(177, 20);
            this.L6.TabIndex = 10;
            this.L6.Text = "Don\'t have an account?";
            // 
            // EMSBox1
            // 
            this.EMSBox1.Image = global::EMS_OOP2.Properties.Resources.Untitled_design;
            this.EMSBox1.Location = new System.Drawing.Point(0, 0);
            this.EMSBox1.Name = "EMSBox1";
            this.EMSBox1.Size = new System.Drawing.Size(913, 534);
            this.EMSBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EMSBox1.TabIndex = 0;
            this.EMSBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 499);
            this.Controls.Add(this.L6);
            this.Controls.Add(this.register_click);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.login_checkpass);
            this.Controls.Add(this.login_pass);
            this.Controls.Add(this.login_user);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.EMSBox1);
            this.Name = "Login";
            this.Text = "EMS | Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EMSBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EMSBox1;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Label L3;
        private System.Windows.Forms.Label L4;
        private System.Windows.Forms.TextBox login_user;
        private System.Windows.Forms.TextBox login_pass;
        private System.Windows.Forms.CheckBox login_checkpass;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.LinkLabel register_click;
        private System.Windows.Forms.Label L6;
    }
}

