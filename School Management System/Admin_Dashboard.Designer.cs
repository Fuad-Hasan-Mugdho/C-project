namespace School_Management_System
{
    partial class Admin_Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddCRS = new System.Windows.Forms.Button();
            this.btnSearchCRS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddTCR = new System.Windows.Forms.Button();
            this.btnSearchTCR = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSTDReg = new System.Windows.Forms.Button();
            this.btnAddSTD = new System.Windows.Forms.Button();
            this.btnSearchSTD = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(49, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 395);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(78)))), ((int)(((byte)(66)))));
            this.panel2.Location = new System.Drawing.Point(-4, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 33);
            this.panel2.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddCRS);
            this.groupBox3.Controls.Add(this.btnSearchCRS);
            this.groupBox3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Location = new System.Drawing.Point(54, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 140);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "COURSE";
            // 
            // btnAddCRS
            // 
            this.btnAddCRS.BackColor = System.Drawing.Color.Silver;
            this.btnAddCRS.FlatAppearance.BorderSize = 0;
            this.btnAddCRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCRS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAddCRS.Location = new System.Drawing.Point(16, 86);
            this.btnAddCRS.Name = "btnAddCRS";
            this.btnAddCRS.Size = new System.Drawing.Size(147, 35);
            this.btnAddCRS.TabIndex = 5;
            this.btnAddCRS.Text = "Add Course";
            this.btnAddCRS.UseVisualStyleBackColor = false;
            this.btnAddCRS.Click += new System.EventHandler(this.btnAddCRS_Click);
            // 
            // btnSearchCRS
            // 
            this.btnSearchCRS.BackColor = System.Drawing.Color.Silver;
            this.btnSearchCRS.FlatAppearance.BorderSize = 0;
            this.btnSearchCRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCRS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSearchCRS.Location = new System.Drawing.Point(16, 35);
            this.btnSearchCRS.Name = "btnSearchCRS";
            this.btnSearchCRS.Size = new System.Drawing.Size(147, 35);
            this.btnSearchCRS.TabIndex = 4;
            this.btnSearchCRS.Text = "Search Course";
            this.btnSearchCRS.UseVisualStyleBackColor = false;
            this.btnSearchCRS.Click += new System.EventHandler(this.btnSearchCRS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "DASHBOARD";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(78)))), ((int)(((byte)(66)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogout.Location = new System.Drawing.Point(279, 284);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(147, 83);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddTCR);
            this.groupBox2.Controls.Add(this.btnSearchTCR);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(264, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 195);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TEACHER";
            // 
            // btnAddTCR
            // 
            this.btnAddTCR.BackColor = System.Drawing.Color.Silver;
            this.btnAddTCR.FlatAppearance.BorderSize = 0;
            this.btnAddTCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTCR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAddTCR.Location = new System.Drawing.Point(15, 115);
            this.btnAddTCR.Name = "btnAddTCR";
            this.btnAddTCR.Size = new System.Drawing.Size(147, 35);
            this.btnAddTCR.TabIndex = 3;
            this.btnAddTCR.Text = "Add Faculty";
            this.btnAddTCR.UseVisualStyleBackColor = false;
            this.btnAddTCR.Click += new System.EventHandler(this.btnAddTCR_Click);
            // 
            // btnSearchTCR
            // 
            this.btnSearchTCR.BackColor = System.Drawing.Color.Silver;
            this.btnSearchTCR.FlatAppearance.BorderSize = 0;
            this.btnSearchTCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTCR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSearchTCR.Location = new System.Drawing.Point(15, 62);
            this.btnSearchTCR.Name = "btnSearchTCR";
            this.btnSearchTCR.Size = new System.Drawing.Size(147, 35);
            this.btnSearchTCR.TabIndex = 2;
            this.btnSearchTCR.Text = "Search Faculty";
            this.btnSearchTCR.UseVisualStyleBackColor = false;
            this.btnSearchTCR.Click += new System.EventHandler(this.btnSearchTCR_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSTDReg);
            this.groupBox1.Controls.Add(this.btnAddSTD);
            this.groupBox1.Controls.Add(this.btnSearchSTD);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(54, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 195);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STUDENT";
            // 
            // btnSTDReg
            // 
            this.btnSTDReg.BackColor = System.Drawing.Color.Silver;
            this.btnSTDReg.FlatAppearance.BorderSize = 0;
            this.btnSTDReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTDReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSTDReg.Location = new System.Drawing.Point(16, 137);
            this.btnSTDReg.Name = "btnSTDReg";
            this.btnSTDReg.Size = new System.Drawing.Size(147, 35);
            this.btnSTDReg.TabIndex = 2;
            this.btnSTDReg.Text = "Registration";
            this.btnSTDReg.UseVisualStyleBackColor = false;
            this.btnSTDReg.Click += new System.EventHandler(this.btnSTDReg_Click);
            // 
            // btnAddSTD
            // 
            this.btnAddSTD.BackColor = System.Drawing.Color.Silver;
            this.btnAddSTD.FlatAppearance.BorderSize = 0;
            this.btnAddSTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSTD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAddSTD.Location = new System.Drawing.Point(16, 85);
            this.btnAddSTD.Name = "btnAddSTD";
            this.btnAddSTD.Size = new System.Drawing.Size(147, 35);
            this.btnAddSTD.TabIndex = 1;
            this.btnAddSTD.Text = "Add Student";
            this.btnAddSTD.UseVisualStyleBackColor = false;
            this.btnAddSTD.Click += new System.EventHandler(this.btnAddSTD_Click);
            // 
            // btnSearchSTD
            // 
            this.btnSearchSTD.BackColor = System.Drawing.Color.Silver;
            this.btnSearchSTD.FlatAppearance.BorderSize = 0;
            this.btnSearchSTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSTD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSearchSTD.Location = new System.Drawing.Point(16, 34);
            this.btnSearchSTD.Name = "btnSearchSTD";
            this.btnSearchSTD.Size = new System.Drawing.Size(147, 35);
            this.btnSearchSTD.TabIndex = 0;
            this.btnSearchSTD.Text = "Search Student";
            this.btnSearchSTD.UseVisualStyleBackColor = false;
            this.btnSearchSTD.Click += new System.EventHandler(this.btnSearchSTD_Click);
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Dashboard_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddCRS;
        private System.Windows.Forms.Button btnSearchCRS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddTCR;
        private System.Windows.Forms.Button btnSearchTCR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSTDReg;
        private System.Windows.Forms.Button btnAddSTD;
        private System.Windows.Forms.Button btnSearchSTD;
    }
}