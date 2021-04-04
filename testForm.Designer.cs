namespace QuanLyTest
{
    partial class testForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
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
            this.panKhach.Controls.Add(this.button1);
            this.panKhach.Controls.Add(this.textSearch);
            this.panKhach.Controls.Add(this.butSua);
            this.panKhach.Controls.Add(this.butThem);
            this.panKhach.Controls.Add(this.butXoa);
            this.panKhach.Controls.Add(this.listKhach);
            this.panKhach.Controls.Add(this.labTieuDe);
            this.panKhach.Location = new System.Drawing.Point(2, 3);
            this.panKhach.Name = "panKhach";
            this.panKhach.Size = new System.Drawing.Size(969, 656);
            this.panKhach.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(29, 75);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(207, 22);
            this.textSearch.TabIndex = 6;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // butSua
            // 
            this.butSua.Location = new System.Drawing.Point(569, 575);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(75, 53);
            this.butSua.TabIndex = 5;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = true;
            // 
            // butThem
            // 
            this.butThem.Location = new System.Drawing.Point(302, 575);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(75, 53);
            this.butThem.TabIndex = 3;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = true;
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(436, 575);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 53);
            this.butXoa.TabIndex = 4;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
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
            this.listKhach.Location = new System.Drawing.Point(10, 119);
            this.listKhach.Name = "listKhach";
            this.listKhach.Size = new System.Drawing.Size(949, 450);
            this.listKhach.TabIndex = 1;
            this.listKhach.UseCompatibleStateImageBehavior = false;
            this.listKhach.View = System.Windows.Forms.View.Details;
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
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 661);
            this.Controls.Add(this.panKhach);
            this.Name = "testForm";
            this.Text = "testForm";
            this.panKhach.ResumeLayout(false);
            this.panKhach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panKhach;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.ListView listKhach;
        private System.Windows.Forms.Label labTieuDe;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button button1;
    }
}