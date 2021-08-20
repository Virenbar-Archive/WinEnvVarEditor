namespace WinEnvVarEditor
{
	partial class FormVariableEdit
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
			this.TB_Value = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.B_OK = new System.Windows.Forms.Button();
			this.B_Cancel = new System.Windows.Forms.Button();
			this.TB_Variable = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CB_Expand = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// TB_Value
			// 
			this.TB_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_Value.Location = new System.Drawing.Point(63, 36);
			this.TB_Value.Name = "TB_Value";
			this.TB_Value.Size = new System.Drawing.Size(413, 22);
			this.TB_Value.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.B_OK);
			this.flowLayoutPanel1.Controls.Add(this.B_Cancel);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(354, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(127, 29);
			this.flowLayoutPanel1.TabIndex = 8;
			this.flowLayoutPanel1.WrapContents = false;
			// 
			// B_OK
			// 
			this.B_OK.AutoSize = true;
			this.B_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.B_OK.Image = global::WinEnvVarEditor.FugueIcons.TickCircle;
			this.B_OK.Location = new System.Drawing.Point(3, 3);
			this.B_OK.Name = "B_OK";
			this.B_OK.Size = new System.Drawing.Size(48, 23);
			this.B_OK.TabIndex = 5;
			this.B_OK.Text = "OK";
			this.B_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.B_OK.UseVisualStyleBackColor = true;
			this.B_OK.Click += new System.EventHandler(this.B_OK_Click);
			// 
			// B_Cancel
			// 
			this.B_Cancel.AutoSize = true;
			this.B_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.B_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.B_Cancel.Image = global::WinEnvVarEditor.FugueIcons.CrossCircle;
			this.B_Cancel.Location = new System.Drawing.Point(57, 3);
			this.B_Cancel.Name = "B_Cancel";
			this.B_Cancel.Size = new System.Drawing.Size(67, 23);
			this.B_Cancel.TabIndex = 6;
			this.B_Cancel.Text = "Cancel";
			this.B_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.B_Cancel.UseVisualStyleBackColor = true;
			this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
			// 
			// TB_Variable
			// 
			this.TB_Variable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TB_Variable.Location = new System.Drawing.Point(63, 8);
			this.TB_Variable.Name = "TB_Variable";
			this.TB_Variable.ReadOnly = true;
			this.TB_Variable.Size = new System.Drawing.Size(413, 22);
			this.TB_Variable.TabIndex = 9;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.TB_Variable, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.TB_Value, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.CB_Expand, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 89);
			this.tableLayoutPanel1.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Variable";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Value";
			// 
			// CB_Expand
			// 
			this.CB_Expand.AutoSize = true;
			this.CB_Expand.Location = new System.Drawing.Point(63, 64);
			this.CB_Expand.Name = "CB_Expand";
			this.CB_Expand.Size = new System.Drawing.Size(237, 17);
			this.CB_Expand.TabIndex = 12;
			this.CB_Expand.Text = "Is Expandeble (Allow using of %EnvVar%)";
			this.CB_Expand.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 87);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(484, 35);
			this.tableLayoutPanel2.TabIndex = 14;
			// 
			// FormVariableEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(484, 122);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MaximumSize = new System.Drawing.Size(1000, 160);
			this.MinimumSize = new System.Drawing.Size(500, 160);
			this.Name = "FormVariableEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormVariableEdit";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TB_Value;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button B_OK;
		private System.Windows.Forms.Button B_Cancel;
		private System.Windows.Forms.TextBox TB_Variable;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.CheckBox CB_Expand;
	}
}