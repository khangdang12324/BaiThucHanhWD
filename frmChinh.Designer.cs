namespace BaiTapThietKeForm
{
	partial class frmChinh
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.họTênCủaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBai1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBai2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBai3 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBai4 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họTênCủaSinhViênToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// họTênCủaSinhViênToolStripMenuItem
			// 
			this.họTênCủaSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBai1,
            this.tsmiBai2,
            this.tsmiBai3,
            this.tsmiBai4});
			this.họTênCủaSinhViênToolStripMenuItem.Name = "họTênCủaSinhViênToolStripMenuItem";
			this.họTênCủaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(189, 29);
			this.họTênCủaSinhViênToolStripMenuItem.Text = "Họ Tên của sinh viên";
			// 
			// tsmiBai1
			// 
			this.tsmiBai1.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBai1.Image")));
			this.tsmiBai1.Name = "tsmiBai1";
			this.tsmiBai1.Size = new System.Drawing.Size(270, 34);
			this.tsmiBai1.Text = "Bài 1";
			this.tsmiBai1.Click += new System.EventHandler(this.tsmiBai1_Click);
			// 
			// tsmiBai2
			// 
			this.tsmiBai2.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBai2.Image")));
			this.tsmiBai2.Name = "tsmiBai2";
			this.tsmiBai2.Size = new System.Drawing.Size(270, 34);
			this.tsmiBai2.Text = "Bài 2";
			this.tsmiBai2.Click += new System.EventHandler(this.tsmiBai2_Click);
			// 
			// tsmiBai3
			// 
			this.tsmiBai3.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBai3.Image")));
			this.tsmiBai3.Name = "tsmiBai3";
			this.tsmiBai3.Size = new System.Drawing.Size(270, 34);
			this.tsmiBai3.Text = "Bài 3";
			this.tsmiBai3.Click += new System.EventHandler(this.tsmiBai3_Click);
			// 
			// tsmiBai4
			// 
			this.tsmiBai4.Name = "tsmiBai4";
			this.tsmiBai4.Size = new System.Drawing.Size(270, 34);
			this.tsmiBai4.Text = "Bài 4";
			this.tsmiBai4.Click += new System.EventHandler(this.bài4ToolStripMenuItem_Click);
			// 
			// frmChinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmChinh";
			this.Text = "Chương trình chính";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem họTênCủaSinhViênToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiBai1;
		private System.Windows.Forms.ToolStripMenuItem tsmiBai2;
		private System.Windows.Forms.ToolStripMenuItem tsmiBai3;
		private System.Windows.Forms.ToolStripMenuItem tsmiBai4;
	}
}

