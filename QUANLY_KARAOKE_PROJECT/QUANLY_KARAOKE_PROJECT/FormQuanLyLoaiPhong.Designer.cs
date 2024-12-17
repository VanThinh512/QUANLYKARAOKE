namespace QUANLY_KARAOKE_PROJECT
{
    partial class FormQuanLyLoaiPhong
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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.txt_TenPhong = new System.Windows.Forms.TextBox();
            this.txt_IDPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_LoaiPhong = new System.Windows.Forms.DataGridView();
            this.Column_IDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(403, 286);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(78, 26);
            this.btn_Sua.TabIndex = 19;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(403, 246);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 18;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(403, 208);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 17;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(197, 296);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(100, 22);
            this.txt_Gia.TabIndex = 16;
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.Location = new System.Drawing.Point(197, 250);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Size = new System.Drawing.Size(100, 22);
            this.txt_TenPhong.TabIndex = 15;
            // 
            // txt_IDPhong
            // 
            this.txt_IDPhong.Location = new System.Drawing.Point(197, 205);
            this.txt_IDPhong.Name = "txt_IDPhong";
            this.txt_IDPhong.Size = new System.Drawing.Size(100, 22);
            this.txt_IDPhong.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // dataGridView_LoaiPhong
            // 
            this.dataGridView_LoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_IDPhong,
            this.Column_TenPhong,
            this.Column_Gia});
            this.dataGridView_LoaiPhong.Location = new System.Drawing.Point(60, 39);
            this.dataGridView_LoaiPhong.Name = "dataGridView_LoaiPhong";
            this.dataGridView_LoaiPhong.RowHeadersWidth = 51;
            this.dataGridView_LoaiPhong.RowTemplate.Height = 24;
            this.dataGridView_LoaiPhong.Size = new System.Drawing.Size(496, 133);
            this.dataGridView_LoaiPhong.TabIndex = 10;
            // 
            // Column_IDPhong
            // 
            this.Column_IDPhong.HeaderText = "ID";
            this.Column_IDPhong.MinimumWidth = 6;
            this.Column_IDPhong.Name = "Column_IDPhong";
            this.Column_IDPhong.Width = 125;
            // 
            // Column_TenPhong
            // 
            this.Column_TenPhong.HeaderText = "Tên Phòng";
            this.Column_TenPhong.MinimumWidth = 6;
            this.Column_TenPhong.Name = "Column_TenPhong";
            this.Column_TenPhong.Width = 125;
            // 
            // Column_Gia
            // 
            this.Column_Gia.HeaderText = "Giá";
            this.Column_Gia.MinimumWidth = 6;
            this.Column_Gia.Name = "Column_Gia";
            this.Column_Gia.Width = 125;
            // 
            // FormQuanLyLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 353);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Gia);
            this.Controls.Add(this.txt_TenPhong);
            this.Controls.Add(this.txt_IDPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_LoaiPhong);
            this.Name = "FormQuanLyLoaiPhong";
            this.Text = "FormQuanLyLoaiPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.TextBox txt_TenPhong;
        private System.Windows.Forms.TextBox txt_IDPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IDPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Gia;
    }
}