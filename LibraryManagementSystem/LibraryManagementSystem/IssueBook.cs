using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    class IssueBook
    {
       
        public DateTime IssueDate { get; set; }
        public DateTime Returndate { get; set; }

        
       
        public int Sid { get; set; }
        public int Bid { get; set; }

        //TODO: String is not using the correct case.
        public IssueBook(DateTime issueDate, DateTime returndate, int sid, int bid)
        {
            // TODO: this keyword are not used.
            this.IssueDate = issueDate;
            this.Returndate = returndate;
            this.Sid = sid;
            this.Bid = bid;
        }
        
        
            
        public IssueBook(int sid, int bid)
        {
            Sid = sid;
            Bid = bid;
            IssueDate = DateTime.Now;
            Returndate = IssueDate.AddDays(30);

            // TODO: this keyword are not used.
            //IssueDate = issueDate; //TODO: Set today's date as issue date
            //Returndate = returndate; // TODO: Calculate retrun date based on issue date

        }

        public String Rsid { get; set; }
       
        public String Rbid { get; set; }

       
    }
}
