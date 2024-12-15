namespace InventorySimulation
{
	partial class TableOfData
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
			this.outputDataGridView = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.outputDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// outputDataGridView
			// 
			this.outputDataGridView.AllowUserToAddRows = false;
			this.outputDataGridView.AllowUserToDeleteRows = false;
			this.outputDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.outputDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.outputDataGridView.ColumnHeadersHeight = 29;
			this.outputDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
			this.outputDataGridView.Location = new System.Drawing.Point(-7, 31);
			this.outputDataGridView.Margin = new System.Windows.Forms.Padding(4);
			this.outputDataGridView.Name = "outputDataGridView";
			this.outputDataGridView.ReadOnly = true;
			this.outputDataGridView.RowHeadersWidth = 51;
			this.outputDataGridView.Size = new System.Drawing.Size(1464, 455);
			this.outputDataGridView.TabIndex = 19;
			this.outputDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outputDataGridView_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.Frozen = true;
			this.Column1.HeaderText = "Day";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 61;
			// 
			// Column2
			// 
			this.Column2.Frozen = true;
			this.Column2.HeaderText = "Cycle";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 70;
			// 
			// Column3
			// 
			this.Column3.Frozen = true;
			this.Column3.HeaderText = "DayWithinCycle";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 131;
			// 
			// Column4
			// 
			this.Column4.Frozen = true;
			this.Column4.HeaderText = "BeginningInventory";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 150;
			// 
			// Column5
			// 
			this.Column5.Frozen = true;
			this.Column5.HeaderText = "RandomDemand";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 140;
			// 
			// Column6
			// 
			this.Column6.Frozen = true;
			this.Column6.HeaderText = "Demand";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Width = 88;
			// 
			// Column7
			// 
			this.Column7.Frozen = true;
			this.Column7.HeaderText = "EndingInventory";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 132;
			// 
			// Column8
			// 
			this.Column8.Frozen = true;
			this.Column8.HeaderText = "ShortageQuantity";
			this.Column8.MinimumWidth = 6;
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 139;
			// 
			// Column9
			// 
			this.Column9.Frozen = true;
			this.Column9.HeaderText = "OrderQuantity";
			this.Column9.MinimumWidth = 6;
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Width = 118;
			// 
			// Column10
			// 
			this.Column10.Frozen = true;
			this.Column10.HeaderText = "RandomLeadDays";
			this.Column10.MinimumWidth = 6;
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Width = 151;
			// 
			// Column11
			// 
			this.Column11.Frozen = true;
			this.Column11.HeaderText = "LeadDays";
			this.Column11.MinimumWidth = 6;
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			this.Column11.Width = 99;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(104, 516);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 16);
			this.label1.TabIndex = 20;
			this.label1.Text = "Ending Inventory Average ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(754, 519);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 16);
			this.label2.TabIndex = 21;
			this.label2.Text = "Shortage Quantity Average ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(288, 513);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 22;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(947, 513);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 23;
			// 
			// TableOfData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1441, 560);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.outputDataGridView);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Name = "TableOfData";
			this.Text = "TableOfData";
			this.Load += new System.EventHandler(this.TableOfData_Load);
			((System.ComponentModel.ISupportInitialize)(this.outputDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView outputDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
	}
}