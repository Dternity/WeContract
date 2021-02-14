using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using WeContract.UIHelpers;
using WeContractLib.Contract;
using WeContractLib.Diagnostics;
using WeContractLib.Storage;

namespace WeContract.UserControls
{
	public partial class WCDataGridView : UserControl
    {
        private ImageData _imgs;
        public WCDataGridView()
        {
            InitializeComponent();
            _imgs = new ImageData("contractIcons", "ordered", ImageHelper.GetImageFromBase64(ContractBase64Icons.OrderedIconBase64));
            _imgs.Images.Add("delivered", ImageHelper.GetImageFromBase64(ContractBase64Icons.DeliveredIconBase64));
            _imgs.Images.Add("paid", ImageHelper.GetImageFromBase64(ContractBase64Icons.PaidIconBase64));
        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            //e.Handled = true;
           // return;

            if (e.ColumnIndex == 5 && e.RowIndex == -1)
            {
                //var img = ImageHelper.GetImageFromBase64(ContractBase64Icons.OrderedIconBase64);
                DGVHelper.DrawHeaderIcon(e, _imgs.Images["ordered"], new Point(10, 2), true);
            }
            if (e.ColumnIndex == 6 && e.RowIndex == -1)
            {
               // var img = ImageHelper.GetImageFromBase64(ContractBase64Icons.DeliveredIconBase64);

                DGVHelper.DrawHeaderIcon(e, _imgs.Images["delivered"], new Point(0, 2), true);
            }
            if (e.ColumnIndex == 7 && e.RowIndex == -1)
            {
            //    var img = ImageHelper.GetImageFromBase64(ContractBase64Icons.PaidIconBase64);
                DGVHelper.DrawHeaderIcon(e, _imgs.Images["paid"], new Point(0, 2), true);
            }
        }

        public void LoadTheme()
        {
            dgv.EnableHeadersVisualStyles = false;

            BackColor = Color.FromArgb(80, 80, 80);
            dgv.GridColor = Color.FromArgb(70,70,70);

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(194, 194, 194);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 60);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(140, 140, 140);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(95, 95, 95);
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = default;

            dgv.DefaultCellStyle.BackColor = Color.FromArgb(90, 90, 90);
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(190, 190, 190);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(80, 80, 80);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(160, 160, 160);
            dgv.DefaultCellStyle.Padding = new Padding(1);
            dgv.PerformLayout();
            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                Type dgvType = dgv.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dgv, true, null);
            }
        }
    }
}
