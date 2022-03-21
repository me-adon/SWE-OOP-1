using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_v_0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<User> users = new List<User>();

        private void AddUserOnClick(object sender, EventArgs e)
        {
            int userID;
            string name, address;

            userID = Convert.ToInt32(UserIdTextBox.Text);
            name = NameTextBox.Text;
            address = AddressTextBox.Text;

            User dummy_user = new User();

            dummy_user.name = name;
            dummy_user.address = address;
            dummy_user.userID = userID;

            users.Add(dummy_user);

            MessageBox.Show("User Added Successfully");

        }

        List<Book> books = new List<Book>();    

        private void AddBookOnClick(object sender, EventArgs e)
        {
            int bookID, quantity;
            string bookName, author, publisher;

            bookID = Convert.ToInt32(BookIdTextBox.Text);
            bookName = BookNameTextBox.Text;
            author = AuthorTextBox.Text;
            publisher = PublisherTextBox.Text;
            quantity = Convert.ToInt32(QuantityTextBox.Text);

            Book dummy_book = new Book();

            dummy_book.bookID = bookID;
            dummy_book.bookName = bookName;
            dummy_book.author = author;
            dummy_book.publisher = publisher;
            dummy_book.quantity = quantity;

            books.Add(dummy_book);

            MessageBox.Show("Books Added Successfully");
        }

        List <User> borrowed_books = new List<User>();

        private void BorrowOnClick(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(UserIdTextBox3.Text);
            int bookID = Convert.ToInt32(BookIdTextBox3.Text);

            for(int i=0;i<users.Count;i++)
            {
                if(userID == users[i].userID)
                {
                    for(int j=0; j<books.Count;j++)
                    {
                        if(bookID ==books[j].bookID)
                        {
                           // User dummy_borrowed_books = new User();
                            //dummy_borrowed_books.book_ID = bookID;
                            users[i].book_ID = bookID;

                            //users.Add(dummy_borrowed_books);
                            books[j].quantity -= 1;
                            MessageBox.Show("Book Borrowed");
                        }
                    }
                }
            }
        }

        private void ShowBookHistoryOnClick(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(BookIDtextBox2.Text);

            for(int i=0; i<books.Count;i++)
            {
                if(bookID == books[i].bookID)
                {
                    label10.Text = "Book ID : " + " " +bookID.ToString();
                    label11.Text = "Book Name : " + " " + books[i].bookName;
                    label12.Text = "Author : " + " " + books[i].author;
                    label13.Text = "Quantity : " + " " + Convert.ToString(books[i].quantity);
                }
            }
        }

        private void ShowUserHistoryOnClick(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(UserIdTextBox2.Text);
            IdNameListBox.Items.Clear();    
            for (int i=0; i<users.Count; i++)
            {
                IdNameListBox.Items.Add(users[i].get_users());

                //for (int j = 0; j < books.Count; j++)
                //{
                //    for (int k = 0; k < borrowed_books.Count; k++)
                //    {
                //        if (books[j].bookID == borrowed_books[k].book_ID)
                //        {
                //            IdNameListBox.Items.Add(books[j].get_books());
                //        }
                //    }

                //}
                int book__ID = users[i].book_ID;
                for(int j=0; j<books.Count; j++)
                {
                    if(book__ID == books[j].bookID)
                    {
                        IdNameListBox.Items.Add(books[j].get_books());
                    }
                    
                }
                
                break;
            }
            

        }
    }
}
