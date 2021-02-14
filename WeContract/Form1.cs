using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WeContractLib.Customer;
using WeContractLib.Contract;
using WeContractLib;
using System.Diagnostics;
using WeContractLib.Diagnostics;
using WeContractLib.Misc;
using WeContractLib.Storage;

namespace WeContract
{
	public partial class frmMain : Form
    {
		public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Controller.Initialize();

            Loader.Inst.Initialize();
            Loader.Inst.Execute();

            comboBox1.Items.AddRange(new object[]
            { wcDataGridView1.dgv, wcDataGridView1.dgv.AlternatingRowsDefaultCellStyle, wcDataGridView1.dgv.ColumnHeadersDefaultCellStyle, wcDataGridView1.dgv.DefaultCellStyle, wcDataGridView1.dgv.RowHeadersBorderStyle, wcDataGridView1.dgv.RowHeadersDefaultCellStyle, wcDataGridView1.dgv.RowsDefaultCellStyle });
            propertyGrid1.SelectedObject = wcDataGridView1.dgv;

           // WeContractLib.Storage.DBO.CreateDatabase();
           // return;
            var imgList = new List<Image>();

            var img1 = new ImageData("contractIcons", "ordered", ImageHelper.GetImageFromBase64(ContractBase64Icons.OrderedIconBase64));
            img1.Images.Add("paid", ImageHelper.GetImageFromBase64(ContractBase64Icons.PaidIconBase64));
            img1.Images.Add("delivered", ImageHelper.GetImageFromBase64(ContractBase64Icons.DeliveredIconBase64));
            img1.Images.Add("archived", ImageHelper.GetImageFromBase64(ContractBase64Icons.ArchivedIconBase64));

            imgList.AddRange(Controller.ImageManager.Get("contractIcons").Images.Values);
            var bmp = ImageHelper.CombineBitmapGrid(imgList.ToArray(), 4, 1, 10);
            var sw = new Stopwatch();
            sw.Restart();
            for (int i = 0; i < 10; i++)
            {
                var customer = new Customer("Henrik" + i.ToString(), "Selsbanesgate 21", 41099661, 8514, "test@gmail.com", 47, "Hello World");

                var contract = new Contract(customer);
                Controller.CustomerManager.Add(customer);
                Controller.ContractManager.Add(contract);

                var row = new DataGridViewRow
                {
                    Tag = customer
                };
                row.CreateCells(dgv_customers,
                   customer.GetColumnIndexes().ToArray());
                dgv_customers.Rows.Add(row);
            }
            sw.LogElapsedMs(true, "10 customers");
            var rnd = new Random();
            foreach (var contract in Controller.ContractManager.GetList())
            {
                for (int i = 0; i < 10; i++)
                {
                    var item = new WeContractLib.Item.Item
                    {
                        Name = "Item:" + i.ToString(),
                        Units = (ushort)rnd.Next(1, 10),
                        Price = rnd.Next(50, 10000),
                        Paid = rnd.Next(0, 4) == 3,
                        Delivered = rnd.Next(0, 4) == 2,
                        Ordered = rnd.Next(0, 4) == 1,
                    };
                    contract.AddItem(item);

                    var itemRow = new DataGridViewRow
                    {
                        Tag = item
                    };

                    var colItemIndexes = item.GetColumnIndexes();

                    itemRow.CreateCells(wcDataGridView1.dgv,
                       colItemIndexes.ToArray());
                    wcDataGridView1.dgv.Rows.Add(itemRow);
                }
                var row = new DataGridViewRow
                {
                    Tag = contract
                };

                var colIndexes = contract.GetColumnIndexes();
                colIndexes[3] = bmp;
                row.CreateCells(dgv_contracts,
                   colIndexes.ToArray());
                dgv_contracts.Rows.Add(row);
            }

            sw.LogElapsedMs(false, "Contracts");
            //row.CreateCells(dgv_contracts,
            //    contract.CustomerName,
            //    contract.Customer.PhoneNumber,
            //    contract.DateCreated.ToShortDateString(),
            //    Helper.CurrencyFormat(item.Price),
            //    Helper.CurrencyFormat(item.GetTotalPrice()) + " kr",
            //    item.Ordered,
            //    item.Delivered,
            //    item.Purchased);
            wcDataGridView1.LoadTheme();
        }

        private void dgv_contracts_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex == -1)
            {
                var img = ImageHelper.GetImageFromBase64(ContractBase64Icons.PaidIconBase64);
                e.PaintBackground(e.ClipBounds, false);

                Point pt = e.CellBounds.Location;  // where you want the bitmap in the cell

                int offset = (e.CellBounds.Width - img.Width) / 2;
                pt.X += offset;
				pt.Y++;
                e.Graphics.DrawImage(img, pt);
                //img.Draw(e.Graphics, pt, 0);
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                propertyGrid1.SelectedObject = comboBox1.SelectedItem;
                var objs = new string[]
           { "wcDataGridView1.dgv", "wcDataGridView1.dgv.AlternatingRowsDefaultCellStyle", "wcDataGridView1.dgv.ColumnHeadersDefaultCellStyle", "wcDataGridView1.dgv.DefaultCellStyle", "wcDataGridView1.dgv.RowHeadersBorderStyle", "wcDataGridView1.dgv.RowHeadersDefaultCellStyle", "wcDataGridView1.dgv.RowsDefaultCellStyle"};
                Text = $"{objs[comboBox1.SelectedIndex]}";
            }
        }
    }
}
