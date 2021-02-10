
namespace WeContract.UserControls
{
    partial class ContractInfo
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
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.lbl_created = new System.Windows.Forms.Label();
            this.tb_note = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.pb_tags = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tags)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_customerName.Location = new System.Drawing.Point(12, 9);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(206, 32);
            this.lbl_customerName.TabIndex = 0;
            this.lbl_customerName.Text = "CustomerName";
            // 
            // lbl_created
            // 
            this.lbl_created.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_created.AutoSize = true;
            this.lbl_created.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_created.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_created.Location = new System.Drawing.Point(12, 104);
            this.lbl_created.Name = "lbl_created";
            this.lbl_created.Size = new System.Drawing.Size(134, 19);
            this.lbl_created.TabIndex = 1;
            this.lbl_created.Text = "Created: 12.06.2020";
            // 
            // tb_note
            // 
            this.tb_note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.tb_note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_note.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_note.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_note.Location = new System.Drawing.Point(12, 44);
            this.tb_note.Multiline = true;
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(257, 58);
            this.tb_note.TabIndex = 2;
            this.tb_note.Text = "Note";
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_price.Location = new System.Drawing.Point(264, 13);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(73, 20);
            this.lbl_price.TabIndex = 3;
            this.lbl_price.Text = "10 657 KR";
            // 
            // pb_tags
            // 
            this.pb_tags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_tags.Location = new System.Drawing.Point(275, 36);
            this.pb_tags.Name = "pb_tags";
            this.pb_tags.Size = new System.Drawing.Size(64, 64);
            this.pb_tags.TabIndex = 4;
            this.pb_tags.TabStop = false;
            // 
            // ContractInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.pb_tags);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(this.lbl_created);
            this.Controls.Add(this.lbl_customerName);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ContractInfo";
            this.Size = new System.Drawing.Size(347, 129);
            this.Load += new System.EventHandler(this.ContractInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_tags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.Label lbl_created;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.PictureBox pb_tags;
    }
}
