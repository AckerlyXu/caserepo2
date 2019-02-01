using MyWebFormCases.Utils;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.fileDemo
{
    public partial class zipuploadedImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpFileCollection _HttpFileCollection = Request.Files;
            for (int i = 0; i < _HttpFileCollection.Count; i++)
            {
                HttpPostedFile _HttpPostedFile = _HttpFileCollection[i];
                if (_HttpPostedFile.ContentLength > 0)
                {
                    //_HttpPostedFile.SaveAs(Server.MapPath("~/images/small/" + Path.GetFileName(_HttpPostedFile.FileName)));
                    //byte[] bys = new byte[_HttpPostedFile.ContentLength];
                    //_HttpPostedFile.InputStream.Write(bys,0 , bys.Length);
                    System.Drawing.Image image = System.Drawing.Image.FromStream(_HttpPostedFile.InputStream);
                   MemoryStream stream =  ImageUtil.Zip(image, ImageFormat.Jpeg, 100);
                    File.WriteAllBytes(Server.MapPath("~/images/small/" + Path.GetFileName(_HttpPostedFile.FileName)), stream.ToArray());
                }
            }

                    
        }
    }
}