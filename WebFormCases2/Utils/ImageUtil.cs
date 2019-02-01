using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;

namespace MyWebFormCases.Utils
{
    public class ImageUtil
    {
        public static Bitmap MergerImg(int width, int height,params Bitmap[] maps)
        {
            int i = maps.Length;


            //Create a picture object to display, set the width according to the number of parameters
            Bitmap backgroudImg = new Bitmap(i * width, height);
            Graphics g = Graphics.FromImage(backgroudImg);

            //Clear the canvas, the background is set to white
            g.Clear(System.Drawing.Color.White);

            for (int j = 0; j < i; j++)
            {
                g.DrawImage(maps[j], j * width, 0, maps[j].Width, maps[j].Height);
            }
            g.Dispose();
            return backgroudImg;
        }

        public static byte[] MakeThumbnail(byte[] bytes, int width, int height, string mode)
        {
            MemoryStream stream = new MemoryStream(bytes, 0, bytes.Length);
                     
            System.Drawing.Image originalImage = System.Drawing.Image.FromStream(stream);
          

            int towidth = width;
            int toheight = height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            switch (mode)
            {
                case "HW":
                    break;
                case "W":
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case "H":
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "Cut":
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                default:
                    break;
            }


            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);


            Graphics g = System.Drawing.Graphics.FromImage(bitmap);


            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;


            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;


            g.Clear(Color.Transparent);


            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight),
             new Rectangle(x, y, ow, oh),
             GraphicsUnit.Pixel);

            try
            {
                MemoryStream streamtarget = new MemoryStream();
          
                bitmap.Save(streamtarget, System.Drawing.Imaging.ImageFormat.Jpeg);
                return streamtarget.ToArray();

            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
        }

                                                                     // the unit is kb
        public static MemoryStream Zip(Image img, ImageFormat format, long targetLen
            
           // , long srcLen = 0
            )
        {
            //设置允许大小偏差幅度 默认10kb
            const long nearlyLen = 1024;

            long srcLen = 0;
            var ms = new MemoryStream();
           if (0 == srcLen)
            {
                img.Save(ms, format);
                srcLen = ms.Length;
            }

            targetLen *= 1024;
            if (targetLen >= srcLen)
            {
                ms.SetLength(0);
                ms.Position = 0;
                img.Save(ms, format);
                return ms;
            }

            
            var exitLen = targetLen - nearlyLen;

            
            var quality = (long)Math.Floor(100.00 * targetLen / srcLen);
            var parms = new EncoderParameters(1);

            
            ImageCodecInfo formatInfo = null;
            var encoders = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo icf in encoders)
            {
                if (icf.FormatID == format.Guid)
                {
                    formatInfo = icf;
                    break;
                }
            }

           
            long startQuality = quality;
            long endQuality = 100;
            quality = (startQuality + endQuality) / 2;

            while (true)
            {
                
                parms.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

               
                ms.SetLength(0);
                ms.Position = 0;
                img.Save(ms, formatInfo, parms);

                if (ms.Length >= exitLen && ms.Length <= targetLen)
                {
                    break;
                }
                else if (startQuality >= endQuality) 
                {
                    break;
                }
                else if (ms.Length < exitLen) 
                {
                    startQuality = quality;
                }
                else 
                {
                    endQuality = quality;
                }

              
                var newQuality = (startQuality + endQuality) / 2;
                if (newQuality == quality)
                {
                    break;
                }
                quality = newQuality;

               
            }
            return ms;
        }


    }
}