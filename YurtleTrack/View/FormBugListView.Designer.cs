﻿namespace YurtleTrack.View
{
	partial class FormBugListView
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
			this.components = new System.ComponentModel.Container();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBoxPage = new System.Windows.Forms.ComboBox();
			this.dataGridViewBugs = new System.Windows.Forms.DataGridView();
			this.bindingSourceBugs = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSourceProjects = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.labelSelected = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBugs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceBugs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceProjects)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DisplayMember = "Name";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(13, 13);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(185, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.ValueMember = "ID";
			// 
			// comboBoxPage
			// 
			this.comboBoxPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxPage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.comboBoxPage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBoxPage.Location = new System.Drawing.Point(269, 301);
			this.comboBoxPage.Name = "comboBoxPage";
			this.comboBoxPage.Size = new System.Drawing.Size(77, 21);
			this.comboBoxPage.TabIndex = 1;
			// 
			// dataGridViewBugs
			// 
			this.dataGridViewBugs.AllowUserToAddRows = false;
			this.dataGridViewBugs.AllowUserToDeleteRows = false;
			this.dataGridViewBugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewBugs.AutoGenerateColumns = false;
			this.dataGridViewBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewBugs.ColumnHeadersVisible = false;
			this.dataGridViewBugs.DataSource = this.bindingSourceBugs;
			this.dataGridViewBugs.Location = new System.Drawing.Point(13, 41);
			this.dataGridViewBugs.MultiSelect = false;
			this.dataGridViewBugs.Name = "dataGridViewBugs";
			this.dataGridViewBugs.RowHeadersVisible = false;
			this.dataGridViewBugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewBugs.ShowEditingIcon = false;
			this.dataGridViewBugs.Size = new System.Drawing.Size(517, 254);
			this.dataGridViewBugs.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(204, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Bugs Found: 0";
			// 
			// labelSelected
			// 
			this.labelSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelSelected.AutoSize = true;
			this.labelSelected.Location = new System.Drawing.Point(12, 304);
			this.labelSelected.Name = "labelSelected";
			this.labelSelected.Size = new System.Drawing.Size(61, 13);
			this.labelSelected.TabIndex = 5;
			this.labelSelected.Text = "Selected: 0";
			// 
			// buttonClear
			// 
			this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonClear.Location = new System.Drawing.Point(84, 301);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(39, 23);
			this.buttonClear.TabIndex = 4;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(455, 299);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "&OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(374, 299);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(228, 304);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Page:";
			// 
			// FormBugListView
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(542, 334);
			this.ControlBox = false;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.labelSelected);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewBugs);
			this.Controls.Add(this.comboBoxPage);
			this.Controls.Add(this.comboBox1);
			this.Name = "FormBugListView";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "YouTrack Bug List";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBugs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceBugs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceProjects)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBoxPage;
		private System.Windows.Forms.DataGridView dataGridViewBugs;
		private System.Windows.Forms.BindingSource bindingSourceProjects;
		private System.Windows.Forms.BindingSource bindingSourceBugs;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelSelected;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label label2;
	}
}