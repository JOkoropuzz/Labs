
class Customer
{
        public string Name { get; set; }
        public double Balance { get; private set; }
        public Tariff TariffPlan { get; set; }  

        public Customer(string name, Tariff someTariff, double balance = 100)
        {
            Name = name;
            Balance = balance;
            TariffPlan = someTariff;
        }


        public override string ToString()
        {
            return string.Format("Клиент: {0} с тарифным планом: {1} имеет баланс: {2}", Name, TariffPlan.Name, Balance);
        }



        public void RecordPayment(double amountPaid) //Внесение денег
        {
            if (amountPaid > 0)
                Balance += amountPaid;
        }


        public void ChangeTariff(Tariff someTariff) //Изменение тарифного плана
        {
        TariffPlan = someTariff;
        }


        public void RecordWithdraw(double amountWithdraw) //Cписание денег
        { Balance -= amountWithdraw; }

}
