namespace ToanvaTrung_PhanMemQuanLySinhVien_19CT112
{
    partial class Frm_ThemNguoiDung
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
            this.lblErr = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.cboUserType = new System.Windows.Forms.ComboBox();
            this.ckbRemember = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErr
            // 
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(33, 28);
            this.lblErr.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 36);
            this.label6.TabIndex = 32;
            this.label6.Text = "User type:";
            // 
            // cboUserType
            // 
            this.cboUserType.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUserType.ForeColor = System.Drawing.Color.Black;
            this.cboUserType.FormattingEnabled = true;
            this.cboUserType.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Khác"});
            this.cboUserType.Location = new System.Drawing.Point(292, 467);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(504, 44);
            this.cboUserType.TabIndex = 31;
            // 
            // ckbRemember
            // 
            this.ckbRemember.AutoSize = true;
            this.ckbRemember.Checked = true;
            this.ckbRemember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbRemember.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRemember.Location = new System.Drawing.Point(292, 389);
            this.ckbRemember.Name = "ckbRemember";
            this.ckbRemember.Size = new System.Drawing.Size(91, 40);
            this.ckbRemember.TabIndex = 30;
            this.ckbRemember.Text = "Nhớ";
            this.ckbRemember.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 36);
            this.label5.TabIndex = 28;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 36);
            this.label4.TabIndex = 26;
            this.label4.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 36);
            this.label3.TabIndex = 22;
            this.label3.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 36);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(111)))), ((int)(((byte)(228)))));
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblErr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(939, 34);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(939, 56);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thêm Người Dùng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCancel.FillColor2 = System.Drawing.Color.Purple;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(605, 546);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(191, 55);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.FillColor2 = System.Drawing.Color.Purple;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(292, 546);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 55);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Thêm";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 5;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(292, 93);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(504, 44);
            this.txtID.TabIndex = 51;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(292, 166);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(504, 44);
            this.txtFullName.TabIndex = 52;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(292, 239);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(504, 44);
            this.txtUserName.TabIndex = 53;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(292, 312);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(504, 44);
            this.txtPassWord.TabIndex = 54;
            // 
            // Frm_ThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(34)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(939, 687);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboUserType);
            this.Controls.Add(this.ckbRemember);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ThemNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_User_Modified";
            this.Load += new System.EventHandler(this.Frm_ThemNguoiDung_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel lblErr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboUserType;
        private System.Windows.Forms.CheckBox ckbRemember;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtID;
    }
}