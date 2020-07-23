using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebSite.Models
{
    public class Student
    {

        public int StudentId { get; set; }
        public string Name { get; set; }

        public string Dob { get; set; }
        public int RollNo { get; set; }
        public int Address { get; set; }
        public int Marks { get; set; }

        public int TotalMark { get; set; }

    }
}
