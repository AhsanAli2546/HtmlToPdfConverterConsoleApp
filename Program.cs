using System;


namespace HtmlToPdfConverter
{
    class Program
    {
        
        static void Main(string[] args)
        {

            string pdfName, url,path;
            int i = 0;
            

            do
            {
                Console.Write("Please enter pdf name: ");
                pdfName = Console.ReadLine();
                Console.Write("Please enter URL: ");
                url = Console.ReadLine();

                path = HtmlToPdf.Convert(pdfName,url);
                if (!String.IsNullOrEmpty(path))
                {
                    Console.Write("Pdf generated successfully => " + path);
                }
                else
                {
                    Console.Write("Something went wrong...");
                }
                Console.Write("do you want ot continue press 0 or to exit press 1: ");
                i = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (i < 1);
            
        }
   

    }
}


