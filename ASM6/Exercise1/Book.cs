using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM6
{
    class Book
    {
        private string bookName, ISBNNumber, authorName, publisherName;
        public Book()
        {

        }
        public Book(string bookName, string ISBNNumber, string authorName, string publisherName)
        {
            this.bookName = bookName;
            this.ISBNNumber = ISBNNumber;
            this.authorName = authorName;
            this.publisherName = publisherName;
        }


        public string GetBookInformation()
        {
            return ISBNNumber + "\t" + bookName + "\t" + authorName + "\t" + publisherName;
        }
    }
}
