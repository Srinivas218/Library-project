using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    class BookOparation : Methods
    {
        //to store books in the library..
        public static List<Book> bookList = new List<Book>();
        //To store Students in the library
        public static List<Student> studentList = new List<Student>();
        // To store issue books 
        public static List<IssueBook> exp = new List<IssueBook>();


        //TO add books in to the booklist
        public int AddBook(Book book)                            //1
        {
           int counter = 0;
           

            if (counter ==0)
            {
               
                bookList.Add(book);     
                 book.Bookid = bookList.Count;
            }
            return book.Bookid;
        }
        //TO add Students into the Students list
        public String AddStudent(Student student)                   //completed 2
        {
            int counter = 0;
            foreach(Student ss in studentList)
            {
                //validation for student is already exist or not
                if((ss.Studentid).Equals(student.Studentid))
                {
                    counter++;
                }
            }
                if(counter==0)
                {
                    studentList.Add(student);
                  return $"the student  {student.Studentname}  is added successfully..";
                   
                }
                else
                {
                    Console.WriteLine("Student already exist...");
                }
            return "Student record id added successfully..";
        }

       //To remove the student from the library list
        public bool RemoveStudent(int studentid)                      //completed  4
        {
            //validation for whether list have students or not
           if(studentList.Count>0)
            {
                foreach (Student sb in studentList)
                {
                    // validation for given student is is matching with the existed id
                    if ((sb.Studentid).Equals(studentid))
                    {
                        studentList.Remove(sb);
                        return true;
                    }
                }
            }
            return false;
        }
        //TO search a book in the issued book list
        public void SearchBook(String bookname)                          //keep on trying....5
        {
            List<Book> tbl = new List<Book>();
            int count = 0;
            //To check whether book is present in the library or not
            foreach (Book book in bookList)
            {
                if (book.Bookname.Equals(bookname))
                {
                    count++;
                    tbl.Add(book);
                }
            }
           if(count>0)
            {
                
                //??validation for book is issued or not
                foreach(Book book in tbl)
                {
                    int sum = 0;
                    foreach (IssueBook issueBook in exp)
                    {
                        if((book.Bookid).Equals(issueBook.Bid))
                        {
                            sum++;
                        }
                    }
                    if(sum==0)
                    {
                        Console.WriteLine("bookid is ..." + book.Bookid + "author is..." + book.Author + "book name is.." + book.Bookname);
                    }
                    else
                    {
                        Console.WriteLine("sorry unable to process....");
                    }
                }
             
            }
        }
        /*   for(int i=0;i<tbl.Count;i++)
                {
                    for(int j=0 ;j<exp.Count;j++)
                    {
                        if(tbl[i].Bookid.Equals(exp[i].Bid))
                        {
                            sum++;
                        }
                        
                    }
                }              
                if(sum==0)
                {
                    for(int i=0;i<tbl.Count;i++)
                    {
                        Console.WriteLine("bookid is ..." + tbl[i].Bookid + "author is..." + tbl[i].Author + "book name is.." + tbl[i].Bookname);
                    }
                }
                else
                {
                    Console.WriteLine("sorry unable to process....");
                }           */


        //TO search a book which is added in the library


        // To display number of students presents in the library list 


        public List<Student> getAllStudents()
        {
            if (studentList.Count>0)
            {
                return studentList;
            }
            else
            {
                return null;
            }
            
        }

        // To display number of books present in the library
        public List<Book> DisplayBooks()                              
        {
            //validation for book is present in the library or not
            return bookList;
        }

        // To renew the book for 15 days
        public bool RenewBook(int Bid,int Sid)                  // keep on trying.......9
        {
            int count = 0;
            foreach (IssueBook ii in exp)
            {
               // validation for book id and student id is matching or not
                if (((ii.Bid).Equals(Bid)) && (ii.Sid).Equals(Sid))
                {
                    ii.Returndate = DateTime.Now.AddDays(15);
                    count++;
                }
            }
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Return the book 
        // it returns true when book is return
        public bool ReturnBook( int Bid,int Sid)                             //10
        {
            int count = 0;
            foreach (IssueBook ii in exp)
            {
                //validation for bookid and student id is matching or not
                // if book is removed count is incremented by 1
                if (((ii.Bid).Equals(Bid)) && (ii.Sid).Equals(Sid))
                {
                    exp.Remove(ii);
                    count++;
                }
            }
            if(count>=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //To remove the book from the library
        // it returns true when the book is removed
        public bool RemoveBook(int bookid)                          //  11
        {
           
                foreach (Book rb in bookList)
                {
                    if ((rb.Bookid).Equals(bookid) )
                    {
                        bookList.Remove(rb);
                    return true;
                    }
                    else
                    {
                    return false;
                    }
                }
            return true;
        }


       //To display no.of books  which are issued
       //it returns issue books list

        public List<IssueBook> DisplayIssuedBooks()
        {
            if((exp.Count)>0)
            {
                return exp;
            }
            else
            {
                return null;
            }
        }
        //adding a book to the issue book list i,e exp list
        // It returns true when book is added to the exp list
        public bool IssueABook(int sid, int bid) 
        {
            
            int num = 0;
            // TO Verify whether student list has sid or not
            //if Student list has student then num is incremented by 1
            foreach(Student student in studentList)
            {
                if(sid==student.Studentid)
                {
                    num++;
                    break;
                }
            }
            // TO Verify whether bookslist has bid or not
            //If booklist has book id then num is incremented by 1
            
            if(num>0)
            {
                int sum = 0;
                foreach (Book book in bookList)
                {
                    if (bid==book.Bookid)
                    {
                        sum++;
                        break;
                    }
                }
                
                if (sum > 0)
                {
                    //To verify whether book is issued or not
                    // If book is issued then res is incremented by 1
                    int res = 0;
                    foreach (IssueBook issueBook in exp)
                    {
                        if (issueBook.Bid == bid)
                        {
                            res++;
                            break;
                        }
                    }
                    if(res==0)
                    {
                        int count = 0;

                        foreach (IssueBook isu in exp)
                        {
                            if (isu.Sid == sid)
                            {
                                count++;
                            }
                        }

                        if (count < 3)
                        {
                            IssueBook newIssue = new IssueBook(sid, bid);
                            DateTime issueDate = DateTime.Now;
                            DateTime returnDate = issueDate.AddDays(15);
                            newIssue.IssueDate = issueDate;
                            newIssue.Returndate = returnDate;
                            exp.Add(newIssue);
                            return true;
                        }
                    }
                 
                }
            }
            return false;
        }
        
        
    }
}
