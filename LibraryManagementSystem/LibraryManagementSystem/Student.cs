using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    class Student
    {
       /* private String studentid;
        private String studentname;
        private String YOP;   */

       

        public String Studentname { get; set; }
        public int Studentid { get; set; }
         // TODO: year is String? 
       public int yOP { get; set; }
        public Student(int Studentid, String Studentname, int yOP)
        {
            this.Studentid = Studentid;
            this.Studentname = Studentname;
            this.yOP = yOP;
        }

       

        
    }
}
