using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v_0._2
{
    internal class Book
    {
        public int bookID;
        public string bookName;
        public string author;
        public string publisher;
        public int quantity;

        public string get_books()
        {
            string return_books = bookID.ToString() + " " + bookName + " " + author + " " +publisher + " " +quantity.ToString();
            return return_books;
        }

    }
}
