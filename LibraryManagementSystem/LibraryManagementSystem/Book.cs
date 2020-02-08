using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    class Book
    {
       /* private String bookname;
        private int bookid; // TODO: readonly can be added once you make it as system generated
        private string author; // TODO: String should using correct characters. 
        */
       
        public int Bookid { get; set; }

        public String Bookname { get; set; }

        public String Author { get; set; }

        public Book(String Bookname,  String Author)
        {
            this.Bookname = Bookname;
            
            this.Author = Author;
        }

        public Book(int bookid, string bookname, string author)
        {
            Bookid = bookid;
            Bookname = bookname;
            Author = author;
        }





        /*  public String Display()
          {
              return $"book name is..{this.bookname}...book id is ...{this.bookid}...& author name is...{this.author}..";

          }
          */

    }
}
