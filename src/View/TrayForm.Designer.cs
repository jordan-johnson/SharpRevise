namespace SharpRevise.View {
	partial class TrayForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.categoryList = new System.Windows.Forms.ComboBox();
			this.buttonAddCategory = new System.Windows.Forms.Button();
			this.commentField = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// categoryList
			// 
			this.categoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.categoryList.FormattingEnabled = true;
			this.categoryList.Location = new System.Drawing.Point(12, 12);
			this.categoryList.Name = "categoryList";
			this.categoryList.Size = new System.Drawing.Size(233, 21);
			this.categoryList.TabIndex = 1;
			// 
			// buttonAddCategory
			// 
			this.buttonAddCategory.Location = new System.Drawing.Point(251, 10);
			this.buttonAddCategory.Name = "buttonAddCategory";
			this.buttonAddCategory.Size = new System.Drawing.Size(90, 23);
			this.buttonAddCategory.TabIndex = 2;
			this.buttonAddCategory.Text = "Add Category";
			this.buttonAddCategory.UseVisualStyleBackColor = true;
			// 
			// commentField
			// 
			this.commentField.Location = new System.Drawing.Point(12, 39);
			this.commentField.Name = "commentField";
			this.commentField.Size = new System.Drawing.Size(329, 20);
			this.commentField.TabIndex = 0;
			this.commentField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownEvent);
			// 
			// TrayForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 71);
			this.Controls.Add(this.commentField);
			this.Controls.Add(this.buttonAddCategory);
			this.Controls.Add(this.categoryList);
			this.Name = "TrayForm";
			this.Text = "SharpRevise";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox categoryList;
		private System.Windows.Forms.Button buttonAddCategory;
		private System.Windows.Forms.TextBox commentField;
	}
}