namespace BaiTapThietKeForm
{
	partial class frmBai3
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTuMoi = new System.Windows.Forms.TextBox();
			this.txtNghia = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtHienThiNghia = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(69, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ mới";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(53, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nghĩa của từ";
			// 
			// txtTuMoi
			// 
			this.txtTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTuMoi.Location = new System.Drawing.Point(213, 35);
			this.txtTuMoi.Name = "txtTuMoi";
			this.txtTuMoi.Size = new System.Drawing.Size(323, 30);
			this.txtTuMoi.TabIndex = 0;
			// 
			// txtNghia
			// 
			this.txtNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNghia.Location = new System.Drawing.Point(213, 89);
			this.txtNghia.Name = "txtNghia";
			this.txtNghia.Size = new System.Drawing.Size(323, 30);
			this.txtNghia.TabIndex = 1;
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(283, 142);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(145, 38);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm từ mới";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(501, 186);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(154, 25);
			this.label5.TabIndex = 0;
			this.label5.Text = "NGHĨA CỦA TỪ";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(84, 186);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(205, 25);
			this.label6.TabIndex = 0;
			this.label6.Text = "DANH SÁCH TỪ MỚI";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// txtHienThiNghia
			// 
			this.txtHienThiNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHienThiNghia.Location = new System.Drawing.Point(469, 226);
			this.txtHienThiNghia.Multiline = true;
			this.txtHienThiNghia.Name = "txtHienThiNghia";
			this.txtHienThiNghia.ReadOnly = true;
			this.txtHienThiNghia.Size = new System.Drawing.Size(241, 224);
			this.txtHienThiNghia.TabIndex = 3;
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 25;
			this.listBox1.Location = new System.Drawing.Point(74, 226);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(239, 204);
			this.listBox1.TabIndex = 4;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 486);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.txtHienThiNghia);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.txtNghia);
			this.Controls.Add(this.txtTuMoi);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = "frmBai3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTuMoi;
		private System.Windows.Forms.TextBox txtNghia;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtHienThiNghia;
		private System.Windows.Forms.ListBox listBox1;
	}
}