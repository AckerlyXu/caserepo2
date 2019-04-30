using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.crossPageDemo
{
    public partial class AddWhiteBorderToPicture : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

          Bitmap map =  WhiteUp(System.Drawing.Image.FromFile(Server.MapPath("/images/WingtipToys/boatbig.png")), 20, 40,"www.example.image.com");
            map.Save(Server.MapPath("/images/borderboat.png"));
        }
        public Bitmap WhiteUp(System.Drawing.Image img, int hmargin, int vmargin,string water)
        {
            int width = img.Width;
            int height = img.Height;
            float dpiX = img.HorizontalResolution;
            float dpiY = img.VerticalResolution;
            Bitmap map = new Bitmap(width + 2 * hmargin, height + vmargin * 2, PixelFormat.Format24bppRgb);
            map.SetResolution(dpiX, dpiY);
            Graphics grp = Graphics.FromImage(map);
            System.Drawing.Rectangle Rec = new System.Drawing.Rectangle(0, 0, width + 2 * hmargin, height + vmargin * 2);
            SolidBrush mySolidBrush = new SolidBrush(System.Drawing.Color.Yellow);
            grp.FillRectangle(mySolidBrush, Rec);
            grp.DrawImage(img, hmargin, vmargin, Rec, GraphicsUnit.Pixel);


           SolidBrush brush  = new SolidBrush(Color.Black);
            Font font = new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Pixel);
            SizeF f = grp.MeasureString(water, font);
            Point position = new Point(0, (int)(map.Height - (f.Height) - 10));
            grp.DrawString(water,font,brush,position);
            grp.Dispose();
            return map;
        }
    }

  
}