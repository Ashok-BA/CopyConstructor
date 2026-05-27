////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace CopyConstructor
////{
////    class student
////    {
////        public int sid;
////        public string sname;

////        //public student(int sid, string sname)//instance constructor
////        //{
////        //    this.sid = sid;
////        //    this.sname = sname;
////        //}

////        public student(student obj)//copy constructor
////        {
////            this.sid = obj.sid;
////            this.sname = obj.sname;
////        }
////        public void StudentDisplay()
////        {
////            Console.WriteLine("Student ID is:" + sid);
////            Console.WriteLine("Student Name is" + sname);
////        }
////    }
////    internal class Program
////    {
////        static void Main(string[] args)
////        {
////            student obj1 = new student(1,"Rama");
////            obj1.StudentDisplay(); // obj1.sid=1; obj1.sname=rama

////            student obj2 = new student(obj1);
////            obj2.StudentDisplay(); // obj2.sid = 1; obj2.sname = rama

////        }
////    }
////}
