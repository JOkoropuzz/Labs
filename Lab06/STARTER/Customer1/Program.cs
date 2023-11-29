
using System.Linq.Expressions;

class Test
    {
        static void Main(string[] args)
        {
            Tariff Standart = new Tariff("Standart");
            Tariff FiveMinus = new Tariff("FiveMinus", 0.5, 2, 5);
            Tariff TenPlus = new Tariff("TenPlus", 0.5, 1, 10);


            Customer Ivan = new Customer("Иван Петров", Standart, 500);
            Customer Elena = new Customer("Елена Иванова", FiveMinus);


            Console.WriteLine("Перед звонком");
            Console.WriteLine(Ivan);
            Console.WriteLine(Elena);

            Call call1 = new Call('Г', 10);
            Call call2 = new Call('М', 5);
            Ivan.RecordWithdraw(Ivan.TariffPlan.Withdraw(call1));
            Elena.RecordWithdraw(Elena.TariffPlan.Withdraw(call2));

            Console.WriteLine("После звонка");
            Console.WriteLine(Ivan);
            Console.WriteLine(Elena);

        }
    }
