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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.footerLink = new System.Windows.Forms.LinkLabel();
			this.applicationSettingsGroup = new System.Windows.Forms.GroupBox();
			this.minimizeOnStartup = new System.Windows.Forms.CheckBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buildChangelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buildPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBoxKeyConfig.SuspendLayout();
			this.groupBoxSort.SuspendLayout();
			this.applicationSettingsGroup.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxKeyConfig
			// 
			this.groupBoxKeyConfig.Controls.Add(this.keyListenField);
			this.groupBoxKeyConfig.Controls.Add(this.buttonKeyListen);
			this.groupBoxKeyConfig.Location = new System.Drawing.Point(12, 27);
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
			this.keyListenField.Click += new System.EventHandler(this.keyListenerClickEvent);
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
			this.groupBoxSort.Location = new System.Drawing.Point(302, 27);
			this.groupBoxSort.Name = "groupBoxSort";
			this.groupBoxSort.Size = new System.Drawing.Size(652, 678);
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
			// applicationSettingsGroup
			// 
			this.applicationSettingsGroup.Controls.Add(this.minimizeOnStartup);
			this.applicationSettingsGroup.Location = new System.Drawing.Point(12, 83);
			this.applicationSettingsGroup.Name = "applicationSettingsGroup";
			this.applicationSettingsGroup.Size = new System.Drawing.Size(284, 44);
			this.applicationSettingsGroup.TabIndex = 5;
			this.applicationSettingsGroup.TabStop = false;
			this.applicationSettingsGroup.Text = "Application Settings";
			// 
			// minimizeOnStartup
			// 
			this.minimizeOnStartup.AutoSize = true;
			this.minimizeOnStartup.Location = new System.Drawing.Point(6, 19);
			this.minimizeOnStartup.Name = "minimizeOnStartup";
			this.minimizeOnStartup.Size = new System.Drawing.Size(118, 17);
			this.minimizeOnStartup.TabIndex = 0;
			this.minimizeOnStartup.Text = "Open in system tray";
			this.minimizeOnStartup.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.buildToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(966, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.importToolStripMenuItem.Text = "Import...";
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.exportToolStripMenuItem.Text = "Export...";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// buildToolStripMenuItem
			// 
			this.buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildChangelogToolStripMenuItem,
            this.buildPreviewToolStripMenuItem});
			this.buildToolStripMenuItem.Name = "buildToolStripMenuItem";
			this.buildToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.buildToolStripMenuItem.Text = "Build";
			// 
			// buildChangelogToolStripMenuItem
			// 
			this.buildChangelogToolStripMenuItem.Name = "buildChangelogToolStripMenuItem";
			this.buildChangelogToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.buildChangelogToolStripMenuItem.Text = "Build Changelog";
			this.buildChangelogToolStripMenuItem.Click += new System.EventHandler(this.buildChangelogMenuEvent);
			// 
			// buildPreviewToolStripMenuItem
			// 
			this.buildPreviewToolStripMenuItem.Name = "buildPreviewToolStripMenuItem";
			this.buildPreviewToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.buildPreviewToolStripMenuItem.Text = "Build and Preview...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(966, 717);
			this.Controls.Add(this.applicationSettingsGroup);
			this.Controls.Add(this.footerLink);
			this.Controls.Add(this.footerLabel);
			this.Controls.Add(this.groupBoxSort);
			this.Controls.Add(this.groupBoxKeyConfig);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "SharpRevise";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosingEvent);
			this.groupBoxKeyConfig.ResumeLayout(false);
			this.groupBoxKeyConfig.PerformLayout();
			this.groupBoxSort.ResumeLayout(false);
			this.applicationSettingsGroup.ResumeLayout(false);
			this.applicationSettingsGroup.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
		private System.Windows.Forms.LinkLabel footerLink;
		private System.Windows.Forms.GroupBox applicationSettingsGroup;
		private System.Windows.Forms.CheckBox minimizeOnStartup;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buildToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buildChangelogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buildPreviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}

