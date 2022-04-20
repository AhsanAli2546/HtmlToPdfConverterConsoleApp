using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ceTe.DynamicPDF.HtmlConverter;

namespace HtmlToPdfConverter
{
    class HtmlToPdf
    {

        public static string Convert(string name, string url)
        {
            string root,msg;
            root = @"D:\Pdf";
            //C:\Users\ehxan\Downloads
            //https://www.youtube.com/watch?v=cbIWpa-RtYU
            if (!Directory.Exists(root))
            {
                System.IO.Directory.CreateDirectory(root);
            }

            try
            {
                string path = root + @"\" + name + ".pdf";
                Converter.Convert(new Uri(url),path);
                msg = path;
            }
            catch(Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }

    }
}
