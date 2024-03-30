namespace EMS_OOP2
{
    partial class EMSMenu
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
            this.EMSMenuLabel = new System.Windows.Forms.Label();
            this.EmployeeData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.PictureBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.EMS3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMS3)).BeginInit();
            this.SuspendLayout();
            // 
            // EMSMenuLabel
            // 
            this.EMSMenuLabel.AutoSize = true;
            this.EMSMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMSMenuLabel.ForeColor = System.Drawing.Color.White;
            this.EMSMenuLabel.Location = new System.Drawing.Point(12, 22);
            this.EMSMenuLabel.Name = "EMSMenuLabel";
            this.EMSMenuLabel.Size = new System.Drawing.Size(761, 58);
            this.EMSMenuLabel.TabIndex = 0;
            this.EMSMenuLabel.Text = "Employee Management System";
            // 
            // EmployeeData
            // 
            this.EmployeeData.AllowUserToAddRows = false;
            this.EmployeeData.AllowUserToDeleteRows = false;
            this.EmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeData.Location = new System.Drawing.Point(10, 73);
            this.EmployeeData.Name = "EmployeeData";
            this.EmployeeData.ReadOnly = true;
            this.EmployeeData.RowHeadersWidth = 51;
            this.EmployeeData.RowTemplate.Height = 24;
            this.EmployeeData.Size = new System.Drawing.Size(932, 362);
            this.EmployeeData.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Deletebtn);
            this.groupBox1.Controls.Add(this.EmployeeData);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 460);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Employees";
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Red;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.Black;
            this.Deletebtn.Location = new System.Drawing.Point(745, 23);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(197, 44);
            this.Deletebtn.TabIndex = 13;
            this.Deletebtn.Text = "Delete Employee";
            this.Deletebtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Lime;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(510, 23);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(217, 44);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "Add New Employee";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Logout
            // 
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.Image = global::EMS_OOP2.Properties.Resources._141_1411375_logout_free_icon_3_switch;
            this.Logout.Location = new System.Drawing.Point(872, 653);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(82, 68);
            this.Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logout.TabIndex = 18;
            this.Logout.TabStop = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackgroundImage = global::EMS_OOP2.Properties.Resources.Untitled_design;
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Searchbtn.ForeColor = System.Drawing.Color.White;
            this.Searchbtn.Location = new System.Drawing.Point(22, 667);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(129, 54);
            this.Searchbtn.TabIndex = 16;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackgroundImage = global::EMS_OOP2.Properties.Resources.Untitled_design;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(22, 607);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(129, 54);
            this.UpdateBtn.TabIndex = 13;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // EMS3
            // 
            this.EMS3.Image = global::EMS_OOP2.Properties.Resources.Untitled_design;
            this.EMS3.Location = new System.Drawing.Point(0, 0);
            this.EMS3.Name = "EMS3";
            this.EMS3.Size = new System.Drawing.Size(1012, 100);
            this.EMS3.TabIndex = 0;
            this.EMS3.TabStop = false;
            // 
            // EMSMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 735);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.EMSMenuLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EMS3);
            this.Name = "EMSMenu";
            this.Text = "EMS Menu";
            this.Load += new System.EventHandler(this.EMSMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EMS3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EMS3;
        private System.Windows.Forms.Label EMSMenuLabel;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.PictureBox Logout;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView EmployeeData;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}