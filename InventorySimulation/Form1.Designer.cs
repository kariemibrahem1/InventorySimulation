namespace InventorySimulation
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.serviceTimeDistributionDataTable = new System.Windows.Forms.DataGridView();
			this.serviceTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.serverProbabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.serviceTimeDistributionDataTable)).BeginInit();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(9, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(290, 328);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 370);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Read File";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// serviceTimeDistributionDataTable
			// 
			this.serviceTimeDistributionDataTable.AllowUserToAddRows = false;
			this.serviceTimeDistributionDataTable.AllowUserToDeleteRows = false;
			this.serviceTimeDistributionDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.serviceTimeDistributionDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceTimeColumn,
            this.serverProbabilityColumn,
            this.Column1,
            this.Column2,
            this.Column3});
			this.serviceTimeDistributionDataTable.Location = new System.Drawing.Point(487, 30);
			this.serviceTimeDistributionDataTable.Margin = new System.Windows.Forms.Padding(4);
			this.serviceTimeDistributionDataTable.Name = "serviceTimeDistributionDataTable";
			this.serviceTimeDistributionDataTable.ReadOnly = true;
			this.serviceTimeDistributionDataTable.RowHeadersWidth = 51;
			this.serviceTimeDistributionDataTable.Size = new System.Drawing.Size(689, 310);
			this.serviceTimeDistributionDataTable.TabIndex = 18;
			// 
			// serviceTimeColumn
			// 
			this.serviceTimeColumn.HeaderText = "Service Time";
			this.serviceTimeColumn.MinimumWidth = 6;
			this.serviceTimeColumn.Name = "serviceTimeColumn";
			this.serviceTimeColumn.ReadOnly = true;
			this.serviceTimeColumn.Width = 125;
			// 
			// serverProbabilityColumn
			// 
			this.serverProbabilityColumn.HeaderText = "Probability";
			this.serverProbabilityColumn.MinimumWidth = 6;
			this.serverProbabilityColumn.Name = "serverProbabilityColumn";
			this.serverProbabilityColumn.ReadOnly = true;
			this.serverProbabilityColumn.Width = 125;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Comulitave Probablity";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "MinRange";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "MaxRange";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 125;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(672, 370);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(148, 23);
			this.button2.TabIndex = 19;
			this.button2.Text = "DemandDistribution";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(950, 370);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(159, 23);
			this.button3.TabIndex = 20;
			this.button3.Text = "LeadDaysDistribution";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(172, 370);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 21;
			this.button4.Text = "Simulate";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1237, 444);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.serviceTimeDistributionDataTable);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.richTextBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.serviceTimeDistributionDataTable)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView serviceTimeDistributionDataTable;
		private System.Windows.Forms.DataGridViewTextBoxColumn serviceTimeColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn serverProbabilityColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}