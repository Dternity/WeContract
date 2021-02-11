using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeContract.Helpers;
using WeContractLib.Contract;
using WeContractLib.Diagnostics;
using WeContractLib.Misc;

namespace WeContract.UserControls
{
    public partial class ContractInfo : UserControl
    {
        public static Contract Contract;
        public ContractInfo()
        {
            InitializeComponent();
        }

        public void SetContract(Contract contract)
        {
            if (contract == null)
            {
                Logger.Inst.Error($@"Contract was null on:{Name}", MethodBase.GetCurrentMethod());
                return;
            }

            Contract = contract;
            lbl_customerName.Text = contract.CustomerName;
            lbl_created.Text = $@"Created:{contract.DateCreated.ToShortDateString()}";
            //lbl_price.Text = TextFormatting.CurrencyFormat(contract.Price, true);
            contractInfoPriceDisplay1.lbl_price.Text = TextFormatting.CurrencyFormat(contract.Price, true);
            var imgList = new List<Image>();

            var enabledColor = ColorDefs.ContractIconEnabled;
            var disabledColor = ColorDefs.ContractIconDisabled;

            imgList.Add(ImageHelper.ModifyImageColor(ImageHelper.GetImageFromBase64(ContractBase64Icons.OrderedIconBase64), contract.IsOrdered ? enabledColor : disabledColor));
            imgList.Add(ImageHelper.ModifyImageColor(ImageHelper.GetImageFromBase64(ContractBase64Icons.PaidIconBase64), contract.IsPaid ? enabledColor : disabledColor));
            imgList.Add(ImageHelper.ModifyImageColor(ImageHelper.GetImageFromBase64(ContractBase64Icons.DeliveredIconBase64), contract.IsDelivered ? enabledColor : disabledColor));
            imgList.Add(ImageHelper.ModifyImageColor(ImageHelper.GetImageFromBase64(ContractBase64Icons.ArchivedIconBase64), contract.IsArchived ? enabledColor : disabledColor));

            var bmp = ImageHelper.CombineBitmapGrid(imgList.ToArray(), 2, 2, 10);
            pb_tags.Size = bmp.Size;
            pb_tags.Image = bmp;
            //pb_tags.Top = tb_note.Top;
        }


        private void button1_Click(object sender, EventArgs e)
        {

  
        }

        private void ContractInfo_Load(object sender, EventArgs e)
        {
            lbl_customerName.Paint += DrawSeperatorLineCustomerName;

            var contract = new Contract();
            contract.IsArchived = true;
            contract.IsOrdered = false;
            contract.IsPaid = true;
            contract.IsDelivered = false;
            contract.CustomerName = "Henrik Bjornberg";
            contract.DateCreated = DateTime.Now;
            contract.Price = 140042.42;
            SetContract(contract);
        }

        private void DrawSeperatorLineCustomerName(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            using var brush = new SolidBrush(Color.FromArgb(100, 100, 100));
            g.FillRectangle(brush, lbl_customerName.Left -5, lbl_customerName.Font.Height , lbl_customerName.Width, 2);
        }
    }
}
