

namespace LibraryApp2
{
     class Book
    {
            
        private string title;
        private string author;
        private string isbn;

        public string Title
        {
            get { return Title; }  
            set { Title = value; }  
        }
        public string Author
        {
            get { return Author; }  
            set { Author = value; }
        }
        public string ISBN
        {
            get { return ISBN; }  
            set { ISBN = value; }
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}

 

