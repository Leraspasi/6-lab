using System;


namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            GenMeth();
            Console.ReadKey();

        }
        public static void GenMeth()
        {
            string [] firstArr = new string[2] { "Book1", "Book2" };
            string [] secondArr = new string[2] { "Magazine1", "Magazine2" };
           
            AllJournals allJournals = new AllJournals(firstArr,secondArr);
            allJournals.AllJ();
            allJournals.Info();
        }
    }
    interface Printable
    {
        void Print();
    }
   
   
    class Book:Printable
    {
        string [] BooksName { get; set; }
        public Book(string [] allBooks)
        {
            this.BooksName = allBooks;
        }
        public void Print()
        {
            Console.WriteLine($"First Book - {BooksName[0]}");
            Console.WriteLine($"First Book - {BooksName[1]}");
        }

        public void PrintBooks(Printable[] printable)
        {
            printable = new Printable[1];
            printable[0] = new Book(BooksName);
            foreach (Printable allBooks in printable)
            {
                allBooks.Print();
            }
        }
    }
    class Magazine:Printable
    {
        string[] MagazinesName { get; set; }
        public Magazine(string[] allMagazines)
        {
            this.MagazinesName = allMagazines;
        }
        public void Print()
        {
            Console.WriteLine($"First Magazine - {MagazinesName[0]}");
            Console.WriteLine($"First Magazine - {MagazinesName[1]}");
        }

        public void PrintMagazines(Printable[] printable)
        {
            printable = new Printable[1];
            printable[0] = new Magazine(MagazinesName);
            foreach (Printable allMagazines in printable)
            {
                allMagazines.Print();
            }
        }
    }
    class AllJournals
    {
        Printable[] printables = new Printable[2];
        public string [] jBooks { get; set; }
        public string[] jMagazines { get; set; }

        public AllJournals(string[] jBooks, string[] jMagazines)
        {
            this.jBooks = jBooks;
            this.jMagazines = jMagazines;
        }
      
        public void AllJ()
        {
            Console.WriteLine("ALL BOOKS AND MAGAZINES:");
            printables[0] = new Book(jBooks);
            printables[1] = new Magazine(jMagazines);

            foreach (Printable allgetprint in printables)
            {
                allgetprint.Print();
            }
        }
        public void Info()
        {
            Console.Write("\n");
            Console.WriteLine("ONLY BOOKS:");
            Book books = new Book(jBooks);
            Printable[] printables1 = { books };
            foreach (Book toprint in printables1)
            {
                toprint.PrintBooks(printables1);
            }
            Console.Write("\n");
            Console.WriteLine("ONLY MAGAZINES:");
            Magazine magazines = new Magazine(jMagazines);
            Printable[] printables2 = {magazines};
            foreach (Magazine toprint in printables2)
            {
                toprint.PrintMagazines(printables2);
            }
        }
       
    }
}
