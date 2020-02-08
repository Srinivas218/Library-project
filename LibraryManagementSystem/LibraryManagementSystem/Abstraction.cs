using System;
using System.Collections.Generic;
using System.Text;
 
namespace LibraryManagementSystem
{
    class Abstraction
    {
        public static Methods getBook()
        {
            Methods mm = new BookOparation();
            return mm;

        }
    }
}
