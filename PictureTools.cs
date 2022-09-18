using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fringilla
{
    class PictureTools
    {
        public static Boolean IsPictureIsColor(Bitmap bmp)
        {
            int colorIndexer = 0;
            int greyIndexer = 0;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color detColor = bmp.GetPixel(i, j);

                    if (detColor.R != detColor.G || detColor.G != detColor.B || detColor.R != detColor.B)
                    {
                        colorIndexer++;
                    }
                    else
                    {
                        greyIndexer++;
                    }
                }
            }

            if(colorIndexer > greyIndexer)
            {
                return true;        // the picture is color
            }
            else
            {
                return false;       // the picture is greyscale
            }
        }
        public static Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public static void UpdateImageWindow(PictureBox updatedBox, Image updatedBitmap)
        {
            Image newImage = updatedBitmap;
            newImage = ResizeImage(updatedBitmap, new Size(updatedBox.Width, updatedBox.Height));
            updatedBox.Image = newImage;
        }
        public static Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }
            return rotatedImage;
        }
        public static void DrawMeCircle(Graphics inObject, Point coordinates, Color penColor, int penWidth, int radius)
        {
            DCircle hiCircle = new DCircle();
            Pen pen = new Pen(penColor);
            pen.Width = penWidth;

            hiCircle.drawingArea = inObject;
            hiCircle.radius = radius;
            hiCircle.penToUse = pen;
            hiCircle.center = coordinates;
            hiCircle.GetCircle(hiCircle.drawingArea, hiCircle.penToUse, hiCircle.center, hiCircle.radius);
        }
        public static void DrawMeAim(Graphics inObject, Point coordinates, Pen pen, int length)
        {
            DAim myAim = new DAim();
            myAim.drawingArea = inObject;
            myAim.penToUse = pen;
            myAim.GetAim(myAim.drawingArea, myAim.penToUse, coordinates, length);
        }
    }
}
