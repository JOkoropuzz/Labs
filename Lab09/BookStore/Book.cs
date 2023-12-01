namespace BookStore
{
    class Book : Item
    {
        private string author; // автор
        private string title; // название
        private string publisher;// издательство
        private int pages; // кол-во страниц
        private int year; // год издания

        private bool returnSrok;

        private static double price = 9;

        public Book(string author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        public Book() { }

        static Book() //статический конструктор
        {
            price = 10;
        }

        public Book(string author, string title, string publisher, int pages, int year, long invNumber, bool taken) : base (invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }


        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public override void Show()
        {
            Console.WriteLine("Книга:\n Автор: {0}\n Название: {1}", author, title);
            Console.WriteLine("Стоимость аренды: {0}", Book.price);
            Console.WriteLine("{0} стр.", pages);
            Console.WriteLine("Год издания: {0}", year);
            
            
            base.Show();
        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }

        public void ReturnSrok()
        {
            returnSrok = true;
        }

        public override void Return() // операция "вернуть"
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }

    }
}