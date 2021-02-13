using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WeContractLib.Customer;
using WeContractLib.Contract;
using WeContractLib;
using System.Diagnostics;
using WeContractLib.Diagnostics;
using WeContract.Helpers;

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
            ImageManager.Initialize();

            WeContractLib.Storage.LiteDB.CreateDatabase();
            return;
#pragma warning disable CS0162 // Unreachable code detected
            var imgList = new List<Image>();
#pragma warning restore CS0162 // Unreachable code detected


            var img1 = new ImageInfo("contractIcons", "ordered", ImageHelper.GetImageFromBase64(ContractBase64Icons.OrderedIconBase64));
            img1.Images.Add("paid", ImageHelper.GetImageFromBase64(ContractBase64Icons.PaidIconBase64));
            img1.Images.Add("delivered", ImageHelper.GetImageFromBase64(ContractBase64Icons.DeliveredIconBase64));
            img1.Images.Add("archived", ImageHelper.GetImageFromBase64(ContractBase64Icons.ArchivedIconBase64));

            imgList.AddRange(ImageManager.Inst.Get("contractIcons").Images.Values);
            var bmp = ImageHelper.CombineBitmapGrid(imgList.ToArray(), 4, 1, 10);

            var sw = new Stopwatch();
            sw.Restart();
            for (int i = 0; i < 100; i++)
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
            sw.LogElapsedMs(true, "100 customers");

            foreach (var contract in Controller.ContractManager.GetList())
            {
                for (int i = 0; i < 10; i++)
                {
                    var item = new WeContractLib.Item.Item
                    {
                        Name = "Item:" + i.ToString(),
                        Quantity = (ushort)new Random().Next(1, 10),
                        Price = new Random().Next(50, 10000)
                    };
                    contract.Items.Add(item);
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
        }
    }
}
