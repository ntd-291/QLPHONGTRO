﻿namespace QuanLyTest
{
    partial class guestForm
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
            this.panKhach = new System.Windows.Forms.Panel();
            this.labPage = new System.Windows.Forms.Label();
            this.butLeft = new System.Windows.Forms.Button();
            this.butRight = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.butSua = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.listKhach = new System.Windows.Forms.ListView();
            this.labTieuDe = new System.Windows.Forms.Label();
            this.panKhach.SuspendLayout();
            this.SuspendLayout();
            // 
            // panKhach
            // 
            this.panKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panKhach.Controls.Add(this.labPage);
            this.panKhach.Controls.Add(this.butLeft);
            this.panKhach.Controls.Add(this.butRight);
            this.panKhach.Controls.Add(this.textSearch);
            this.panKhach.Controls.Add(this.labSearch);
            this.panKhach.Controls.Add(this.butSua);
            this.panKhach.Controls.Add(this.butThem);
            this.panKhach.Controls.Add(this.butXoa);
            this.panKhach.Controls.Add(this.listKhach);
            this.panKhach.Controls.Add(this.labTieuDe);
            this.panKhach.Location = new System.Drawing.Point(2, 2);
            this.panKhach.Name = "panKhach";
            this.panKhach.Size = new System.Drawing.Size(969, 656);
            this.panKhach.TabIndex = 0;
            // 
            // labPage
            // 
            this.labPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labPage.AutoSize = true;
            this.labPage.Location = new System.Drawing.Point(452, 537);
            this.labPage.Name = "labPage";
            this.labPage.Size = new System.Drawing.Size(70, 17);
            this.labPage.TabIndex = 9;
            this.labPage.Text = "Trang 0/0";
            // 
            // butLeft
            // 
            this.butLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butLeft.AutoSize = true;
            this.butLeft.Location = new System.Drawing.Point(10, 531);
            this.butLeft.Name = "butLeft";
            this.butLeft.Size = new System.Drawing.Size(75, 27);
            this.butLeft.TabIndex = 2;
            this.butLeft.Text = "Trái";
            this.butLeft.UseVisualStyleBackColor = true;
            this.butLeft.Click += new System.EventHandler(this.butLeft_Click);
            // 
            // butRight
            // 
            this.butRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butRight.AutoSize = true;
            this.butRight.Location = new System.Drawing.Point(884, 527);
            this.butRight.Name = "butRight";
            this.butRight.Size = new System.Drawing.Size(75, 27);
            this.butRight.TabIndex = 3;
            this.butRight.Text = "Phải";
            this.butRight.UseVisualStyleBackColor = true;
            this.butRight.Click += new System.EventHandler(this.butRight_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(116, 70);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(223, 22);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(36, 73);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(74, 17);
            this.labSearch.TabIndex = 6;
            this.labSearch.Text = "Tìm Kiếm :";
            // 
            // butSua
            // 
            this.butSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butSua.AutoSize = true;
            this.butSua.Location = new System.Drawing.Point(569, 575);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(75, 53);
            this.butSua.TabIndex = 6;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = true;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butThem
            // 
            this.butThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butThem.AutoSize = true;
            this.butThem.Location = new System.Drawing.Point(302, 575);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(75, 53);
            this.butThem.TabIndex = 4;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = true;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butXoa
            // 
            this.butXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butXoa.AutoSize = true;
            this.butXoa.Location = new System.Drawing.Point(436, 575);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 53);
            this.butXoa.TabIndex = 5;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // listKhach
            // 
            this.listKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listKhach.FullRowSelect = true;
            this.listKhach.GridLines = true;
            this.listKhach.HideSelection = false;
            this.listKhach.LabelEdit = true;
            this.listKhach.Location = new System.Drawing.Point(10, 113);
            this.listKhach.Name = "listKhach";
            this.listKhach.Size = new System.Drawing.Size(949, 412);
            this.listKhach.TabIndex = 1;
            this.listKhach.UseCompatibleStateImageBehavior = false;
            this.listKhach.View = System.Windows.Forms.View.Details;
            this.listKhach.DoubleClick += new System.EventHandler(this.listKhach_DoubleClick);
            // 
            // labTieuDe
            // 
            this.labTieuDe.AutoSize = true;
            this.labTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTieuDe.Location = new System.Drawing.Point(314, 7);
            this.labTieuDe.Name = "labTieuDe";
            this.labTieuDe.Size = new System.Drawing.Size(369, 32);
            this.labTieuDe.TabIndex = 0;
            this.labTieuDe.Text = "DANH SÁCH KHÁCH TRỌ";
            // 
            // guestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 659);
            this.Controls.Add(this.panKhach);
            this.Name = "guestForm";
            this.Text = "Form1";
            this.panKhach.ResumeLayout(false);
            this.panKhach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panKhach;
        private System.Windows.Forms.ListView listKhach;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Label labPage;
        private System.Windows.Forms.Button butLeft;
        private System.Windows.Forms.Button butRight;
    }
}

