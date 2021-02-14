using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace WeContractLib.Storage
{
	public static class ImageHelper
    {
        /// <summary>
        /// Gets an image from a Base64 string.
        /// </summary>
        /// <param name="base64String">Base64 Encoded string</param>
        /// <returns>The converted image or <see langword="null"/>.</returns>
        /// <remarks>Remember to check for <see langword="null"/>!</remarks>
        public static Image GetImageFromBase64(string base64String) => Image.FromStream(new MemoryStream(Convert.FromBase64String(base64String)));

        /// <summary>
        /// Modifies the highlight color of an <see cref="Image"/>.
        /// </summary>
        /// <param name="img">The Image</param>
        /// <param name="color">The color to change to</param>
        /// <returns>The modified image</returns>
        /// <remarks>This will only change pixels with an Alpha value above 100.</remarks>
        public static Image ModifyImageColor(Image img, Color color)
        {
            var bmp = new Bitmap(img);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    if (bmp.GetPixel(x, y).A > 100)
                    {
                        bmp.SetPixel(x, y, color);
                    }
                }
            }
            return bmp;
        }

        public static Bitmap CombineBitmapGrid(Image[] imageList, int columns = 0, int rows = 0, int space = 3)
        {
            //read all images into memory
            var images = new List<Bitmap>();
            var imageSize = imageList[0].Size;
            Bitmap finalImage = null;

            foreach (var image in imageList)
            {
                if (image.Width > imageSize.Width)
                {
                    imageSize.Width = image.Width;
                }

                if (image.Height > imageSize.Height)
                {
                    imageSize.Height = image.Height;
                }
            }
            try
            {
                var width = (imageSize.Width + space) * columns - space;
                var height = (imageSize.Height + space) * rows - space;

                foreach (var image in imageList)
                {
                    //create a Bitmap from the file and add it to the list
                    var bitmap = new Bitmap(image);

                    images.Add(bitmap);
                }

                //create a bitmap to hold the combined image
                finalImage = new Bitmap(width, height);

                //get a graphics object from the image so we can draw on it
                using (var g = Graphics.FromImage(finalImage))
                {
                    //set background color
                    g.Clear(Color.Transparent);

                    //go through each image and draw it on the final image
                    var offsetX = 0;
                    var offsetY = 0;

                    for (var i = 0; i < images.Count; i++)
                    {
                        var image = images[i];
                        g.DrawImage(image,
                          new Rectangle(offsetX, offsetY, image.Width, image.Height));
                        offsetX += image.Width + space;

                        // Start on a new row if offsetX is larger than the finalImage.Width.
                        if (offsetX >= width)
                        {
                            offsetY += image.Height + space;
                            offsetX = 0;
                        }
                    }
                }

                return finalImage;
            }
            catch (Exception)
            {
                if (finalImage != null)
                    finalImage.Dispose();
                //throw ex;
                throw;
            }
            finally
            {
                //clean up memory
                foreach (var image in images)
                {
                    image.Dispose();
                }
            }
        }
    }
}
