namespace QuanLyTest
{
    partial class deleteForm
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
            this.panDeletaForm = new System.Windows.Forms.Panel();
            this.datePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBirth = new System.Windows.Forms.TextBox();
            this.textCheckIn = new System.Windows.Forms.TextBox();
            this.textSexual = new System.Windows.Forms.TextBox();
            this.textRoomName = new System.Windows.Forms.TextBox();
            this.labRoomName = new System.Windows.Forms.Label();
            this.butComfirm = new System.Windows.Forms.Button();
            this.textIDRoom = new System.Windows.Forms.TextBox();
            this.labCheckIn = new System.Windows.Forms.Label();
            this.labIDRoom = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.textIDGuest = new System.Windows.Forms.TextBox();
            this.labSexual = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.labBirth = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labIDGuest = new System.Windows.Forms.Label();
            this.labTraiDuoi = new System.Windows.Forms.Label();
            this.labTieuDeTraiTren = new System.Windows.Forms.Label();
            this.listGuest = new System.Windows.Forms.ListView();
            this.listRoom = new System.Windows.Forms.ListView();
            this.labTieuDeGues = new System.Windows.Forms.Label();
            this.labTieuDeRoom = new System.Windows.Forms.Label();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.labSearch = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.panDeletaForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDeletaForm
            // 
            this.panDeletaForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panDeletaForm.Controls.Add(this.textSearch);
            this.panDeletaForm.Controls.Add(this.labSearch);
            this.panDeletaForm.Controls.Add(this.datePickerCheckOut);
            this.panDeletaForm.Controls.Add(this.label1);
            this.panDeletaForm.Controls.Add(this.textBirth);
            this.panDeletaForm.Controls.Add(this.textCheckIn);
            this.panDeletaForm.Controls.Add(this.textSexual);
            this.panDeletaForm.Controls.Add(this.textRoomName);
            this.panDeletaForm.Controls.Add(this.labRoomName);
            this.panDeletaForm.Controls.Add(this.butComfirm);
            this.panDeletaForm.Controls.Add(this.textIDRoom);
            this.panDeletaForm.Controls.Add(this.labCheckIn);
            this.panDeletaForm.Controls.Add(this.labIDRoom);
            this.panDeletaForm.Controls.Add(this.textPhone);
            this.panDeletaForm.Controls.Add(this.textAddress);
            this.panDeletaForm.Controls.Add(this.textHoTen);
            this.panDeletaForm.Controls.Add(this.textIDGuest);
            this.panDeletaForm.Controls.Add(this.labSexual);
            this.panDeletaForm.Controls.Add(this.labPhone);
            this.panDeletaForm.Controls.Add(this.labAddress);
            this.panDeletaForm.Controls.Add(this.labBirth);
            this.panDeletaForm.Controls.Add(this.labName);
            this.panDeletaForm.Controls.Add(this.labIDGuest);
            this.panDeletaForm.Controls.Add(this.labTraiDuoi);
            this.panDeletaForm.Controls.Add(this.labTieuDeTraiTren);
            this.panDeletaForm.Controls.Add(this.listGuest);
            this.panDeletaForm.Controls.Add(this.listRoom);
            this.panDeletaForm.Controls.Add(this.labTieuDeGues);
            this.panDeletaForm.Controls.Add(this.labTieuDeRoom);
            this.panDeletaForm.Controls.Add(this.labTieuDe);
            this.panDeletaForm.Location = new System.Drawing.Point(0, 2);
            this.panDeletaForm.Name = "panDeletaForm";
            this.panDeletaForm.Size = new System.Drawing.Size(1036, 789);
            this.panDeletaForm.TabIndex = 0;
            // 
            // datePickerCheckOut
            // 
            this.datePickerCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerCheckOut.Location = new System.Drawing.Point(680, 638);
            this.datePickerCheckOut.MinDate = new System.DateTime(1755, 1, 1, 0, 0, 0, 0);
            this.datePickerCheckOut.Name = "datePickerCheckOut";
            this.datePickerCheckOut.Size = new System.Drawing.Size(200, 22);
            this.datePickerCheckOut.TabIndex = 14;
            this.datePickerCheckOut.Value = new System.DateTime(2021, 3, 30, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 643);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ngày  Trả Phòng :";
            // 
            // textBirth
            // 
            this.textBirth.Enabled = false;
            this.textBirth.Location = new System.Drawing.Point(680, 218);
            this.textBirth.Name = "textBirth";
            this.textBirth.Size = new System.Drawing.Size(225, 22);
            this.textBirth.TabIndex = 7;
            // 
            // textCheckIn
            // 
            this.textCheckIn.Enabled = false;
            this.textCheckIn.Location = new System.Drawing.Point(680, 594);
            this.textCheckIn.Name = "textCheckIn";
            this.textCheckIn.Size = new System.Drawing.Size(225, 22);
            this.textCheckIn.TabIndex = 13;
            // 
            // textSexual
            // 
            this.textSexual.Enabled = false;
            this.textSexual.Location = new System.Drawing.Point(680, 413);
            this.textSexual.Name = "textSexual";
            this.textSexual.Size = new System.Drawing.Size(225, 22);
            this.textSexual.TabIndex = 10;
            // 
            // textRoomName
            // 
            this.textRoomName.Enabled = false;
            this.textRoomName.Location = new System.Drawing.Point(680, 547);
            this.textRoomName.Name = "textRoomName";
            this.textRoomName.Size = new System.Drawing.Size(221, 22);
            this.textRoomName.TabIndex = 12;
            // 
            // labRoomName
            // 
            this.labRoomName.AutoSize = true;
            this.labRoomName.Location = new System.Drawing.Point(588, 550);
            this.labRoomName.Name = "labRoomName";
            this.labRoomName.Size = new System.Drawing.Size(86, 17);
            this.labRoomName.TabIndex = 16;
            this.labRoomName.Text = "Tên Phòng :";
            // 
            // butComfirm
            // 
            this.butComfirm.Location = new System.Drawing.Point(711, 700);
            this.butComfirm.Name = "butComfirm";
            this.butComfirm.Size = new System.Drawing.Size(135, 79);
            this.butComfirm.TabIndex = 15;
            this.butComfirm.Text = "Xác Nhận";
            this.butComfirm.UseVisualStyleBackColor = true;
            this.butComfirm.Click += new System.EventHandler(this.butComfirm_Click);
            // 
            // textIDRoom
            // 
            this.textIDRoom.Enabled = false;
            this.textIDRoom.Location = new System.Drawing.Point(680, 499);
            this.textIDRoom.Name = "textIDRoom";
            this.textIDRoom.Size = new System.Drawing.Size(221, 22);
            this.textIDRoom.TabIndex = 11;
            // 
            // labCheckIn
            // 
            this.labCheckIn.AutoSize = true;
            this.labCheckIn.Location = new System.Drawing.Point(559, 597);
            this.labCheckIn.Name = "labCheckIn";
            this.labCheckIn.Size = new System.Drawing.Size(115, 17);
            this.labCheckIn.TabIndex = 12;
            this.labCheckIn.Text = "Ngày Vào Thuê :";
            // 
            // labIDRoom
            // 
            this.labIDRoom.AutoSize = true;
            this.labIDRoom.Location = new System.Drawing.Point(600, 502);
            this.labIDRoom.Name = "labIDRoom";
            this.labIDRoom.Size = new System.Drawing.Size(74, 17);
            this.labIDRoom.TabIndex = 11;
            this.labIDRoom.Text = "ID Phòng :";
            // 
            // textPhone
            // 
            this.textPhone.Enabled = false;
            this.textPhone.Location = new System.Drawing.Point(680, 367);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(225, 22);
            this.textPhone.TabIndex = 9;
            // 
            // textAddress
            // 
            this.textAddress.Enabled = false;
            this.textAddress.Location = new System.Drawing.Point(680, 270);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(344, 81);
            this.textAddress.TabIndex = 8;
            // 
            // textHoTen
            // 
            this.textHoTen.Enabled = false;
            this.textHoTen.Location = new System.Drawing.Point(680, 170);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(344, 22);
            this.textHoTen.TabIndex = 6;
            // 
            // textIDGuest
            // 
            this.textIDGuest.Enabled = false;
            this.textIDGuest.Location = new System.Drawing.Point(680, 121);
            this.textIDGuest.Name = "textIDGuest";
            this.textIDGuest.Size = new System.Drawing.Size(221, 22);
            this.textIDGuest.TabIndex = 5;
            // 
            // labSexual
            // 
            this.labSexual.AutoSize = true;
            this.labSexual.Location = new System.Drawing.Point(601, 413);
            this.labSexual.Name = "labSexual";
            this.labSexual.Size = new System.Drawing.Size(73, 17);
            this.labSexual.TabIndex = 10;
            this.labSexual.Text = "Giới Tính :";
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(568, 370);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(106, 17);
            this.labPhone.TabIndex = 9;
            this.labPhone.Text = "Số Điện Thoại :";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(613, 273);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(61, 17);
            this.labAddress.TabIndex = 8;
            this.labAddress.Text = "Địa Chỉ :";
            // 
            // labBirth
            // 
            this.labBirth.AutoSize = true;
            this.labBirth.Location = new System.Drawing.Point(593, 221);
            this.labBirth.Name = "labBirth";
            this.labBirth.Size = new System.Drawing.Size(81, 17);
            this.labBirth.TabIndex = 7;
            this.labBirth.Text = "Ngày Sinh :";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(611, 173);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(63, 17);
            this.labName.TabIndex = 6;
            this.labName.Text = "Họ Tên :";
            // 
            // labIDGuest
            // 
            this.labIDGuest.AutoSize = true;
            this.labIDGuest.Location = new System.Drawing.Point(603, 124);
            this.labIDGuest.Name = "labIDGuest";
            this.labIDGuest.Size = new System.Drawing.Size(71, 17);
            this.labIDGuest.TabIndex = 5;
            this.labIDGuest.Text = "ID khách :";
            // 
            // labTraiDuoi
            // 
            this.labTraiDuoi.AutoSize = true;
            this.labTraiDuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTraiDuoi.Location = new System.Drawing.Point(663, 461);
            this.labTraiDuoi.Name = "labTraiDuoi";
            this.labTraiDuoi.Size = new System.Drawing.Size(200, 29);
            this.labTraiDuoi.TabIndex = 4;
            this.labTraiDuoi.Text = "Thông Tin Thuê";
            // 
            // labTieuDeTraiTren
            // 
            this.labTieuDeTraiTren.AutoSize = true;
            this.labTieuDeTraiTren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDeTraiTren.Location = new System.Drawing.Point(663, 74);
            this.labTieuDeTraiTren.Name = "labTieuDeTraiTren";
            this.labTieuDeTraiTren.Size = new System.Drawing.Size(279, 29);
            this.labTieuDeTraiTren.TabIndex = 3;
            this.labTieuDeTraiTren.Text = "Thông Tin Khách Thuê";
            // 
            // listGuest
            // 
            this.listGuest.FullRowSelect = true;
            this.listGuest.GridLines = true;
            this.listGuest.HideSelection = false;
            this.listGuest.Location = new System.Drawing.Point(12, 524);
            this.listGuest.Name = "listGuest";
            this.listGuest.Size = new System.Drawing.Size(519, 255);
            this.listGuest.TabIndex = 4;
            this.listGuest.UseCompatibleStateImageBehavior = false;
            this.listGuest.View = System.Windows.Forms.View.Details;
            this.listGuest.SelectedIndexChanged += new System.EventHandler(this.listGuest_SelectedIndexChanged);
            // 
            // listRoom
            // 
            this.listRoom.FullRowSelect = true;
            this.listRoom.GridLines = true;
            this.listRoom.HideSelection = false;
            this.listRoom.Location = new System.Drawing.Point(17, 146);
            this.listRoom.Name = "listRoom";
            this.listRoom.Size = new System.Drawing.Size(519, 325);
            this.listRoom.TabIndex = 1;
            this.listRoom.UseCompatibleStateImageBehavior = false;
            this.listRoom.View = System.Windows.Forms.View.Details;
            this.listRoom.SelectedIndexChanged += new System.EventHandler(this.listRoom_SelectedIndexChanged);
            // 
            // labTieuDeGues
            // 
            this.labTieuDeGues.AutoSize = true;
            this.labTieuDeGues.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDeGues.Location = new System.Drawing.Point(26, 492);
            this.labTieuDeGues.Name = "labTieuDeGues";
            this.labTieuDeGues.Size = new System.Drawing.Size(329, 29);
            this.labTieuDeGues.TabIndex = 2;
            this.labTieuDeGues.Text = "Danh sách khách trong phòng";
            // 
            // labTieuDeRoom
            // 
            this.labTieuDeRoom.AutoSize = true;
            this.labTieuDeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDeRoom.Location = new System.Drawing.Point(12, 74);
            this.labTieuDeRoom.Name = "labTieuDeRoom";
            this.labTieuDeRoom.Size = new System.Drawing.Size(343, 29);
            this.labTieuDeRoom.TabIndex = 1;
            this.labTieuDeRoom.Text = "Danh sách phòng đã được thuê";
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(380, 7);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(190, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "TRẢ PHÒNG";
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(14, 121);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(74, 17);
            this.labSearch.TabIndex = 18;
            this.labSearch.Text = "Tìm Kiếm :";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(94, 118);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(223, 22);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // deleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 793);
            this.Controls.Add(this.panDeletaForm);
            this.Name = "deleteForm";
            this.Text = "deleteForm";
            this.panDeletaForm.ResumeLayout(false);
            this.panDeletaForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panDeletaForm;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Label labTieuDeTraiTren;
        private System.Windows.Forms.ListView listGuest;
        private System.Windows.Forms.ListView listRoom;
        private System.Windows.Forms.Label labTieuDeGues;
        private System.Windows.Forms.Label labTieuDeRoom;
        private System.Windows.Forms.Label labSexual;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Label labBirth;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labIDGuest;
        private System.Windows.Forms.Label labTraiDuoi;
        private System.Windows.Forms.TextBox textIDGuest;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textIDRoom;
        private System.Windows.Forms.Label labCheckIn;
        private System.Windows.Forms.Label labIDRoom;
        private System.Windows.Forms.Button butComfirm;
        private System.Windows.Forms.TextBox textRoomName;
        private System.Windows.Forms.Label labRoomName;
        private System.Windows.Forms.TextBox textSexual;
        private System.Windows.Forms.TextBox textBirth;
        private System.Windows.Forms.TextBox textCheckIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerCheckOut;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox textSearch;
    }
}