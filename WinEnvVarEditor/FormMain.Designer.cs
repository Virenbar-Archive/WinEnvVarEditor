namespace WinEnvVarEditor
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел1");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Узел2");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Узел0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Узел4");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Узел3", new System.Windows.Forms.TreeNode[] {
            treeNode4});
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Узел1");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Узел2");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Узел0", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
			System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Узел4");
			System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Узел3", new System.Windows.Forms.TreeNode[] {
            treeNode9});
			this.TC_Main = new System.Windows.Forms.TabControl();
			this.TP_User = new System.Windows.Forms.TabPage();
			this.TV_User = new System.Windows.Forms.TreeView();
			this.IL_Tags = new System.Windows.Forms.ImageList(this.components);
			this.TP_System = new System.Windows.Forms.TabPage();
			this.TV_System = new System.Windows.Forms.TreeView();
			this.button1 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MI_About = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.TC_Main.SuspendLayout();
			this.TP_User.SuspendLayout();
			this.TP_System.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TC_Main
			// 
			this.TC_Main.Controls.Add(this.TP_User);
			this.TC_Main.Controls.Add(this.TP_System);
			this.TC_Main.Dock = System.Windows.Forms.DockStyle.Left;
			this.TC_Main.Location = new System.Drawing.Point(0, 24);
			this.TC_Main.Name = "TC_Main";
			this.TC_Main.SelectedIndex = 0;
			this.TC_Main.Size = new System.Drawing.Size(572, 426);
			this.TC_Main.TabIndex = 0;
			// 
			// TP_User
			// 
			this.TP_User.Controls.Add(this.TV_User);
			this.TP_User.Location = new System.Drawing.Point(4, 22);
			this.TP_User.Name = "TP_User";
			this.TP_User.Padding = new System.Windows.Forms.Padding(3);
			this.TP_User.Size = new System.Drawing.Size(564, 400);
			this.TP_User.TabIndex = 0;
			this.TP_User.Text = "UserVars";
			this.TP_User.UseVisualStyleBackColor = true;
			// 
			// TV_User
			// 
			this.TV_User.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TV_User.ImageIndex = 0;
			this.TV_User.ImageList = this.IL_Tags;
			this.TV_User.Location = new System.Drawing.Point(3, 3);
			this.TV_User.Name = "TV_User";
			treeNode1.Name = "Узел1";
			treeNode1.Text = "Узел1";
			treeNode2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			treeNode2.Name = "Узел2";
			treeNode2.Text = "Узел2";
			treeNode3.ImageIndex = 0;
			treeNode3.Name = "Узел0";
			treeNode3.Text = "Узел0";
			treeNode4.Name = "Узел4";
			treeNode4.Text = "Узел4";
			treeNode5.Name = "Узел3";
			treeNode5.Text = "Узел3";
			this.TV_User.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
			this.TV_User.SelectedImageIndex = 2;
			this.TV_User.Size = new System.Drawing.Size(558, 394);
			this.TV_User.TabIndex = 1;
			this.TV_User.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_User_AfterSelect);
			// 
			// IL_Tags
			// 
			this.IL_Tags.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL_Tags.ImageStream")));
			this.IL_Tags.TransparentColor = System.Drawing.Color.Transparent;
			this.IL_Tags.Images.SetKeyName(0, "tag-label-green.png");
			this.IL_Tags.Images.SetKeyName(1, "tag-label-yellow.png");
			this.IL_Tags.Images.SetKeyName(2, "tag-label.png");
			this.IL_Tags.Images.SetKeyName(3, "tag-label-red.png");
			// 
			// TP_System
			// 
			this.TP_System.Controls.Add(this.TV_System);
			this.TP_System.Location = new System.Drawing.Point(4, 22);
			this.TP_System.Name = "TP_System";
			this.TP_System.Padding = new System.Windows.Forms.Padding(3);
			this.TP_System.Size = new System.Drawing.Size(564, 400);
			this.TP_System.TabIndex = 1;
			this.TP_System.Text = "SystemVars";
			this.TP_System.UseVisualStyleBackColor = true;
			// 
			// TV_System
			// 
			this.TV_System.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TV_System.ImageIndex = 0;
			this.TV_System.ImageList = this.IL_Tags;
			this.TV_System.Location = new System.Drawing.Point(3, 3);
			this.TV_System.Name = "TV_System";
			treeNode6.Name = "Узел1";
			treeNode6.Text = "Узел1";
			treeNode7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			treeNode7.Name = "Узел2";
			treeNode7.Text = "Узел2";
			treeNode8.ImageIndex = 0;
			treeNode8.Name = "Узел0";
			treeNode8.Text = "Узел0";
			treeNode9.Name = "Узел4";
			treeNode9.Text = "Узел4";
			treeNode10.Name = "Узел3";
			treeNode10.Text = "Узел3";
			this.TV_System.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10});
			this.TV_System.SelectedImageIndex = 2;
			this.TV_System.Size = new System.Drawing.Size(558, 394);
			this.TV_System.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(666, 281);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.otherToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
			this.toolStripMenuItem1.Text = "Action";
			// 
			// otherToolStripMenuItem
			// 
			this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_About});
			this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
			this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.otherToolStripMenuItem.Text = "Other";
			// 
			// MI_About
			// 
			this.MI_About.Name = "MI_About";
			this.MI_About.Size = new System.Drawing.Size(180, 22);
			this.MI_About.Text = "About";
			this.MI_About.Click += new System.EventHandler(this.MI_About_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(572, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(228, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.TC_Main);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "WinEnvVarEditor";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.TC_Main.ResumeLayout(false);
			this.TP_User.ResumeLayout(false);
			this.TP_System.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl TC_Main;
		private System.Windows.Forms.TabPage TP_User;
		private System.Windows.Forms.TabPage TP_System;
		private System.Windows.Forms.TreeView TV_User;
		private System.Windows.Forms.ImageList IL_Tags;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.TreeView TV_System;
		private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MI_About;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
	}
}

