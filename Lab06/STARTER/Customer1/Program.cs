using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    enum PhonePlan {Standart, TenPlus, FiveMinus}
    class Customer
    {
        public string Name { get; set; }
        public double Balance { get; private set; }
        public PhonePlan Plan { get; set; }  //Тарифный план клиента

        public Customer(string name, double balance = 100, PhonePlan phonePlan = PhonePlan.Standart) 
        {
            Name = name;
            Balance = balance;
            Plan = phonePlan; //Присвоение стандартного тарифного плана клиенту
        }

        public void ChangePlan() //Метод изменяющий тарифный план
        {
            Console.WriteLine("{0}, вам доступны слудющие тарифы: Standart, TenPlus, FiveMinus\nВведите название желаемого тарифа: ", Name);
            string answer = Console.ReadLine();
            if (answer == "Standart") { Plan = PhonePlan.Standart; }
            if (answer == "TenPlus") { Plan = PhonePlan.TenPlus; }
            if (answer == "FiveMinus") { Plan = PhonePlan.FiveMinus; }
            if (answer != "Standart" &&  answer != "TenPlus" && answer != "FiveMinus") { Console.WriteLine("Выбранного тарифа не существует!"); }
        }

        public override string ToString()
        {
            return string.Format("Клиент: {0} с тарифным планом: {1} имеет баланс: {2}", Name, Plan, Balance);
        }

        public void RecordPayment(double amountPaid)
        {
            if (amountPaid > 0)
                Balance += amountPaid;
        }

        public void RecordCall(char callType, int minutes) //Метод производит расчёт учитывая тарифный план
        {
            switch ((PhonePlan)Plan)
            {
                case PhonePlan.Standart:
                    {
                        if (callType == 'Г')
                            Balance -= minutes * 5;
                        else
                            if (callType == 'М')
                            Balance -= minutes * 1;
                        break;
                    }
                case PhonePlan.TenPlus:
                    {
                        if (callType == 'Г')
                        {
                            if (minutes > 10) { Balance -= (50 + ((minutes - 10) / 2) * 5); }
                            else { Balance -= minutes * 5; }
                        }
                        else
                        {
                            if (callType == 'М')
                                Balance -= minutes * 1;
                        }
                        break;
                    }
                case PhonePlan.FiveMinus:
                    {
                        if (callType == 'Г')
                        {
                            if (minutes > 5) { Balance -= (minutes * 5) * 2; }
                            else { Balance -= (minutes * 5) / 2; }
                        }
                        else
                        {
                            if (callType == 'М')
                            {
                                if (minutes > 5) { Balance -= (minutes * 1) * 2; }
                                else { Balance -= (minutes * 1) / 2; }
                            }
                        }
                        break;
                    }
            }
        }
    }

    class Customer1
    {
        static void Main(string[] args)
        {
            Customer Ivan = new Customer("Иван Петров", 500, PhonePlan.TenPlus);
            Customer Elena = new Customer("Елена Иванова");
            Elena.ChangePlan();
            Ivan.RecordCall('Г', 12);
            Elena.RecordCall('М', 25);

            Console.WriteLine(Ivan);
            Console.WriteLine(Elena);

        }
    }
}