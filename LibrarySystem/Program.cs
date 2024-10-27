namespace LibrarySystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in our library");
            Library library = new Library();
            Console.WriteLine("Are you librarian or user (L/U)");

            char userType = Console.ReadLine().ToUpper()[0];

            if (userType == 'L')
            {
                Console.WriteLine("Welcome Librarian, Enter your name");
                var userName = Console.ReadLine();
                Librarian librarian = new Librarian(userName);
                Console.WriteLine($"Welcome {librarian.Name}!");
                Console.WriteLine("Please Choose to Add Book (A) / Remove Book (R) /Display Book (D) ");
                char choice = Console.ReadLine()[0];
                switch(choice)
                {
                    case 'A':
                        Console.WriteLine("Enter Book Details ");
                        string bookName = Console.ReadLine();
                        string bookAuthor = Console.ReadLine();
                        int bookYear = Convert.ToInt32(Console.ReadLine());

                        Book book = new Book()
                        {
                            title = bookName,
                            author = bookAuthor,
                            year = bookYear,
                        };
                        librarian.AddBook(book,library);
                        break;

                    case 'R':
                        Console.WriteLine("Enter Book Details ");
                         bookName = Console.ReadLine();
                         bookAuthor = Console.ReadLine();
                         bookYear = Convert.ToInt32(Console.ReadLine());

                        book = new Book()
                        {
                            title = bookName,
                            author = bookAuthor,
                            year = bookYear,
                        };
                        librarian.RemoveBook(book, library);
                        break;

                    case 'D':
                        Console.WriteLine("The Book List ");
                        librarian.DisplayBook(library);
                        break;
                }


            }
            else if (userType =='R')
            {

            }
            else
            {
                Console.WriteLine("Please Enter Correct Value (L/R) ");
            }

            Console.ReadKey();
        }
    }
}