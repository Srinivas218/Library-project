using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    interface Methods
    {
        int AddBook(Book book);                    //completed...1
       
        String AddStudent(Student student);             //completed..2
       
        bool IssueABook(int sid,int bid);                //cmpltd    3
        bool RemoveStudent(int studentid );                //cmpltd          4
        void SearchBook(String bookname );    //issued books... 5
                           // 6

        
        List<Student> getAllStudents();                  //7

       
        List<Book> DisplayBooks(); 
        
       
        bool RenewBook(int Bid,int Sid);                        //9
        bool ReturnBook(int studentid,int bookid);                           //10
        bool RemoveBook(int bookid);
        List<IssueBook> DisplayIssuedBooks();

    }
}
