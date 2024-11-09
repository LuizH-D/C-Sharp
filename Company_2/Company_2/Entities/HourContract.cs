

namespace Company_2.Entities
{
    internal class HourContract
    {
        public DateTime Date {  get;  set; }
        public double ValuePerHour { get;  set; }
        public int Hours { get; private set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
