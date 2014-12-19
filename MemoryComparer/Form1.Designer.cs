namespace LISMemoryComparer
{
	partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFirstDump = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSecondDump = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.cbHideSystem = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeltaCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSize1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSize2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinedMemoryDumpTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoryDumpDataSet = new LISMemoryComparer.MemoryDumpDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinedMemoryDumpTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryDumpDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(912, 422);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.txtFirstDump);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.txtSecondDump);
            this.splitContainer2.Size = new System.Drawing.Size(912, 285);
            this.splitContainer2.SplitterDistance = 486;
            this.splitContainer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "From Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFirstDump
            // 
            this.txtFirstDump.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstDump.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstDump.Location = new System.Drawing.Point(0, 35);
            this.txtFirstDump.MaxLength = 0;
            this.txtFirstDump.Multiline = true;
            this.txtFirstDump.Name = "txtFirstDump";
            this.txtFirstDump.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFirstDump.Size = new System.Drawing.Size(483, 250);
            this.txtFirstDump.TabIndex = 0;
            this.txtFirstDump.TextChanged += new System.EventHandler(this.txtSecondDump_TextChanged);
            this.txtFirstDump.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "From Clipboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSecondDump
            // 
            this.txtSecondDump.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecondDump.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondDump.Location = new System.Drawing.Point(-1, 35);
            this.txtSecondDump.MaxLength = 0;
            this.txtSecondDump.Multiline = true;
            this.txtSecondDump.Name = "txtSecondDump";
            this.txtSecondDump.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSecondDump.Size = new System.Drawing.Size(423, 247);
            this.txtSecondDump.TabIndex = 1;
            this.txtSecondDump.TextChanged += new System.EventHandler(this.txtSecondDump_TextChanged);
            this.txtSecondDump.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 359F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(912, 133);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textBoxFilter);
            this.flowLayoutPanel1.Controls.Add(this.cbHideSystem);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(906, 26);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(38, 3);
            this.textBoxFilter.MinimumSize = new System.Drawing.Size(200, 4);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(200, 20);
            this.textBoxFilter.TabIndex = 6;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // cbHideSystem
            // 
            this.cbHideSystem.AutoSize = true;
            this.cbHideSystem.Location = new System.Drawing.Point(244, 3);
            this.cbHideSystem.Name = "cbHideSystem";
            this.cbHideSystem.Size = new System.Drawing.Size(189, 17);
            this.cbHideSystem.TabIndex = 7;
            this.cbHideSystem.Text = "Hide Microsoft Namespace Entries";
            this.cbHideSystem.UseVisualStyleBackColor = true;
            this.cbHideSystem.CheckedChanged += new System.EventHandler(this.cbHideSystem_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mT1DataGridViewTextBoxColumn,
            this.className1DataGridViewTextBoxColumn,
            this.count1DataGridViewTextBoxColumn,
            this.count2DataGridViewTextBoxColumn,
            this.DeltaCount,
            this.CountFactor,
            this.totalSize1DataGridViewTextBoxColumn,
            this.totalSize2DataGridViewTextBoxColumn,
            this.mT2DataGridViewTextBoxColumn,
            this.className2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.joinedMemoryDumpTableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(906, 95);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // mT1DataGridViewTextBoxColumn
            // 
            this.mT1DataGridViewTextBoxColumn.DataPropertyName = "MT1";
            this.mT1DataGridViewTextBoxColumn.HeaderText = "MT1";
            this.mT1DataGridViewTextBoxColumn.Name = "mT1DataGridViewTextBoxColumn";
            this.mT1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // className1DataGridViewTextBoxColumn
            // 
            this.className1DataGridViewTextBoxColumn.DataPropertyName = "ClassName1";
            this.className1DataGridViewTextBoxColumn.HeaderText = "ClassName1";
            this.className1DataGridViewTextBoxColumn.Name = "className1DataGridViewTextBoxColumn";
            this.className1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // count1DataGridViewTextBoxColumn
            // 
            this.count1DataGridViewTextBoxColumn.DataPropertyName = "Count1";
            this.count1DataGridViewTextBoxColumn.HeaderText = "Count1";
            this.count1DataGridViewTextBoxColumn.Name = "count1DataGridViewTextBoxColumn";
            this.count1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // count2DataGridViewTextBoxColumn
            // 
            this.count2DataGridViewTextBoxColumn.DataPropertyName = "Count2";
            this.count2DataGridViewTextBoxColumn.HeaderText = "Count2";
            this.count2DataGridViewTextBoxColumn.Name = "count2DataGridViewTextBoxColumn";
            this.count2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DeltaCount
            // 
            this.DeltaCount.DataPropertyName = "DeltaCount";
            this.DeltaCount.HeaderText = "Delta Count";
            this.DeltaCount.Name = "DeltaCount";
            this.DeltaCount.ReadOnly = true;
            // 
            // CountFactor
            // 
            this.CountFactor.DataPropertyName = "CountFactor";
            this.CountFactor.HeaderText = "CountFactor";
            this.CountFactor.Name = "CountFactor";
            this.CountFactor.ReadOnly = true;
            // 
            // totalSize1DataGridViewTextBoxColumn
            // 
            this.totalSize1DataGridViewTextBoxColumn.DataPropertyName = "TotalSize1";
            this.totalSize1DataGridViewTextBoxColumn.HeaderText = "TotalSize1";
            this.totalSize1DataGridViewTextBoxColumn.Name = "totalSize1DataGridViewTextBoxColumn";
            this.totalSize1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSize2DataGridViewTextBoxColumn
            // 
            this.totalSize2DataGridViewTextBoxColumn.DataPropertyName = "TotalSize2";
            this.totalSize2DataGridViewTextBoxColumn.HeaderText = "TotalSize2";
            this.totalSize2DataGridViewTextBoxColumn.Name = "totalSize2DataGridViewTextBoxColumn";
            this.totalSize2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mT2DataGridViewTextBoxColumn
            // 
            this.mT2DataGridViewTextBoxColumn.DataPropertyName = "MT2";
            this.mT2DataGridViewTextBoxColumn.HeaderText = "MT2";
            this.mT2DataGridViewTextBoxColumn.Name = "mT2DataGridViewTextBoxColumn";
            this.mT2DataGridViewTextBoxColumn.ReadOnly = true;
            this.mT2DataGridViewTextBoxColumn.Visible = false;
            // 
            // className2DataGridViewTextBoxColumn
            // 
            this.className2DataGridViewTextBoxColumn.DataPropertyName = "ClassName2";
            this.className2DataGridViewTextBoxColumn.HeaderText = "ClassName2";
            this.className2DataGridViewTextBoxColumn.Name = "className2DataGridViewTextBoxColumn";
            this.className2DataGridViewTextBoxColumn.ReadOnly = true;
            this.className2DataGridViewTextBoxColumn.Visible = false;
            // 
            // joinedMemoryDumpTableBindingSource
            // 
            this.joinedMemoryDumpTableBindingSource.DataMember = "JoinedMemoryDumpTable";
            this.joinedMemoryDumpTableBindingSource.DataSource = this.memoryDumpDataSet;
            // 
            // memoryDumpDataSet
            // 
            this.memoryDumpDataSet.DataSetName = "MemoryDumpDataSet";
            this.memoryDumpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 422);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Memory Comparer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinedMemoryDumpTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryDumpDataSet)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TextBox txtFirstDump;
        private System.Windows.Forms.TextBox txtSecondDump;
		private System.Windows.Forms.BindingSource joinedMemoryDumpTableBindingSource;
		private MemoryDumpDataSet memoryDumpDataSet;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeltaCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn mT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn className1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn count1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn count2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSize1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSize2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn className2DataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.CheckBox cbHideSystem;
	}
}

