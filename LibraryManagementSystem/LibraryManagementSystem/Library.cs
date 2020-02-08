using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class Library
    {
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to honey library...");

            Console.WriteLine("press 1 to stop the transuction");
            Console.WriteLine("press 0 to continue the ");
            int choice = Int32.Parse(Console.ReadLine());
            while (choice == 0) 
            {
                BookOparation rv = new BookOparation();


                //book 
                //student
                //issue or return or remove

                Console.WriteLine("Press 1  for add a book...:");
                Console.WriteLine("press 2  for display the NO>OF books present in the library");
                Console.WriteLine("press 3  for search books you are added....");
                Console.WriteLine("press 4  for renew the book...:");
                Console.WriteLine("press 5  for add student information...:");
                Console.WriteLine("press 6  for search for the issued booksthe book...:");
                Console.WriteLine("press 7  for display the students...:");
                Console.WriteLine("press 8  for remove a student information...:");
                Console.WriteLine("press 9  for issue a book.....");
                Console.WriteLine("press 10 for Return the book....");
                Console.WriteLine("press 11 for Remove the book......insert added Book information   .");
                Console.WriteLine("press 12 to display the issue books ");


                // for take the details from user...

                String a = Console.ReadLine();
                Int32 num = Convert.ToInt32(a);

                if (num == 1)
                {
                    Console.WriteLine("enter book title...");
                    String bookname = Console.ReadLine();
                    Console.WriteLine("enter author name");
                    string author = Console.ReadLine();

                    Book book = new Book(bookname, author);
                    int abcd = rv.AddBook(book);
                    Console.WriteLine("your book id is...."+abcd);
                }
                else if (num == 2)
                {
                     List<Book> display=rv.DisplayBooks();
                    foreach(Book book in BookOparation.bookList)
                    {
                        Console.WriteLine(book.Bookid + "  ||   " + book.Bookname + "   ||   " + book.Author);
                    }
                    
                }

                else if (num == 3)
                {
                    Console.WriteLine("enter book name...");
                    String bookname = Console.ReadLine();
                    rv.SearchBook(bookname);
                }
                else if (num == 4)
                {
                    Console.WriteLine("enter student id....");
                    int sid = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter book id ....");
                    int bid = int.Parse(Console.ReadLine());
                    DateTime issueDate = (DateTime.Now);
                    DateTime returnDate = (issueDate.AddDays(15));
                   bool status= rv.RenewBook(sid,bid);
                    if(status==true)
                    {
                        Console.WriteLine($"book is renwealed you have to submit on {DateTime.Now.AddDays(15)}");
                    }
                    else
                    {
                        Console.WriteLine("sorry unable to process...");
                    }
                }
                else if (num == 5)
                {
                    Console.WriteLine("enter year of joining of the student ");
                    int yoj = int.Parse(Console.ReadLine());

                    //yoj is reffered as year of joining 
                    if ((yoj >= 2020) && (yoj <= 2024))
                    {
                        Console.WriteLine("enter student id number...");
                        int Studentid = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter student name...");
                        String studentname = Console.ReadLine();
                        int yop = yoj + 4;                              //yop is nothing but year of passed out ....
                        Student student = new Student(Studentid, studentname, yop);
                        String students=rv.AddStudent(student);
                        Console.WriteLine(students);
                    }
                    else
                    {
                        Console.WriteLine("sorry unable to process .....");
                        Console.WriteLine("enter valid year of joining in between 2020    to 2024....");
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                }
                else if (num == 6)
                {
                    Console.WriteLine("enter student id....");
                    int sid = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter book id ....");
                    int bid = int.Parse(Console.ReadLine());
                    rv.IssueABook(sid, bid);


                }

                else if (num == 7)
                {

                   List<Student> students= rv.getAllStudents();
                    if (students != null)
                    {
                        foreach (Student student in students)
                        {
                            Console.WriteLine(student.Studentid +" "+ student.Studentname);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No students");
                    }

                }

                else if (num == 8)
                {
                    Console.WriteLine("enter student id.....");
                    int studentid = int.Parse(Console.ReadLine());
                    bool statement=rv.RemoveStudent(studentid);
                    Console.WriteLine(statement);
                }

                else if (num == 9)
                {

                    Console.WriteLine("enter student id....");
                    int sid = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter book id ....");
                    int bid = int.Parse(Console.ReadLine());
                    
                    bool print= rv.IssueABook(sid, bid);
                    if(print==true)
                    {
                        Console.WriteLine($"book is issued to {sid}");
                    }
                    else
                    {
                        Console.WriteLine("Student id not matching with bookid...");
                    }

                }
                else if (num == 10)
                {
                    Console.WriteLine("enter book id....");
                    int bookid = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter student id......");
                    int studentid = int.Parse(Console.ReadLine());
                    bool status=rv.ReturnBook(bookid, studentid);
                    if(status==true)
                    {
                        Console.WriteLine("thanks for submission ");
                    }
                    else
                    {
                        Console.WriteLine("Student id not matching with bookid.....");
                    }
                }

                else if (num == 11)
                {
                    Console.WriteLine("enter book id...");

                    int bid = int.Parse(Console.ReadLine());
                   bool status= rv.RemoveBook(bid);
                    if(status==true)
                    {
                        Console.WriteLine("book is removed");
                    }
                    else
                    {
                        Console.WriteLine("book is not removed...");
                    }

                }
                else if (num == 12)
                {
                   List<IssueBook> display= rv.DisplayIssuedBooks();
                    foreach(IssueBook issue in display)
                    {
                        Console.WriteLine(issue);
                    }
                }
            }
        }


    }
 }

