using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = "E:\\prod\\";

            //string path = "C:\\MyFolde";
            //done



            foreach (string fileName in Directory.GetFiles(path))
            {
                string filepath = fileName;
                string result = string.Empty;
                Console.WriteLine(filepath);
                using (StreamReader r = new StreamReader(filepath))
                {

                    var json = r.ReadToEnd();
                    var test = json;
                    var lastComma = test.LastIndexOf(',');
                    foreach (var item in test)
                    {
                        if (lastComma != -1) result = test.Remove(lastComma, 1);
                    }
                }
                File.WriteAllText(filepath, result);





                //string result = string.Empty;
                //using (StreamReader r = new StreamReader(filepath))
                //{

                //    var json = r.ReadToEnd();
                //    var test = json;
                //    var lastComma = test.LastIndexOf(',');
                //    foreach (var item in test)
                //    {
                //        if (lastComma != -1) result = test.Remove(lastComma, 1);
                //    }

                //    //var test = "Service Control Manager repeated 5 times, Microsoft-Windows-DistributedCOM repeated 2 times, Control Manager repeated 6 times.";
                //    //var lastComma = test.LastIndexOf(',');
                //    //if (lastComma != -1) test = test.Remove(lastComma, 1);
                //}
                //File.WriteAllText(filepath, result);
            }
        }
    }
}
