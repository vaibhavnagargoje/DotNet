using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (FileStream fs = File.OpenWrite("../../../Employee.txt")) 
                {
                string text = "employee data \n Id : 1\n name : Vaibhav \n city: pune \n salary : 234242\n";
                byte[] data = Encoding.UTF8.GetBytes(text);
                fs.Write(data, 0, data.Length);
                }
                //using (StreamWriter sw )



            using (StreamWriter sw = File.AppendText("../../../Employee.txt"))
            {

                string text1 = "name: santosh\n city: karmala \n salary : 5000";
                sw.WriteLine(text1);

            }





            using(FileStream fs = File.OpenRead("../../../Employee.txt"))
                {
                    byte[] b = new byte[fs.Length];
                    fs.Read(b, 0, b.Length);
                    Console.WriteLine(Encoding.UTF8.GetString(b));
                }
                if (File.Exists("../../../Employee.txt"))
                {
                    //
                }



            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
                
            }


            //#region  FileInfo
            DirectoryInfo directoryInfo = new DirectoryInfo("../../demoFolder");
            Console.WriteLine("Current direactory name: {0} ",directoryInfo.FullName);
            Console.WriteLine("Current direactory name: {0} ",directoryInfo.CreationTime);
            Console.WriteLine("chiled directories :\n");

            foreach(DirectoryInfo dir in directoryInfo.GetDirectories())
            {
                Console.WriteLine("Directtory Name :{0}", dir.FullName);
                Console.WriteLine("Directtory Name :{0}", dir.CreationTime);
                Console.WriteLine("Directtory Name :{0}", dir.Extension);
                Console.WriteLine("--------------------------------------------");
            }



            Console.ReadLine();
        }

    }
}
