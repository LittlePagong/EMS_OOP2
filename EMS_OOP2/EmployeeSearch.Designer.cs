namespace EMS_OOP2
{
    partial class EmployeeSearch
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
            this.EmpSearchPicBox = new System.Windows.Forms.PictureBox();
            this.EmpSearchBox1 = new System.Windows.Forms.TextBox();
            this.EmpSearchLabel = new System.Windows.Forms.Label();
            this.EmpSearch1 = new System.Windows.Forms.Button();
            this.EmployeeData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmpSearchPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpSearchPicBox
            // 
            this.EmpSearchPicBox.Image = global::EMS_OOP2.Properties.Resources.Untitled_design;
            this.EmpSearchPicBox.Location = new System.Drawing.Point(0, 0);
            this.EmpSearchPicBox.Name = "EmpSearchPicBox";
            this.EmpSearchPicBox.Size = new System.Drawing.Size(490, 278);
            this.EmpSearchPicBox.TabIndex = 0;
            this.EmpSearchPicBox.TabStop = false;
            // 
            // EmpSearchBox1
            // 
            this.EmpSearchBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.EmpSearchBox1.Location = new System.Drawing.Point(192, 39);
            this.EmpSearchBox1.Multiline = true;
            this.EmpSearchBox1.Name = "EmpSearchBox1";
            this.EmpSearchBox1.Size = new System.Drawing.Size(160, 33);
            this.EmpSearchBox1.TabIndex = 1;
            // 
            // EmpSearchLabel
            // 
            this.EmpSearchLabel.AutoSize = true;
            this.EmpSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EmpSearchLabel.ForeColor = System.Drawing.Color.White;
            this.EmpSearchLabel.Location = new System.Drawing.Point(12, 39);
            this.EmpSearchLabel.Name = "EmpSearchLabel";
            this.EmpSearchLabel.Size = new System.Drawing.Size(165, 29);
            this.EmpSearchLabel.TabIndex = 2;
            this.EmpSearchLabel.Text = "Employee ID:";
            // 
            // EmpSearch1
            // 
            this.EmpSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EmpSearch1.Location = new System.Drawing.Point(213, 96);
            this.EmpSearch1.Name = "EmpSearch1";
            this.EmpSearch1.Size = new System.Drawing.Size(130, 56);
            this.EmpSearch1.TabIndex = 3;
            this.EmpSearch1.Text = "Search Employee";
            this.EmpSearch1.UseVisualStyleBackColor = true;
            this.EmpSearch1.Click += new System.EventHandler(this.EmpSearch1_Click);
            // 
            // EmployeeData
            // 
            this.EmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeData.Location = new System.Drawing.Point(12, 178);
            this.EmployeeData.Name = "EmployeeData";
            this.EmployeeData.RowHeadersWidth = 51;
            this.EmployeeData.RowTemplate.Height = 24;
            this.EmployeeData.Size = new System.Drawing.Size(463, 83);
            this.EmployeeData.TabIndex = 4;
            // 
            // EmployeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 273);
            this.Controls.Add(this.EmployeeData);
            this.Controls.Add(this.EmpSearch1);
            this.Controls.Add(this.EmpSearchLabel);
            this.Controls.Add(this.EmpSearchBox1);
            this.Controls.Add(this.EmpSearchPicBox);
            this.Name = "EmployeeSearch";
            this.Text = "Seach a Employee";
            this.Load += new System.EventHandler(this.EmployeeSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpSearchPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox EmpSearchPicBox;
        private System.Windows.Forms.TextBox EmpSearchBox1;
        private System.Windows.Forms.Label EmpSearchLabel;
        private System.Windows.Forms.Button EmpSearch1;
        private System.Windows.Forms.DataGridView EmployeeData;
    }
}