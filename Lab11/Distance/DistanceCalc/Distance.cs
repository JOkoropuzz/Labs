
namespace DistanceCalc
{
    public class Distance
    {
        public int feet;
        public double inches;


        //Конструкторы
        public Distance()
        {
            this.feet = 0;
            this.inches = 0;
        }

        public Distance(int feet, double inches)
        {
            this.feet = feet;
            this.inches = inches;
        }

        //Операторы

        public static Distance operator +(Distance dist1, Distance dist2)
        {
            Distance totalDist = new Distance();
            double sum = (dist1.feet + dist2.feet) * 12 + dist1.inches + dist2.inches;
            totalDist.inches = sum % 12;
            totalDist.feet = (int)sum/12;
            return totalDist;
        }

        public static Distance operator -(Distance dist1, Distance dist2)
        {
            Distance totalDist = new Distance();
            double sum = (dist1.feet - dist2.feet) * 12 + (dist1.inches - dist2.inches);
            totalDist.inches = sum % 12;
            totalDist.feet = (int)sum / 12;
            return totalDist;
        }

        public static bool operator >=(Distance dist1, Distance dist2)
        {
            double sum = (dist1.feet - dist2.feet) * 12 + (dist1.inches - dist2.inches);
            if (sum >= 0) return true;
            else return false;
        }

        public static bool operator >(Distance dist1, Distance dist2)
        {
            double sum = (dist1.feet - dist2.feet) * 12 + (dist1.inches - dist2.inches);
            if (sum > 0) return true;
            else return false;
        }

        public static bool operator <(Distance dist1, Distance dist2)
        {
            return !(dist1 >= dist2);
        }

        public static bool operator <=(Distance dist1, Distance dist2)
        {
            return !(dist1 > dist2);
        }


        //Методы

        public override string ToString()
        {
            return $"{this.feet}'- {this.inches:F0}\"";
        }
    }
}
