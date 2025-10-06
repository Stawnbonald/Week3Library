using Library;
using LibraryApp2;

class Program
{     static void Main(string[] args)
    {
        Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565");
        Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084");
        Console.WriteLine("Currently available books:");
        book.DisplayInfo(); 
        book1.DisplayInfo();


        //Create new istances of the Member class
        Member member = new Member(1, "John Doe", "123 Main St", 5551234);
        Member member1 = new Member(2, "Jane Smith", "456 Oak Ave", 5555678);
        Console.WriteLine("Library Members:");
        member.DisplayInfo();
        member1.DisplayInfo();

        Console.ReadLine();
        Console.Beep();
    }
}