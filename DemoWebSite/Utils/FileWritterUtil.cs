using DemoWebSite.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebSite.Utils
{
    public class FileWritterUtilcs
    {
        public  void WriteFunction(Student student)
        {

            using (StreamWriter writer = new StreamWriter(@"D:\ALL\Ozone Traing\Batch3\SRC2\DemoWebSite\DemoWebSite\Output\Result.txt", true)) //// true to append data to the file
            {
                writer.WriteLine("Name=="+ student.Name);
                writer.WriteLine("TotalMark==" + student.TotalMark);
                writer.Close();
            }

           
        }

    }
}
