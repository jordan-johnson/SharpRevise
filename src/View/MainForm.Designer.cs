namespace SharpRevise.View {
	partial class MainForm {
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
			this.groupBoxKeyConfig = new System.Windows.Forms.GroupBox();
			this.keyListenField = new System.Windows.Forms.TextBox();
			this.buttonKeyListen = new System.Windows.Forms.Button();
			this.groupBoxSort = new System.Windows.Forms.GroupBox();
			this.buttonAddCategory = new System.Windows.Forms.Button();
			this.buttonMoveDown = new System.Windows.Forms.Button();
			this.buttonMoveUp = new System.Windows.Forms.Button();
			this.buttonDeleteComment = new System.Windows.Forms.Button();
			this.buttonAddComment = new System.Windows.Forms.Button();
			this.sortTree = new System.Windows.Forms.TreeView();
			this.footerLabel = new System.Windows.Forms.Label();
			this.groupBoxTemplateOptions = new System.Windows.Forms.GroupBox();
			this.buttonSaveTemplate = new System.Windows.Forms.Button();
			this.buttonOpenTemplate = new System.Windows.Forms.Button();
			this.footerLink = new System.Windows.Forms.LinkLabel();
			this.groupBoxKeyConfig.SuspendLayout();
			this.groupBoxSort.SuspendLayout();
			this.groupBoxTemplateOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxKeyConfig
			// 
			this.groupBoxKeyConfig.Controls.Add(this.keyListenField);
			this.groupBoxKeyConfig.Controls.Add(this.buttonKeyListen);
			this.groupBoxKeyConfig.Location = new System.Drawing.Point(12, 69);
			this.groupBoxKeyConfig.Name = "groupBoxKeyConfig";
			this.groupBoxKeyConfig.Size = new System.Drawing.Size(284, 50);
			this.groupBoxKeyConfig.TabIndex = 0;
			this.groupBoxKeyConfig.TabStop = false;
			this.groupBoxKeyConfig.Text = "Key Configuration";
			// 
			// keyListenField
			// 
			this.keyListenField.Location = new System.Drawing.Point(6, 19);
			this.keyListenField.Name = "keyListenField";
			this.keyListenField.ReadOnly = true;
			this.keyListenField.Size = new System.Drawing.Size(169, 20);
			this.keyListenField.TabIndex = 1;
			this.keyListenField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyListenerDownEvent);
			// 
			// buttonKeyListen
			// 
			this.buttonKeyListen.Location = new System.Drawing.Point(181, 18);
			this.buttonKeyListen.Name = "buttonKeyListen";
			this.buttonKeyListen.Size = new System.Drawing.Size(97, 23);
			this.buttonKeyListen.TabIndex = 0;
			this.buttonKeyListen.Text = "Assign Command";
			this.buttonKeyListen.UseVisualStyleBackColor = true;
			this.buttonKeyListen.Click += new System.EventHandler(this.assignCommandEvent);
			// 
			// groupBoxSort
			// 
			this.groupBoxSort.Controls.Add(this.buttonAddCategory);
			this.groupBoxSort.Controls.Add(this.buttonMoveDown);
			this.groupBoxSort.Controls.Add(this.buttonMoveUp);
			this.groupBoxSort.Controls.Add(this.buttonDeleteComment);
			this.groupBoxSort.Controls.Add(this.buttonAddComment);
			this.groupBoxSort.Controls.Add(this.sortTree);
			this.groupBoxSort.Location = new System.Drawing.Point(302, 12);
			this.groupBoxSort.Name = "groupBoxSort";
			this.groupBoxSort.Size = new System.Drawing.Size(652, 693);
			this.groupBoxSort.TabIndex = 1;
			this.groupBoxSort.TabStop = false;
			this.groupBoxSort.Text = "Sort";
			// 
			// buttonAddCategory
			// 
			this.buttonAddCategory.Location = new System.Drawing.Point(6, 18);
			this.buttonAddCategory.Name = "buttonAddCategory";
			this.buttonAddCategory.Size = new System.Drawing.Size(83, 23);
			this.buttonAddCategory.TabIndex = 5;
			this.buttonAddCategory.Text = "Add Category";
			this.buttonAddCategory.UseVisualStyleBackColor = true;
			// 
			// buttonMoveDown
			// 
			this.buttonMoveDown.Location = new System.Drawing.Point(610, 17);
			this.buttonMoveDown.Name = "buttonMoveDown";
			this.buttonMoveDown.Size = new System.Drawing.Size(36, 23);
			this.buttonMoveDown.TabIndex = 4;
			this.buttonMoveDown.Text = "Dn";
			this.buttonMoveDown.UseVisualStyleBackColor = true;
			// 
			// buttonMoveUp
			// 
			this.buttonMoveUp.Location = new System.Drawing.Point(568, 17);
			this.buttonMoveUp.Name = "buttonMoveUp";
			this.buttonMoveUp.Size = new System.Drawing.Size(36, 23);
			this.buttonMoveUp.TabIndex = 3;
			this.buttonMoveUp.Text = "Up";
			this.buttonMoveUp.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteComment
			// 
			this.buttonDeleteComment.Location = new System.Drawing.Point(191, 18);
			this.buttonDeleteComment.Name = "buttonDeleteComment";
			this.buttonDeleteComment.Size = new System.Drawing.Size(94, 23);
			this.buttonDeleteComment.TabIndex = 2;
			this.buttonDeleteComment.Text = "Delete Comment";
			this.buttonDeleteComment.UseVisualStyleBackColor = true;
			// 
			// buttonAddComment
			// 
			this.buttonAddComment.Location = new System.Drawing.Point(95, 18);
			this.buttonAddComment.Name = "buttonAddComment";
			this.buttonAddComment.Size = new System.Drawing.Size(90, 23);
			this.buttonAddComment.TabIndex = 1;
			this.buttonAddComment.Text = "Add Comment";
			this.buttonAddComment.UseVisualStyleBackColor = true;
			// 
			// sortTree
			// 
			this.sortTree.Location = new System.Drawing.Point(6, 48);
			this.sortTree.Name = "sortTree";
			this.sortTree.Size = new System.Drawing.Size(640, 639);
			this.sortTree.TabIndex = 0;
			// 
			// footerLabel
			// 
			this.footerLabel.AutoSize = true;
			this.footerLabel.Location = new System.Drawing.Point(12, 664);
			this.footerLabel.Name = "footerLabel";
			this.footerLabel.Size = new System.Drawing.Size(86, 13);
			this.footerLabel.TabIndex = 2;
			this.footerLabel.Text = "SharpRevise 1.0";
			// 
			// groupBoxTemplateOptions
			// 
			this.groupBoxTemplateOptions.Controls.Add(this.buttonSaveTemplate);
			this.groupBoxTemplateOptions.Controls.Add(this.buttonOpenTemplate);
			this.groupBoxTemplateOptions.Location = new System.Drawing.Point(12, 12);
			this.groupBoxTemplateOptions.Name = "groupBoxTemplateOptions";
			this.groupBoxTemplateOptions.Size = new System.Drawing.Size(284, 51);
			this.groupBoxTemplateOptions.TabIndex = 3;
			this.groupBoxTemplateOptions.TabStop = false;
			this.groupBoxTemplateOptions.Text = "Template Options";
			// 
			// buttonSaveTemplate
			// 
			this.buttonSaveTemplate.Location = new System.Drawing.Point(87, 19);
			this.buttonSaveTemplate.Name = "buttonSaveTemplate";
			this.buttonSaveTemplate.Size = new System.Drawing.Size(75, 23);
			this.buttonSaveTemplate.TabIndex = 1;
			this.buttonSaveTemplate.Text = "Save As...";
			this.buttonSaveTemplate.UseVisualStyleBackColor = true;
			// 
			// buttonOpenTemplate
			// 
			this.buttonOpenTemplate.Location = new System.Drawing.Point(6, 19);
			this.buttonOpenTemplate.Name = "buttonOpenTemplate";
			this.buttonOpenTemplate.Size = new System.Drawing.Size(75, 23);
			this.buttonOpenTemplate.TabIndex = 0;
			this.buttonOpenTemplate.Text = "Open...";
			this.buttonOpenTemplate.UseVisualStyleBackColor = true;
			// 
			// footerLink
			// 
			this.footerLink.AutoSize = true;
			this.footerLink.Location = new System.Drawing.Point(12, 686);
			this.footerLink.Name = "footerLink";
			this.footerLink.Size = new System.Drawing.Size(169, 13);
			this.footerLink.TabIndex = 4;
			this.footerLink.TabStop = true;
			this.footerLink.Text = "https://github.com/jordan-johnson";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(966, 717);
			this.Controls.Add(this.footerLink);
			this.Controls.Add(this.groupBoxTemplateOptions);
			this.Controls.Add(this.footerLabel);
			this.Controls.Add(this.groupBoxSort);
			this.Controls.Add(this.groupBoxKeyConfig);
			this.Name = "MainForm";
			this.Text = "SharpRevise";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosingEvent);
			this.groupBoxKeyConfig.ResumeLayout(false);
			this.groupBoxKeyConfig.PerformLayout();
			this.groupBoxSort.ResumeLayout(false);
			this.groupBoxTemplateOptions.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxKeyConfig;
		private System.Windows.Forms.TextBox keyListenField;
		private System.Windows.Forms.Button buttonKeyListen;
		private System.Windows.Forms.GroupBox groupBoxSort;
		private System.Windows.Forms.TreeView sortTree;
		private System.Windows.Forms.Label footerLabel;
		private System.Windows.Forms.Button buttonDeleteComment;
		private System.Windows.Forms.Button buttonAddComment;
		private System.Windows.Forms.Button buttonMoveDown;
		private System.Windows.Forms.Button buttonMoveUp;
		private System.Windows.Forms.Button buttonAddCategory;
		private System.Windows.Forms.GroupBox groupBoxTemplateOptions;
		private System.Windows.Forms.Button buttonSaveTemplate;
		private System.Windows.Forms.Button buttonOpenTemplate;
		private System.Windows.Forms.LinkLabel footerLink;
	}
}

