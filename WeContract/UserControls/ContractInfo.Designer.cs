
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
            this.pb_tags = new System.Windows.Forms.PictureBox();
            this.contractInfoItemsDisplay1 = new WeContract.UserControls.ContractInfoItemsDisplay();
            this.contractInfoPriceDisplay1 = new WeContract.UserControls.ContractInfoPriceDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tags)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_customerName.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_customerName.Location = new System.Drawing.Point(9, 9);
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
            this.lbl_created.Location = new System.Drawing.Point(12, 133);
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
            this.tb_note.Location = new System.Drawing.Point(206, 131);
            this.tb_note.Multiline = true;
            this.tb_note.Name = "tb_note";
            this.tb_note.Size = new System.Drawing.Size(157, 23);
            this.tb_note.TabIndex = 2;
            this.tb_note.Text = "Note";
            // 
            // pb_tags
            // 
            this.pb_tags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_tags.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_tags.Location = new System.Drawing.Point(223, 36);
            this.pb_tags.Name = "pb_tags";
            this.pb_tags.Size = new System.Drawing.Size(96, 96);
            this.pb_tags.TabIndex = 4;
            this.pb_tags.TabStop = false;
            // 
            // contractInfoItemsDisplay1
            // 
            this.contractInfoItemsDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.contractInfoItemsDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contractInfoItemsDisplay1.ForeColor = System.Drawing.Color.DarkGray;
            this.contractInfoItemsDisplay1.Location = new System.Drawing.Point(12, 36);
            this.contractInfoItemsDisplay1.MinimumSize = new System.Drawing.Size(96, 96);
            this.contractInfoItemsDisplay1.Name = "contractInfoItemsDisplay1";
            this.contractInfoItemsDisplay1.Size = new System.Drawing.Size(96, 96);
            this.contractInfoItemsDisplay1.TabIndex = 5;
            // 
            // contractInfoPriceDisplay1
            // 
            this.contractInfoPriceDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.contractInfoPriceDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contractInfoPriceDisplay1.ForeColor = System.Drawing.Color.DarkGray;
            this.contractInfoPriceDisplay1.Location = new System.Drawing.Point(121, 36);
            this.contractInfoPriceDisplay1.MinimumSize = new System.Drawing.Size(94, 94);
            this.contractInfoPriceDisplay1.Name = "contractInfoPriceDisplay1";
            this.contractInfoPriceDisplay1.Size = new System.Drawing.Size(96, 96);
            this.contractInfoPriceDisplay1.TabIndex = 6;
            // 
            // ContractInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.contractInfoPriceDisplay1);
            this.Controls.Add(this.contractInfoItemsDisplay1);
            this.Controls.Add(this.pb_tags);
            this.Controls.Add(this.tb_note);
            this.Controls.Add(this.lbl_created);
            this.Controls.Add(this.lbl_customerName);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ContractInfo";
            this.Size = new System.Drawing.Size(371, 158);
            this.Load += new System.EventHandler(this.ContractInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_tags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.Label lbl_created;
        private System.Windows.Forms.TextBox tb_note;
        private System.Windows.Forms.PictureBox pb_tags;
        private ContractInfoItemsDisplay contractInfoItemsDisplay1;
        private ContractInfoPriceDisplay contractInfoPriceDisplay1;
    }
}
