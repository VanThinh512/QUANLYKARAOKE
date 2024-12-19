namespace QUANLY_KARAOKE_PROJECT
{
    partial class ChuyenPhongDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuyenPhongDialog));
            this.cmb_phong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_chapnhan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_phong
            // 
            this.cmb_phong.BackColor = System.Drawing.Color.Transparent;
            this.cmb_phong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_phong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_phong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_phong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_phong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_phong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_phong.ItemHeight = 30;
            this.cmb_phong.Location = new System.Drawing.Point(474, 229);
            this.cmb_phong.Name = "cmb_phong";
            this.cmb_phong.Size = new System.Drawing.Size(438, 36);
            this.cmb_phong.TabIndex = 35;
            // 
            // btn_huy
            // 
            this.btn_huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_huy.FillColor = System.Drawing.Color.Black;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(732, 350);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(180, 45);
            this.btn_huy.TabIndex = 34;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_chapnhan
            // 
            this.btn_chapnhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_chapnhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_chapnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_chapnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_chapnhan.FillColor = System.Drawing.Color.Black;
            this.btn_chapnhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chapnhan.ForeColor = System.Drawing.Color.White;
            this.btn_chapnhan.Location = new System.Drawing.Point(474, 350);
            this.btn_chapnhan.Name = "btn_chapnhan";
            this.btn_chapnhan.Size = new System.Drawing.Size(180, 45);
            this.btn_chapnhan.TabIndex = 33;
            this.btn_chapnhan.Text = "Chấp nhận";
            this.btn_chapnhan.Click += new System.EventHandler(this.btn_chapnhan_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(474, 174);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(311, 33);
            this.guna2HtmlLabel4.TabIndex = 32;
            this.guna2HtmlLabel4.Text = "Chọn phòng để chuyển:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(234, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 221);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // ChuyenPhongDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 569);
            this.Controls.Add(this.cmb_phong);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_chapnhan);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChuyenPhongDialog";
            this.Text = "ChuyenPhongDialog";
            this.Load += new System.EventHandler(this.ChuyenPhongDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmb_phong;
        private Guna.UI2.WinForms.Guna2Button btn_huy;
        private Guna.UI2.WinForms.Guna2Button btn_chapnhan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}