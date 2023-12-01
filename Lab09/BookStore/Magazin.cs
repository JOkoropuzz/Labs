
namespace BookStore
{
    class Magazine : Item, IPubs
    {
        private String volume; // том
        private int number; // номер
        private String title; // название
        private int year; // год выпуска
        public bool IfSubs { get; set; }

        public Magazine(String volume, int number, String title, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }
        public Magazine() { }

        public void Subs()
        {
            Console.WriteLine("Подписка на журнал \"{0}\": {1}.", title, IfSubs);
        }
        public override void Show()
        {
            Console.WriteLine("\nЖурнал:\nТом: {0}\nНомер: {1}\nНазвание: {2}\nГод выпуска: {3} ", volume, number, title, year);
            base.Show();
        }

        public override void Return() // операция "вернуть"
        {
            taken = true;
        }
    }
}
