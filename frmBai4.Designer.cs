namespace BaiTapThietKeForm
{
	partial class frmBai4
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.txtSo = new System.Windows.Forms.TextBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(409, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập số cần tìm";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(86, 77);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(245, 284);
			this.listBox1.TabIndex = 1;
			// 
			// txtSo
			// 
			this.txtSo.Location = new System.Drawing.Point(549, 131);
			this.txtSo.Name = "txtSo";
			this.txtSo.Size = new System.Drawing.Size(163, 26);
			this.txtSo.TabIndex = 2;
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(537, 201);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(106, 33);
			this.btnTim.TabIndex = 3;
			this.btnTim.Text = "Tìm số";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(409, 285);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 29);
			this.label2.TabIndex = 0;
			this.label2.Text = "Kết quả";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKetQua.ForeColor = System.Drawing.Color.Red;
			this.lblKetQua.Location = new System.Drawing.Point(560, 285);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(19, 29);
			this.lblKetQua.TabIndex = 0;
			this.lblKetQua.Text = ".";
			this.lblKetQua.Click += new System.EventHandler(this.lblKetQua_Click);
			// 
			// frmBai4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txtSo);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmBai4";
			this.Text = "frmBai4";
			this.Load += new System.EventHandler(this.frmBai4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox txtSo;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblKetQua;
	}
}