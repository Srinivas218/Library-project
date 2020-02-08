using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    class BookNotFoundException : Exception
    {
        public String bookNotFoundException()
        {
            return "sorry book is not available in the library";
        }
    }
}
