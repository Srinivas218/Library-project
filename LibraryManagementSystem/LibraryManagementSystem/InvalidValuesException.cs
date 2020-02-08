using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    class InvalidValuesException : Exception
    {
        public void  Exception()
        {
            Console.WriteLine("give me proper values please ");
        }
    }
}
