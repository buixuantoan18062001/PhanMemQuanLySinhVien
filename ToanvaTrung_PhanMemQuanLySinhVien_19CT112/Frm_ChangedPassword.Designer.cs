namespace ToanvaTrung_PhanMemQuanLySinhVien_19CT112
{
    partial class Frm_ChangedPassword
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
            this.grbAdmin = new System.Windows.Forms.GroupBox();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnResetPassword = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label4 = new System.Windows.Forms.Label();
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.txtPasswordTwo = new System.Windows.Forms.TextBox();
            this.txtPasswordNewOne = new System.Windows.Forms.TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChangedPassword = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.grbAdmin.SuspendLayout();
            this.grbUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAdmin
            // 
            this.grbAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(189)))));
            this.grbAdmin.Controls.Add(this.cboUser);
            this.grbAdmin.Controls.Add(this.btnCancel);
            this.grbAdmin.Controls.Add(this.btnResetPassword);
            this.grbAdmin.Controls.Add(this.label4);
            this.grbAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbAdmin.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAdmin.Location = new System.Drawing.Point(0, 95);
            this.grbAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.grbAdmin.Name = "grbAdmin";
            this.grbAdmin.Padding = new System.Windows.Forms.Padding(5);
            this.grbAdmin.Size = new System.Drawing.Size(830, 205);
            this.grbAdmin.TabIndex = 7;
            this.grbAdmin.TabStop = false;
            this.grbAdmin.Text = "Reset Mật Khẩu";
            // 
            // cboUser
            // 
            this.cboUser.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUser.ForeColor = System.Drawing.Color.Black;
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Khác"});
            this.cboUser.Location = new System.Drawing.Point(301, 45);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(455, 44);
            this.cboUser.TabIndex = 48;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.FillColor2 = System.Drawing.Color.Purple;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(554, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(202, 53);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Exit";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BorderRadius = 15;
            this.btnResetPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnResetPassword.FillColor2 = System.Drawing.Color.Purple;
            this.btnResetPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(301, 122);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(5);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(214, 53);
            this.btnResetPassword.TabIndex = 47;
            this.btnResetPassword.Text = "Reset Mật Khẩu";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Chọn Người Dùng";
            // 
            // grbUser
            // 
            this.grbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(189)))));
            this.grbUser.Controls.Add(this.txtPasswordTwo);
            this.grbUser.Controls.Add(this.txtPasswordNewOne);
            this.grbUser.Controls.Add(this.guna2GradientButton1);
            this.grbUser.Controls.Add(this.btnChangedPassword);
            this.grbUser.Controls.Add(this.label3);
            this.grbUser.Controls.Add(this.label2);
            this.grbUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbUser.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUser.Location = new System.Drawing.Point(0, 300);
            this.grbUser.Margin = new System.Windows.Forms.Padding(5);
            this.grbUser.Name = "grbUser";
            this.grbUser.Padding = new System.Windows.Forms.Padding(5);
            this.grbUser.Size = new System.Drawing.Size(830, 310);
            this.grbUser.TabIndex = 8;
            this.grbUser.TabStop = false;
            this.grbUser.Text = "Đổi Mật Khẩu";
            // 
            // txtPasswordTwo
            // 
            this.txtPasswordTwo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordTwo.Location = new System.Drawing.Point(301, 127);
            this.txtPasswordTwo.Name = "txtPasswordTwo";
            this.txtPasswordTwo.Size = new System.Drawing.Size(455, 44);
            this.txtPasswordTwo.TabIndex = 56;
            // 
            // txtPasswordNewOne
            // 
            this.txtPasswordNewOne.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNewOne.Location = new System.Drawing.Point(301, 45);
            this.txtPasswordNewOne.Name = "txtPasswordNewOne";
            this.txtPasswordNewOne.Size = new System.Drawing.Size(455, 44);
            this.txtPasswordNewOne.TabIndex = 55;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Purple;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(554, 213);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(202, 53);
            this.guna2GradientButton1.TabIndex = 48;
            this.guna2GradientButton1.Text = "Exit";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btnChangedPassword
            // 
            this.btnChangedPassword.BorderRadius = 15;
            this.btnChangedPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChangedPassword.FillColor2 = System.Drawing.Color.Purple;
            this.btnChangedPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangedPassword.ForeColor = System.Drawing.Color.White;
            this.btnChangedPassword.Location = new System.Drawing.Point(301, 213);
            this.btnChangedPassword.Margin = new System.Windows.Forms.Padding(5);
            this.btnChangedPassword.Name = "btnChangedPassword";
            this.btnChangedPassword.Size = new System.Drawing.Size(214, 53);
            this.btnChangedPassword.TabIndex = 48;
            this.btnChangedPassword.Text = "Đổi Mật Khẩu";
            this.btnChangedPassword.Click += new System.EventHandler(this.btnChangedPassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(25, 39);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(167, 36);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "Who";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 87);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Người dùng :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 11);
            this.panel1.TabIndex = 13;
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 10;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // Frm_ChangedPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(111)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(830, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbAdmin);
            this.Controls.Add(this.grbUser);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_ChangedPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ChangedPassword";
            this.Load += new System.EventHandler(this.Frm_ChangedPassword_Load);
            this.grbAdmin.ResumeLayout(false);
            this.grbAdmin.PerformLayout();
            this.grbUser.ResumeLayout(false);
            this.grbUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private Guna.UI2.WinForms.Guna2GradientButton btnResetPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnChangedPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.TextBox txtPasswordTwo;
        private System.Windows.Forms.TextBox txtPasswordNewOne;
    }
}