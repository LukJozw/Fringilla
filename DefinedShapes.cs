using System.Drawing;


namespace Fringilla
{
    class DCircle
    {
        public Graphics drawingArea { get; set; }
        public Pen penToUse { get; set; }
        public Point center { get; set; }
        public int radius { get; set; }
        public void GetCircle(Graphics drawingArea, Pen penToUse, Point center, int radius)
        {
            Rectangle rect = new Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2);
            drawingArea.DrawEllipse(penToUse, rect);
        }
    }
    class DAim
    {
        public Graphics drawingArea { get; set; }
        public Pen penToUse { get; set; }
        public Point center { get; set; }
        public int length { get; set; }
        public void GetAim(Graphics drawingArea, Pen penToUse, Point center, int length)
        {
            drawingArea.DrawLine(penToUse, (float)(center.X - (0.5 * length)), center.Y, (float)(center.X + (0.5 * length)), center.Y);
        }
    }
}
