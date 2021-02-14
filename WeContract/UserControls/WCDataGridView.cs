using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeContract.Helpers;
using WeContractLib.Contract;

namespace WeContract.UserControls
{
    [Designer(typeof(System.Windows.Forms.Design.ControlDesigner))]
   public class WCDataGridView : DataGridView
    {

        
        //protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        //{
        //    if (e.ColumnIndex == 1 && e.RowIndex == -1)
        //    {
        //        var img = ImageHelper.GetImageFromBase64(ContractBase64Icons.PaidIconBase64);
        //        e.PaintBackground(e.ClipBounds, false);

        //        Point pt = e.CellBounds.Location;  // where you want the bitmap in the cell

        //        int offset = (e.CellBounds.Width - img.Width) / 2;
        //        pt.X += offset;
        //        pt.Y += 1;
        //        e.Graphics.DrawImage(img, pt);
        //        //img.Draw(e.Graphics, pt, 0);
        //        e.Handled = true;
        //    }
        //}
    }
}
