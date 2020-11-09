using System;
using System.Collections.Generic;
using System.Text;

namespace Compulsory_assigment
{
    public class Book
    {
        public  string Title { get { return _title; } }

        public string Author { get { return _author; } }

        public int PageNumber { get { return _pageNumber; } }

        public string ISBN13 { get { return _isbn13; } }

        private string _title;
        private string _author;
        private int _pageNumber;
        private string _isbn13;

        public Book(string newTitle, string newAuthor, int newPageNumber, string newIsbn13)
        {
            if (newTitle.Length < 2)
            {
                throw new ArgumentOutOfRangeException("Title is too short");
            }

            if (newPageNumber > 1000 || newPageNumber < 10)
            {
                throw new ArgumentOutOfRangeException("Page number is not valid");
            }

            if (newIsbn13.Length != 13)
            {
                throw new ArgumentOutOfRangeException("ISBN13 is not valid");
            }

            _isbn13 = newIsbn13;
            _pageNumber = newPageNumber;
            _title = newTitle;
            _author = newAuthor;

            

        }
      
    }
}
