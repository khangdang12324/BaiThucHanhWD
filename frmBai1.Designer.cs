namespace BaiTapThietKeForm
{
	partial class frmBai1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdTrang = new System.Windows.Forms.RadioButton();
			this.rdDo = new System.Windows.Forms.RadioButton();
			this.rdXanh = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDonGia = new System.Windows.Forms.TextBox();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblSoTien = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(102, 94);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(227, 226);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdTrang);
			this.groupBox1.Controls.Add(this.rdDo);
			this.groupBox1.Controls.Add(this.rdXanh);
			this.groupBox1.Location = new System.Drawing.Point(458, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(253, 173);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chọn màu xe";
			// 
			// rdTrang
			// 
			this.rdTrang.AutoSize = true;
			this.rdTrang.Location = new System.Drawing.Point(29, 133);
			this.rdTrang.Name = "rdTrang";
			this.rdTrang.Size = new System.Drawing.Size(75, 24);
			this.rdTrang.TabIndex = 0;
			this.rdTrang.Text = "Trắng";
			this.rdTrang.UseVisualStyleBackColor = true;
			this.rdTrang.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
			// 
			// rdDo
			// 
			this.rdDo.AutoSize = true;
			this.rdDo.Location = new System.Drawing.Point(29, 90);
			this.rdDo.Name = "rdDo";
			this.rdDo.Size = new System.Drawing.Size(55, 24);
			this.rdDo.TabIndex = 0;
			this.rdDo.Text = "Đỏ";
			this.rdDo.UseVisualStyleBackColor = true;
			this.rdDo.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
			// 
			// rdXanh
			// 
			this.rdXanh.AutoSize = true;
			this.rdXanh.Checked = true;
			this.rdXanh.Location = new System.Drawing.Point(29, 42);
			this.rdXanh.Name = "rdXanh";
			this.rdXanh.Size = new System.Drawing.Size(72, 24);
			this.rdXanh.TabIndex = 0;
			this.rdXanh.TabStop = true;
			this.rdXanh.Text = "Xanh";
			this.rdXanh.UseVisualStyleBackColor = true;
			this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(465, 246);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Đơn giá";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(704, 246);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "$";
			this.label3.Click += new System.EventHandler(this.label1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(463, 246);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 25);
			this.label4.TabIndex = 2;
			this.label4.Text = "Đơn giá";
			this.label4.Click += new System.EventHandler(this.label1_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(463, 290);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 25);
			this.label6.TabIndex = 2;
			this.label6.Text = "Số lượng";
			this.label6.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtDonGia
			// 
			this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDonGia.Location = new System.Drawing.Point(549, 247);
			this.txtDonGia.Name = "txtDonGia";
			this.txtDonGia.Size = new System.Drawing.Size(162, 30);
			this.txtDonGia.TabIndex = 3;
			this.txtDonGia.Text = "22000";
			this.txtDonGia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoLuong.Location = new System.Drawing.Point(549, 289);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.Size = new System.Drawing.Size(162, 30);
			this.txtSoLuong.TabIndex = 3;
			this.txtSoLuong.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Location = new System.Drawing.Point(448, 355);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(81, 38);
			this.btnTinhTien.TabIndex = 4;
			this.btnTinhTien.Text = "Tính tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(368, 396);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(254, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tính số tiền thanh toán";
			this.label2.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblSoTien
			// 
			this.lblSoTien.AutoSize = true;
			this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSoTien.Location = new System.Drawing.Point(628, 396);
			this.lblSoTien.Name = "lblSoTien";
			this.lblSoTien.Size = new System.Drawing.Size(26, 29);
			this.lblSoTien.TabIndex = 2;
			this.lblSoTien.Text = "0";
			this.lblSoTien.Click += new System.EventHandler(this.label1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(754, 396);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 29);
			this.label5.TabIndex = 2;
			this.label5.Text = "$";
			this.label5.Click += new System.EventHandler(this.label1_Click);
			// 
			// frmBai1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnTinhTien);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.txtDonGia);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblSoTien);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmBai1";
			this.Text = "frmBai1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdXanh;
		private System.Windows.Forms.RadioButton rdTrang;
		private System.Windows.Forms.RadioButton rdDo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Button btnTinhTien;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSoTien;
		private System.Windows.Forms.Label label5;
	}
}