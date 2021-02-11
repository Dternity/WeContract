
namespace WeContract.UserControls
{
    partial class ContractInfoPriceDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractInfoPriceDisplay));
            this.lbl_price = new System.Windows.Forms.Label();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_price
            // 
            this.lbl_price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.lbl_price.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_price.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_price.Location = new System.Drawing.Point(0, 0);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lbl_price.Size = new System.Drawing.Size(96, 21);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "10 150K";
            this.lbl_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_icon
            // 
            this.pb_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_icon.BackgroundImage")));
            this.pb_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_icon.Location = new System.Drawing.Point(31, 31);
            this.pb_icon.Margin = new System.Windows.Forms.Padding(0);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(34, 34);
            this.pb_icon.TabIndex = 3;
            this.pb_icon.TabStop = false;
            // 
            // ContractInfoPriceDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.pb_icon);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.MinimumSize = new System.Drawing.Size(96, 96);
            this.Name = "ContractInfoPriceDisplay";
            this.Size = new System.Drawing.Size(96, 96);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_price;
        public System.Windows.Forms.PictureBox pb_icon;
    }
}
