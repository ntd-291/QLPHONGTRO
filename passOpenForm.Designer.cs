namespace QuanLyTest
{
    partial class passOpenForm
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
            this.panPassOpen = new System.Windows.Forms.Panel();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.labTen = new System.Windows.Forms.Label();
            this.labUser = new System.Windows.Forms.Label();
            this.labOldPass = new System.Windows.Forms.Label();
            this.labNewPass = new System.Windows.Forms.Label();
            this.labPrePass = new System.Windows.Forms.Label();
            this.textStaffName = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textOldPass = new System.Windows.Forms.TextBox();
            this.textNewPass = new System.Windows.Forms.TextBox();
            this.textPrePass = new System.Windows.Forms.TextBox();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butShow1 = new System.Windows.Forms.Button();
            this.butShow2 = new System.Windows.Forms.Button();
            this.panPassOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panPassOpen
            // 
            this.panPassOpen.Controls.Add(this.butShow2);
            this.panPassOpen.Controls.Add(this.butShow1);
            this.panPassOpen.Controls.Add(this.butExit);
            this.panPassOpen.Controls.Add(this.butUpdate);
            this.panPassOpen.Controls.Add(this.textPrePass);
            this.panPassOpen.Controls.Add(this.textNewPass);
            this.panPassOpen.Controls.Add(this.textOldPass);
            this.panPassOpen.Controls.Add(this.textUserName);
            this.panPassOpen.Controls.Add(this.textStaffName);
            this.panPassOpen.Controls.Add(this.labPrePass);
            this.panPassOpen.Controls.Add(this.labNewPass);
            this.panPassOpen.Controls.Add(this.labOldPass);
            this.panPassOpen.Controls.Add(this.labUser);
            this.panPassOpen.Controls.Add(this.labTen);
            this.panPassOpen.Controls.Add(this.labTieuDe);
            this.panPassOpen.Location = new System.Drawing.Point(1, 0);
            this.panPassOpen.Name = "panPassOpen";
            this.panPassOpen.Size = new System.Drawing.Size(684, 426);
            this.panPassOpen.TabIndex = 0;
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(136, 9);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(365, 32);
            this.labTieuDe.TabIndex = 1;
            this.labTieuDe.Text = "ĐỔI MẬT KHẨU QUẢN LÝ";
            // 
            // labTen
            // 
            this.labTen.AutoSize = true;
            this.labTen.Location = new System.Drawing.Point(86, 69);
            this.labTen.Name = "labTen";
            this.labTen.Size = new System.Drawing.Size(99, 17);
            this.labTen.TabIndex = 2;
            this.labTen.Text = "Tên Quản Lý :";
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(105, 111);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(75, 17);
            this.labUser.TabIndex = 3;
            this.labUser.Text = "Tên User :";
            // 
            // labOldPass
            // 
            this.labOldPass.AutoSize = true;
            this.labOldPass.Location = new System.Drawing.Point(86, 152);
            this.labOldPass.Name = "labOldPass";
            this.labOldPass.Size = new System.Drawing.Size(97, 17);
            this.labOldPass.TabIndex = 4;
            this.labOldPass.Text = "Mật Khẩu Cũ :";
            // 
            // labNewPass
            // 
            this.labNewPass.AutoSize = true;
            this.labNewPass.Location = new System.Drawing.Point(80, 196);
            this.labNewPass.Name = "labNewPass";
            this.labNewPass.Size = new System.Drawing.Size(100, 17);
            this.labNewPass.TabIndex = 5;
            this.labNewPass.Text = "Mật khẩu Mới :";
            // 
            // labPrePass
            // 
            this.labPrePass.AutoSize = true;
            this.labPrePass.Location = new System.Drawing.Point(43, 238);
            this.labPrePass.Name = "labPrePass";
            this.labPrePass.Size = new System.Drawing.Size(137, 17);
            this.labPrePass.TabIndex = 6;
            this.labPrePass.Text = "Nhập Lại Mật Khẩu :";
            // 
            // textStaffName
            // 
            this.textStaffName.Enabled = false;
            this.textStaffName.Location = new System.Drawing.Point(225, 66);
            this.textStaffName.Name = "textStaffName";
            this.textStaffName.Size = new System.Drawing.Size(199, 22);
            this.textStaffName.TabIndex = 1;
            // 
            // textUserName
            // 
            this.textUserName.Enabled = false;
            this.textUserName.Location = new System.Drawing.Point(225, 108);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(199, 22);
            this.textUserName.TabIndex = 2;
            // 
            // textOldPass
            // 
            this.textOldPass.Location = new System.Drawing.Point(225, 149);
            this.textOldPass.Name = "textOldPass";
            this.textOldPass.Size = new System.Drawing.Size(199, 22);
            this.textOldPass.TabIndex = 3;
            this.textOldPass.UseSystemPasswordChar = true;
            // 
            // textNewPass
            // 
            this.textNewPass.Location = new System.Drawing.Point(225, 193);
            this.textNewPass.Name = "textNewPass";
            this.textNewPass.Size = new System.Drawing.Size(199, 22);
            this.textNewPass.TabIndex = 5;
            this.textNewPass.UseSystemPasswordChar = true;
            // 
            // textPrePass
            // 
            this.textPrePass.Location = new System.Drawing.Point(225, 235);
            this.textPrePass.Name = "textPrePass";
            this.textPrePass.Size = new System.Drawing.Size(199, 22);
            this.textPrePass.TabIndex = 7;
            this.textPrePass.UseSystemPasswordChar = true;
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(159, 284);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(98, 60);
            this.butUpdate.TabIndex = 8;
            this.butUpdate.Text = "Cập Nhật";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(361, 284);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(98, 60);
            this.butExit.TabIndex = 9;
            this.butExit.Text = "Thoát";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butShow1
            // 
            this.butShow1.Location = new System.Drawing.Point(430, 149);
            this.butShow1.Name = "butShow1";
            this.butShow1.Size = new System.Drawing.Size(75, 23);
            this.butShow1.TabIndex = 4;
            this.butShow1.Text = "hiển thị";
            this.butShow1.UseVisualStyleBackColor = true;
            this.butShow1.Click += new System.EventHandler(this.butShow1_Click);
            // 
            // butShow2
            // 
            this.butShow2.Location = new System.Drawing.Point(430, 193);
            this.butShow2.Name = "butShow2";
            this.butShow2.Size = new System.Drawing.Size(75, 23);
            this.butShow2.TabIndex = 6;
            this.butShow2.Text = "hiển thị";
            this.butShow2.UseVisualStyleBackColor = true;
            this.butShow2.Click += new System.EventHandler(this.butShow2_Click);
            // 
            // passOpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 429);
            this.Controls.Add(this.panPassOpen);
            this.Name = "passOpenForm";
            this.Text = "passOpenForm";
            this.panPassOpen.ResumeLayout(false);
            this.panPassOpen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panPassOpen;
        private System.Windows.Forms.Label labPrePass;
        private System.Windows.Forms.Label labNewPass;
        private System.Windows.Forms.Label labOldPass;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labTen;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.TextBox textPrePass;
        private System.Windows.Forms.TextBox textNewPass;
        private System.Windows.Forms.TextBox textOldPass;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textStaffName;
        private System.Windows.Forms.Button butShow2;
        private System.Windows.Forms.Button butShow1;
    }
}