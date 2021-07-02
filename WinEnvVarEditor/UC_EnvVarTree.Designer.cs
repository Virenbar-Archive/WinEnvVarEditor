namespace WinEnvVarEditor
{
	partial class UC_EnvVarTree
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

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел1");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Узел2");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Узел0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Узел4");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Узел3", new System.Windows.Forms.TreeNode[] {
            treeNode4});
			this.TV = new System.Windows.Forms.TreeView();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.B_Refresh = new System.Windows.Forms.Button();
			this.FLP_Buttons = new System.Windows.Forms.FlowLayoutPanel();
			this.B_Apply = new System.Windows.Forms.Button();
			this.B_Cancel = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.FLP_Buttons.SuspendLayout();
			this.SuspendLayout();
			// 
			// TV
			// 
			this.TV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TV.HideSelection = false;
			this.TV.LabelEdit = true;
			this.TV.Location = new System.Drawing.Point(0, 0);
			this.TV.Name = "TV";
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
			this.TV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
			this.TV.Size = new System.Drawing.Size(464, 421);
			this.TV.TabIndex = 2;
			this.TV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TV_AfterSelect);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.B_Refresh, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.FLP_Buttons, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 421);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 29);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// B_Refresh
			// 
			this.B_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.B_Refresh.AutoSize = true;
			this.B_Refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_Refresh.Image = global::WinEnvVarEditor.FugueIcons.ArrowCircle;
			this.B_Refresh.Location = new System.Drawing.Point(3, 3);
			this.B_Refresh.Name = "B_Refresh";
			this.B_Refresh.Size = new System.Drawing.Size(72, 23);
			this.B_Refresh.TabIndex = 2;
			this.B_Refresh.Text = "Refresh";
			this.B_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.B_Refresh.UseVisualStyleBackColor = true;
			this.B_Refresh.Click += new System.EventHandler(this.B_Refresh_Click);
			// 
			// FLP_Buttons
			// 
			this.FLP_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.FLP_Buttons.AutoSize = true;
			this.FLP_Buttons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.FLP_Buttons.Controls.Add(this.B_Apply);
			this.FLP_Buttons.Controls.Add(this.B_Cancel);
			this.FLP_Buttons.Location = new System.Drawing.Point(323, 0);
			this.FLP_Buttons.Margin = new System.Windows.Forms.Padding(0);
			this.FLP_Buttons.Name = "FLP_Buttons";
			this.FLP_Buttons.Size = new System.Drawing.Size(141, 29);
			this.FLP_Buttons.TabIndex = 7;
			// 
			// B_Apply
			// 
			this.B_Apply.AutoSize = true;
			this.B_Apply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_Apply.Image = global::WinEnvVarEditor.FugueIcons.TickCircle;
			this.B_Apply.Location = new System.Drawing.Point(3, 3);
			this.B_Apply.Name = "B_Apply";
			this.B_Apply.Size = new System.Drawing.Size(62, 23);
			this.B_Apply.TabIndex = 5;
			this.B_Apply.Text = "Apply";
			this.B_Apply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.B_Apply.UseVisualStyleBackColor = true;
			this.B_Apply.Click += new System.EventHandler(this.B_Apply_Click);
			// 
			// B_Cancel
			// 
			this.B_Cancel.AutoSize = true;
			this.B_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_Cancel.Image = global::WinEnvVarEditor.FugueIcons.CrossCircle;
			this.B_Cancel.Location = new System.Drawing.Point(71, 3);
			this.B_Cancel.Name = "B_Cancel";
			this.B_Cancel.Size = new System.Drawing.Size(67, 23);
			this.B_Cancel.TabIndex = 6;
			this.B_Cancel.Text = "Cancel";
			this.B_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.B_Cancel.UseVisualStyleBackColor = true;
			this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
			// 
			// UC_EnvVarTree
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TV);
			this.Controls.Add(this.tableLayoutPanel1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "UC_EnvVarTree";
			this.Size = new System.Drawing.Size(464, 450);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.FLP_Buttons.ResumeLayout(false);
			this.FLP_Buttons.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView TV;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button B_Refresh;
		private System.Windows.Forms.FlowLayoutPanel FLP_Buttons;
		private System.Windows.Forms.Button B_Apply;
		private System.Windows.Forms.Button B_Cancel;
	}
}
