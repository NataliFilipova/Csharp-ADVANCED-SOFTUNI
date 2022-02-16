using System.Collections.Generic;

namespace _1.Library
{
    internal class LibraryItterator : IEnumerator<Book>
    {
        private List<Book> books;

        public LibraryItterator(List<Book> books)
        {
            this.books = books;
        }
    }
}