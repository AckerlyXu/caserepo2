using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCases2.officesample
{
    public partial class RenderAspxAspdf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();
            Response.ContentType = "application/pdf";
            HttpClient client = new HttpClient();
           HttpResponseMessage message = client.GetAsync("http://localhost:53239/Default").Result ;
           string result = message.Content.ReadAsStringAsync().Result.Replace("\r\n","").Replace("\t","").Replace("\\","");
       
            Byte[] bytes;

            //Boilerplate iTextSharp setup here
            //Create a stream that we can write to, in this case a MemoryStream
            using (var ms = new MemoryStream())
            {

                //Create an iTextSharp Document which is an abstraction of a PDF but **NOT** a PDF
                using (var doc = new Document())
                {

                    //Create a writer that's bound to our PDF abstraction and our stream
                    using (var writer = PdfWriter.GetInstance(doc, ms))
                    {

                        //Open the document for writing
                        doc.Open();

                        //Our sample HTML and CSS
                        var example_html = @"<p>This <em>is </em><span class=""headline"" style=""text-decoration: underline;"">some</span> <strong>sample <em> text</em></strong><span style=""color: red;"">!!!</span></p>";
                        var example_css = @".headline{font-size:200%}";

                        /**************************************************
                         * Example #1                                     *
                         *                                                *
                         * Use the built-in HTMLWorker to parse the HTML. *
                         * Only inline CSS is supported.                  *
                         * ************************************************/

                        //Create a new HTMLWorker bound to our document
                        using (var htmlWorker = new iTextSharp.text.html.simpleparser.HTMLWorker(doc))
                        {

                            //HTMLWorker doesn't read a string directly but instead needs a TextReader (which StringReader subclasses)
                            using (var sr = new StringReader(result))
                            {

                                //Parse the HTML
                                htmlWorker.Parse(sr);
                            }
                        }

                       


                        doc.Close();
                    }
                }

                //After all of the PDF "stuff" above is done and closed but **before** we
                //close the MemoryStream, grab all of the active bytes from the stream
                bytes = ms.ToArray();
            }
            Response.End();
        }
    }
}