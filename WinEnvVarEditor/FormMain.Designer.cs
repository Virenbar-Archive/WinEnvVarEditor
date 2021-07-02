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
			this.TC_Main = new System.Windows.Forms.TabControl();
			this.TP_User = new System.Windows.Forms.TabPage();
			this.EVT_User = new WinEnvVarEditor.UC_EnvVarTree();
			this.TP_System = new System.Windows.Forms.TabPage();
			this.EVT_System = new WinEnvVarEditor.UC_EnvVarTree();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MI_About = new System.Windows.Forms.ToolStripMenuItem();
			this.TS_Main = new System.Windows.Forms.ToolStrip();
			this.L_Variables = new System.Windows.Forms.ToolStripLabel();
			this.TSB_Add = new System.Windows.Forms.ToolStripButton();
			this.TSB_Edit = new System.Windows.Forms.ToolStripButton();
			this.TSB_Delete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.L_Values = new System.Windows.Forms.ToolStripLabel();
			this.TSB_AddV = new System.Windows.Forms.ToolStripButton();
			this.TSB_EditV = new System.Windows.Forms.ToolStripButton();
			this.TSB_DeleteV = new System.Windows.Forms.ToolStripButton();
			this.TC_Main.SuspendLayout();
			this.TP_User.SuspendLayout();
			this.TP_System.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.TS_Main.SuspendLayout();
			this.SuspendLayout();
			// 
			// TC_Main
			// 
			this.TC_Main.Controls.Add(this.TP_User);
			this.TC_Main.Controls.Add(this.TP_System);
			this.TC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TC_Main.Location = new System.Drawing.Point(0, 62);
			this.TC_Main.Name = "TC_Main";
			this.TC_Main.SelectedIndex = 0;
			this.TC_Main.Size = new System.Drawing.Size(567, 457);
			this.TC_Main.TabIndex = 0;
			this.TC_Main.SelectedIndexChanged += new System.EventHandler(this.TC_Main_SelectedIndexChanged);
			// 
			// TP_User
			// 
			this.TP_User.Controls.Add(this.EVT_User);
			this.TP_User.Location = new System.Drawing.Point(4, 24);
			this.TP_User.Name = "TP_User";
			this.TP_User.Padding = new System.Windows.Forms.Padding(3);
			this.TP_User.Size = new System.Drawing.Size(559, 429);
			this.TP_User.TabIndex = 0;
			this.TP_User.Text = "User Variables";
			this.TP_User.UseVisualStyleBackColor = true;
			// 
			// EVT_User
			// 
			this.EVT_User.Dock = System.Windows.Forms.DockStyle.Fill;
			this.EVT_User.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EVT_User.Location = new System.Drawing.Point(3, 3);
			this.EVT_User.Name = "EVT_User";
			this.EVT_User.Size = new System.Drawing.Size(553, 423);
			this.EVT_User.TabIndex = 0;
			// 
			// TP_System
			// 
			this.TP_System.Controls.Add(this.EVT_System);
			this.TP_System.Location = new System.Drawing.Point(4, 24);
			this.TP_System.Name = "TP_System";
			this.TP_System.Padding = new System.Windows.Forms.Padding(3);
			this.TP_System.Size = new System.Drawing.Size(559, 429);
			this.TP_System.TabIndex = 1;
			this.TP_System.Text = "System Variables";
			this.TP_System.UseVisualStyleBackColor = true;
			// 
			// EVT_System
			// 
			this.EVT_System.Dock = System.Windows.Forms.DockStyle.Fill;
			this.EVT_System.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.EVT_System.Location = new System.Drawing.Point(3, 3);
			this.EVT_System.Name = "EVT_System";
			this.EVT_System.Size = new System.Drawing.Size(553, 423);
			this.EVT_System.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.otherToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(567, 24);
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
			this.MI_About.Size = new System.Drawing.Size(107, 22);
			this.MI_About.Text = "About";
			this.MI_About.Click += new System.EventHandler(this.MI_About_Click);
			// 
			// TS_Main
			// 
			this.TS_Main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.TS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.L_Variables,
            this.TSB_Add,
            this.TSB_Edit,
            this.TSB_Delete,
            this.toolStripSeparator1,
            this.L_Values,
            this.TSB_AddV,
            this.TSB_EditV,
            this.TSB_DeleteV});
			this.TS_Main.Location = new System.Drawing.Point(0, 24);
			this.TS_Main.Name = "TS_Main";
			this.TS_Main.Size = new System.Drawing.Size(567, 38);
			this.TS_Main.TabIndex = 4;
			this.TS_Main.Text = "toolStrip1";
			// 
			// L_Variables
			// 
			this.L_Variables.Name = "L_Variables";
			this.L_Variables.Size = new System.Drawing.Size(82, 35);
			this.L_Variables.Text = "Переменные:";
			// 
			// TSB_Add
			// 
			this.TSB_Add.Image = global::WinEnvVarEditor.FugueIcons.TagPlus;
			this.TSB_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Add.Name = "TSB_Add";
			this.TSB_Add.Size = new System.Drawing.Size(33, 35);
			this.TSB_Add.Text = "Add";
			this.TSB_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.TSB_Add.Click += new System.EventHandler(this.TSB_Add_Click);
			// 
			// TSB_Edit
			// 
			this.TSB_Edit.Image = global::WinEnvVarEditor.FugueIcons.TagPencil;
			this.TSB_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Edit.Name = "TSB_Edit";
			this.TSB_Edit.Size = new System.Drawing.Size(31, 35);
			this.TSB_Edit.Text = "Edit";
			this.TSB_Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.TSB_Edit.Click += new System.EventHandler(this.TSB_Edit_Click);
			// 
			// TSB_Delete
			// 
			this.TSB_Delete.Image = global::WinEnvVarEditor.FugueIcons.TagMinus;
			this.TSB_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_Delete.Name = "TSB_Delete";
			this.TSB_Delete.Size = new System.Drawing.Size(44, 35);
			this.TSB_Delete.Text = "Delete";
			this.TSB_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.TSB_Delete.Click += new System.EventHandler(this.TSB_Delete_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
			// 
			// L_Values
			// 
			this.L_Values.Name = "L_Values";
			this.L_Values.Size = new System.Drawing.Size(63, 35);
			this.L_Values.Text = "Значения:";
			// 
			// TSB_AddV
			// 
			this.TSB_AddV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSB_AddV.Image = global::WinEnvVarEditor.FugueIcons.BookmarkPlus;
			this.TSB_AddV.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_AddV.Name = "TSB_AddV";
			this.TSB_AddV.Size = new System.Drawing.Size(23, 35);
			this.TSB_AddV.Text = "Add";
			this.TSB_AddV.Click += new System.EventHandler(this.TSB_AddV_Click);
			// 
			// TSB_EditV
			// 
			this.TSB_EditV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSB_EditV.Image = global::WinEnvVarEditor.FugueIcons.BookmarkPencil;
			this.TSB_EditV.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_EditV.Name = "TSB_EditV";
			this.TSB_EditV.Size = new System.Drawing.Size(23, 35);
			this.TSB_EditV.Text = "Edit";
			this.TSB_EditV.Click += new System.EventHandler(this.TSB_EditV_Click);
			// 
			// TSB_DeleteV
			// 
			this.TSB_DeleteV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSB_DeleteV.Image = global::WinEnvVarEditor.FugueIcons.BookmarkMinus;
			this.TSB_DeleteV.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSB_DeleteV.Name = "TSB_DeleteV";
			this.TSB_DeleteV.Size = new System.Drawing.Size(23, 35);
			this.TSB_DeleteV.Text = "Delete";
			this.TSB_DeleteV.Click += new System.EventHandler(this.TSB_DeleteV_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(567, 519);
			this.Controls.Add(this.TC_Main);
			this.Controls.Add(this.TS_Main);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "WinEnvVarEditor";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.TC_Main.ResumeLayout(false);
			this.TP_User.ResumeLayout(false);
			this.TP_System.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.TS_Main.ResumeLayout(false);
			this.TS_Main.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl TC_Main;
		private System.Windows.Forms.TabPage TP_User;
		private System.Windows.Forms.TabPage TP_System;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MI_About;
		private System.Windows.Forms.ToolStrip TS_Main;
		private System.Windows.Forms.ToolStripButton TSB_Add;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton TSB_Edit;
		private System.Windows.Forms.ToolStripButton TSB_Delete;
		private System.Windows.Forms.ToolStripButton TSB_AddV;
		private System.Windows.Forms.ToolStripButton TSB_EditV;
		private System.Windows.Forms.ToolStripButton TSB_DeleteV;
		private System.Windows.Forms.ToolStripLabel L_Variables;
		private System.Windows.Forms.ToolStripLabel L_Values;
		private UC_EnvVarTree EVT_User;
		private UC_EnvVarTree EVT_System;
	}
}

