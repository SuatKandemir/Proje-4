using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Info
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int  Age { get; set; }
        public int DateTime { get; set;}
        public double Average { get; set;}
        public string StudentID { get; set; }
        public string  Department { get; set; }
        public string Mathag {  get; set; }
        public string Literatureag { get; set; }
        public string Hisoryag { get; set; }
        public void Lesson(Info info1)
        {
            Console.WriteLine("Math Average:" +info1.Mathag);
            Console.WriteLine("History Average:" +info1.Hisoryag );
            Console.WriteLine("Literature Average:" +info1.Literatureag);
        }
        public void Less(Info info2)
        {
            Console.WriteLine("Math Average: " + info2.Mathag);
            Console.WriteLine("History Average: " + info2.Hisoryag );
            Console.WriteLine("Literature Average: " + info2.Literatureag);
        }
        public void Les(Info info3)
        {
            Console.WriteLine("Math Average: " + info3.Mathag);
            Console.WriteLine("History Average: " + info3.Hisoryag);
            Console.WriteLine("Literature Average: " + info3.Literatureag);
        } 

    }
}
 
 
