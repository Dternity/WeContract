
namespace WeContract.UserControls
{
    partial class WCDataGridView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.colUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOrdered = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colDelivered = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv
			// 
			this.dgv.AllowUserToDeleteRows = false;
			this.dgv.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv.ColumnHeadersHeight = 30;
			this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUnits,
            this.colName,
            this.colPrice,
            this.colTotalPrice,
            this.colId,
            this.colOrdered,
            this.colDelivered,
            this.colPaid});
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.LightGray;
			dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1);
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv.DefaultCellStyle = dataGridViewCellStyle7;
			this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv.EnableHeadersVisualStyles = false;
			this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.dgv.Location = new System.Drawing.Point(0, 0);
			this.dgv.MultiSelect = false;
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgv.RowHeadersVisible = false;
			this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgv.ShowCellErrors = false;
			this.dgv.ShowEditingIcon = false;
			this.dgv.Size = new System.Drawing.Size(671, 315);
			this.dgv.TabIndex = 3;
			this.dgv.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_CellPainting);
			// 
			// colUnits
			// 
			this.colUnits.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.colUnits.DefaultCellStyle = dataGridViewCellStyle3;
			this.colUnits.FillWeight = 1F;
			this.colUnits.HeaderText = "Qt";
			this.colUnits.MinimumWidth = 35;
			this.colUnits.Name = "colUnits";
			this.colUnits.Width = 35;
			// 
			// colName
			// 
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.FillWeight = 150.3043F;
			this.colName.HeaderText = "Name";
			this.colName.MinimumWidth = 120;
			this.colName.Name = "colName";
			// 
			// colPrice
			// 
			this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "### ### ##0.0#";
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.colPrice.DefaultCellStyle = dataGridViewCellStyle4;
			this.colPrice.FillWeight = 5F;
			this.colPrice.HeaderText = "Price";
			this.colPrice.MinimumWidth = 90;
			this.colPrice.Name = "colPrice";
			this.colPrice.Width = 90;
			// 
			// colTotalPrice
			// 
			this.colTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "### ### ##0.0#";
			dataGridViewCellStyle5.NullValue = null;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.colTotalPrice.DefaultCellStyle = dataGridViewCellStyle5;
			this.colTotalPrice.FillWeight = 50F;
			this.colTotalPrice.HeaderText = "Total Price";
			this.colTotalPrice.MinimumWidth = 100;
			this.colTotalPrice.Name = "colTotalPrice";
			this.colTotalPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colTotalPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colId
			// 
			this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.colId.DefaultCellStyle = dataGridViewCellStyle6;
			this.colId.FillWeight = 10F;
			this.colId.HeaderText = "ID";
			this.colId.MinimumWidth = 50;
			this.colId.Name = "colId";
			this.colId.Width = 50;
			// 
			// colOrdered
			// 
			this.colOrdered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.colOrdered.HeaderText = "";
			this.colOrdered.MinimumWidth = 38;
			this.colOrdered.Name = "colOrdered";
			this.colOrdered.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.colOrdered.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.colOrdered.Width = 38;
			// 
			// colDelivered
			// 
			this.colDelivered.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.colDelivered.HeaderText = "";
			this.colDelivered.MinimumWidth = 38;
			this.colDelivered.Name = "colDelivered";
			this.colDelivered.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.colDelivered.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.colDelivered.Width = 38;
			// 
			// colPaid
			// 
			this.colPaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.colPaid.HeaderText = "";
			this.colPaid.MinimumWidth = 38;
			this.colPaid.Name = "colPaid";
			this.colPaid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.colPaid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.colPaid.Width = 38;
			// 
			// WCDataGridView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
			this.Controls.Add(this.dgv);
			this.ForeColor = System.Drawing.Color.LightGray;
			this.Name = "WCDataGridView";
			this.Size = new System.Drawing.Size(671, 315);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colOrdered;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDelivered;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPaid;
    }
}
