﻿namespace StudentManager.Screens.Employees
{
	partial class ManageEmployeesForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EmployeesDataGridView = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewEmployeeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(844, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Enabled = false;
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
			this.toolStripMenuItem1.Text = "|";
			// 
			// addNewEmployeeToolStripMenuItem
			// 
			this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
			this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
			this.addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
			this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
			// 
			// EmployeesDataGridView
			// 
			this.EmployeesDataGridView.AllowUserToAddRows = false;
			this.EmployeesDataGridView.AllowUserToDeleteRows = false;
			this.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.EmployeesDataGridView.Location = new System.Drawing.Point(12, 37);
			this.EmployeesDataGridView.Name = "EmployeesDataGridView";
			this.EmployeesDataGridView.ReadOnly = true;
			this.EmployeesDataGridView.Size = new System.Drawing.Size(819, 334);
			this.EmployeesDataGridView.TabIndex = 1;
			this.EmployeesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesDataGridView_CellContentClick);
			this.EmployeesDataGridView.DoubleClick += new System.EventHandler(this.EmployeesDataGridView_DoubleClick);
			// 
			// ManageEmployeesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 383);
			this.Controls.Add(this.EmployeesDataGridView);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "ManageEmployeesForm";
			this.ShowInTaskbar = true;
			this.Text = "Manage Employees";
			this.Load += new System.EventHandler(this.ManageEmployeesForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
		private System.Windows.Forms.DataGridView EmployeesDataGridView;
	}
}