﻿namespace QuanLyTest
{
    partial class rangeForm
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
            this.panRange = new System.Windows.Forms.Panel();
            this.labPage = new System.Windows.Forms.Label();
            this.butRight = new System.Windows.Forms.Button();
            this.butLeft = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.butClear = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.buttUpdate = new System.Windows.Forms.Button();
            this.textRangeName = new System.Windows.Forms.TextBox();
            this.textIDRange = new System.Windows.Forms.TextBox();
            this.labRangeName = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.listRange = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.panRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // panRange
            // 
            this.panRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panRange.Controls.Add(this.labPage);
            this.panRange.Controls.Add(this.butRight);
            this.panRange.Controls.Add(this.butLeft);
            this.panRange.Controls.Add(this.textSearch);
            this.panRange.Controls.Add(this.labSearch);
            this.panRange.Controls.Add(this.butClear);
            this.panRange.Controls.Add(this.butDelete);
            this.panRange.Controls.Add(this.buttUpdate);
            this.panRange.Controls.Add(this.textRangeName);
            this.panRange.Controls.Add(this.textIDRange);
            this.panRange.Controls.Add(this.labRangeName);
            this.panRange.Controls.Add(this.labID);
            this.panRange.Controls.Add(this.listRange);
            this.panRange.Controls.Add(this.labTieuDe);
            this.panRange.Location = new System.Drawing.Point(-1, 4);
            this.panRange.Name = "panRange";
            this.panRange.Size = new System.Drawing.Size(910, 618);
            this.panRange.TabIndex = 0;
            // 
            // labPage
            // 
            this.labPage.AutoSize = true;
            this.labPage.Location = new System.Drawing.Point(184, 543);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(70, 17);
            this.labPage.TabIndex = 11;
            this.labPage.Text = "Trang 0/0";
            // 
            // butRight
            // 
            this.butRight.AutoSize = true;
            this.butRight.Location = new System.Drawing.Point(301, 538);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(75, 27);
            this.butRight.TabIndex = 2;
            this.butRight.Text = "Phải";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // butLeft
            // 
            this.butLeft.AutoSize = true;
            this.butLeft.Location = new System.Drawing.Point(52, 538);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(75, 27);
            this.butLeft.TabIndex = 1;
            this.butLeft.Text = "Trái";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(627, 62);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(167, 22);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(492, 67);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(74, 17);
            this.labSearch.TabIndex = 7;
            this.labSearch.Text = "Tìm Kiếm :";
            // 
            // butClear
            // 
            this.butClear.AutoSize = true;
            this.butClear.Location = new System.Drawing.Point(765, 321);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(104, 64);
            this.butClear.TabIndex = 8;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butDelete
            // 
            this.butDelete.AutoSize = true;
            this.butDelete.Location = new System.Drawing.Point(588, 321);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(104, 64);
            this.butDelete.TabIndex = 7;
            this.butDelete.Text = "Xóa";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // buttUpdate
            // 
            this.buttUpdate.AutoSize = true;
            this.buttUpdate.Location = new System.Drawing.Point(418, 321);
            this.buttUpdate.Name = "buttUpdate";
            this.buttUpdate.Size = new System.Drawing.Size(104, 64);
            this.buttUpdate.TabIndex = 6;
            this.buttUpdate.Text = "Cập Nhật";
            this.buttUpdate.UseVisualStyleBackColor = true;
            this.buttUpdate.Click += new System.EventHandler(this.buttUpdate_Click);
            // 
            // textRangeName
            // 
            this.textRangeName.Location = new System.Drawing.Point(627, 211);
            this.textRangeName.Name = "textRangeName";
            this.textRangeName.Size = new System.Drawing.Size(167, 22);
            this.textRangeName.TabIndex = 5;
            // 
            // textIDRange
            // 
            this.textIDRange.Enabled = false;
            this.textIDRange.Location = new System.Drawing.Point(627, 135);
            this.textIDRange.Name = "textIDRange";
            this.textIDRange.Size = new System.Drawing.Size(161, 22);
            this.textIDRange.TabIndex = 4;
            // 
            // labRangeName
            // 
            this.labRangeName.AutoSize = true;
            this.labRangeName.Location = new System.Drawing.Point(468, 214);
            this.labRangeName.Name = "labRangeName";
            this.labRangeName.Size = new System.Drawing.Size(98, 17);
            this.labRangeName.TabIndex = 3;
            this.labRangeName.Text = "Tên Khu Vực :";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(537, 138);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(29, 17);
            this.labID.TabIndex = 2;
            this.labID.Text = "ID :";
            // 
            // listRange
            // 
            this.listRange.FullRowSelect = true;
            this.listRange.GridLines = true;
            this.listRange.HideSelection = false;
            this.listRange.Location = new System.Drawing.Point(52, 67);
            this.listRange.Name = "listRange";
            this.listRange.Size = new System.Drawing.Size(324, 465);
            this.listRange.TabIndex = 0;
            this.listRange.UseCompatibleStateImageBehavior = false;
            this.listRange.View = System.Windows.Forms.View.Details;
            this.listRange.SelectedIndexChanged += new System.EventHandler(this.listRange_SelectedIndexChanged);
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(272, 5);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(316, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "THÔNG TIN KHU VỰC";
            // 
            // rangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 621);
            this.Controls.Add(this.panRange);
            this.Name = "rangeForm";
            this.Text = "rangeForm";
            this.panRange.ResumeLayout(false);
            this.panRange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panRange;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button buttUpdate;
        private System.Windows.Forms.TextBox textRangeName;
        private System.Windows.Forms.TextBox textIDRange;
        private System.Windows.Forms.Label labRangeName;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.ListView listRange;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Button butRight;
        private System.Windows.Forms.Label labPage;
    }
}