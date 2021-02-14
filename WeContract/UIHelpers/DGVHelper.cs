using System.Drawing;
using System.Windows.Forms;

namespace WeContract.UIHelpers
{
	public static class DGVHelper
	{
		public static void DrawHeaderIcon(DataGridViewCellPaintingEventArgs e, Image img, Point offset, bool center = true)
		{
			e.PaintBackground(e.ClipBounds, false);

			Point pt = e.CellBounds.Location;  // where you want the bitmap in the cell

			pt.X += center ? (e.CellBounds.Width - img.Width) / 2 : offset.X;
			pt.Y += 1 + offset.Y;
			e.Graphics.DrawImage(img, pt);
			e.Handled = true;
		}
	}
}
