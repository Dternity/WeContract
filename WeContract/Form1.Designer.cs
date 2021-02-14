
namespace WeContract
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgv_contracts = new System.Windows.Forms.DataGridView();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStatus = new System.Windows.Forms.DataGridViewImageColumn();
			this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colItemsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colArchivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCustomerContacted = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCustomerContactedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_customers = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colZipcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCountryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_contracts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_contracts
			// 
			this.dgv_contracts.AllowUserToAddRows = false;
			this.dgv_contracts.AllowUserToDeleteRows = false;
			this.dgv_contracts.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.dgv_contracts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_contracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_contracts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgv_contracts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.dgv_contracts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_contracts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_contracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_contracts.ColumnHeadersHeight = 28;
			this.dgv_contracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colPhone,
            this.colCreated,
            this.colStatus,
            this.colTotalPrice,
            this.colItemsCount,
            this.colLastUpdated,
            this.colArchivedDate,
            this.colCustomerContacted,
            this.colCustomerContactedDate,
            this.colCustomerEmail,
            this.colNote});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_contracts.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_contracts.EnableHeadersVisualStyles = false;
			this.dgv_contracts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.dgv_contracts.Location = new System.Drawing.Point(118, 350);
			this.dgv_contracts.MultiSelect = false;
			this.dgv_contracts.Name = "dgv_contracts";
			this.dgv_contracts.ReadOnly = true;
			this.dgv_contracts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_contracts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_contracts.RowHeadersVisible = false;
			this.dgv_contracts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dgv_contracts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_contracts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgv_contracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_contracts.ShowCellErrors = false;
			this.dgv_contracts.ShowEditingIcon = false;
			this.dgv_contracts.ShowRowErrors = false;
			this.dgv_contracts.Size = new System.Drawing.Size(627, 179);
			this.dgv_contracts.TabIndex = 2;
			this.dgv_contracts.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_contracts_CellPainting);
			// 
			// colName
			// 
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			// 
			// colPhone
			// 
			this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colPhone.HeaderText = "Phone";
			this.colPhone.Name = "colPhone";
			this.colPhone.ReadOnly = true;
			// 
			// colCreated
			// 
			this.colCreated.HeaderText = "Created";
			this.colCreated.Name = "colCreated";
			this.colCreated.ReadOnly = true;
			// 
			// colStatus
			// 
			this.colStatus.HeaderText = "Status";
			this.colStatus.Image = ((System.Drawing.Image)(resources.GetObject("colStatus.Image")));
			this.colStatus.Name = "colStatus";
			this.colStatus.ReadOnly = true;
			this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// colTotalPrice
			// 
			this.colTotalPrice.HeaderText = "Total Price";
			this.colTotalPrice.Name = "colTotalPrice";
			this.colTotalPrice.ReadOnly = true;
			// 
			// colItemsCount
			// 
			this.colItemsCount.HeaderText = "Items";
			this.colItemsCount.Name = "colItemsCount";
			this.colItemsCount.ReadOnly = true;
			// 
			// colLastUpdated
			// 
			this.colLastUpdated.HeaderText = "Last Updated";
			this.colLastUpdated.Name = "colLastUpdated";
			this.colLastUpdated.ReadOnly = true;
			// 
			// colArchivedDate
			// 
			this.colArchivedDate.HeaderText = "Archived Date";
			this.colArchivedDate.Name = "colArchivedDate";
			this.colArchivedDate.ReadOnly = true;
			// 
			// colCustomerContacted
			// 
			this.colCustomerContacted.HeaderText = "CustomerContacted";
			this.colCustomerContacted.Name = "colCustomerContacted";
			this.colCustomerContacted.ReadOnly = true;
			// 
			// colCustomerContactedDate
			// 
			this.colCustomerContactedDate.HeaderText = "Customer Contacted Date";
			this.colCustomerContactedDate.Name = "colCustomerContactedDate";
			this.colCustomerContactedDate.ReadOnly = true;
			// 
			// colCustomerEmail
			// 
			this.colCustomerEmail.HeaderText = "Email";
			this.colCustomerEmail.Name = "colCustomerEmail";
			this.colCustomerEmail.ReadOnly = true;
			// 
			// colNote
			// 
			this.colNote.HeaderText = "Note";
			this.colNote.Name = "colNote";
			this.colNote.ReadOnly = true;
			// 
			// dgv_customers
			// 
			this.dgv_customers.AllowUserToDeleteRows = false;
			this.dgv_customers.AllowUserToOrderColumns = true;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
			this.dgv_customers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgv_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_customers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgv_customers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.dgv_customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgv_customers.ColumnHeadersHeight = 28;
			this.dgv_customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.colZipcode,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.colCountryCode});
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_customers.DefaultCellStyle = dataGridViewCellStyle7;
			this.dgv_customers.EnableHeadersVisualStyles = false;
			this.dgv_customers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.dgv_customers.Location = new System.Drawing.Point(12, 26);
			this.dgv_customers.MultiSelect = false;
			this.dgv_customers.Name = "dgv_customers";
			this.dgv_customers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_customers.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgv_customers.RowHeadersVisible = false;
			this.dgv_customers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dgv_customers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_customers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgv_customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_customers.ShowCellErrors = false;
			this.dgv_customers.ShowEditingIcon = false;
			this.dgv_customers.ShowRowErrors = false;
			this.dgv_customers.Size = new System.Drawing.Size(499, 245);
			this.dgv_customers.TabIndex = 3;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Name";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.HeaderText = "Phone";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Address";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// colZipcode
			// 
			this.colZipcode.HeaderText = "Zip Code";
			this.colZipcode.Name = "colZipcode";
			this.colZipcode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colZipcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Created";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Email";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Note";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// colCountryCode
			// 
			this.colCountryCode.HeaderText = "CCC";
			this.colCountryCode.Name = "colCountryCode";
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Location = new System.Drawing.Point(30, 12);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(345, 478);
			this.propertyGrid1.TabIndex = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(442, 266);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(165, 23);
			this.comboBox1.TabIndex = 6;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
			this.ClientSize = new System.Drawing.Size(1300, 583);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.dgv_customers);
			this.Controls.Add(this.dgv_contracts);
			this.Name = "frmMain";
			this.Text = "WeContract";
			this.Load += new System.EventHandler(this.frmMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_contracts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private UserControls.ContractInfo contractInfo1;
        private System.Windows.Forms.DataGridView dgv_contracts;
        private System.Windows.Forms.DataGridView dgv_customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZipcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreated;
        private System.Windows.Forms.DataGridViewImageColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastUpdated;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArchivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerContacted;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerContactedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

