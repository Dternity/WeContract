
namespace WeContract.UserControls
{
    partial class ContractInfoItemsDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractInfoItemsDisplay));
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.prb_value = new WeContract.UserControls.WCProgressBar();
            this.lbl_itemsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_icon
            // 
            this.pb_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_icon.BackgroundImage")));
            this.pb_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_icon.Location = new System.Drawing.Point(32, 32);
            this.pb_icon.Margin = new System.Windows.Forms.Padding(0);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(32, 32);
            this.pb_icon.TabIndex = 0;
            this.pb_icon.TabStop = false;
            // 
            // prb_value
            // 
            this.prb_value.Alignment = System.Drawing.StringAlignment.Center;
            this.prb_value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prb_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.prb_value.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.prb_value.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prb_value.ForeColor = System.Drawing.Color.LightGray;
            this.prb_value.LineAlignment = System.Drawing.StringAlignment.Center;
            this.prb_value.Location = new System.Drawing.Point(1, 75);
            this.prb_value.MaxValue = ((uint)(100u));
            this.prb_value.MinValue = ((uint)(0u));
            this.prb_value.Name = "prb_value";
            this.prb_value.ProgressColor = System.Drawing.Color.Gray;
            this.prb_value.ShowBorder = true;
            this.prb_value.ShowPercentage = true;
            this.prb_value.Size = new System.Drawing.Size(92, 18);
            this.prb_value.TabIndex = 1;
            this.prb_value.Value = ((uint)(50u));
            // 
            // lbl_itemsCount
            // 
            this.lbl_itemsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lbl_itemsCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_itemsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_itemsCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_itemsCount.Location = new System.Drawing.Point(0, 0);
            this.lbl_itemsCount.Name = "lbl_itemsCount";
            this.lbl_itemsCount.Size = new System.Drawing.Size(96, 21);
            this.lbl_itemsCount.TabIndex = 2;
            this.lbl_itemsCount.Text = "3 of 6";
            this.lbl_itemsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ContractInfoItemsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_itemsCount);
            this.Controls.Add(this.prb_value);
            this.Controls.Add(this.pb_icon);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.MinimumSize = new System.Drawing.Size(96, 96);
            this.Name = "ContractInfoItemsDisplay";
            this.Size = new System.Drawing.Size(96, 96);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Label lbl_itemsCount;
        public WCProgressBar prb_value;
    }
}
