using System.Globalization;
using System.Text;

namespace TaxPayment.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.00;
            if (AnualIncome < 20000.00)
            {
                if (HealthExpenditures != 0.00)
                {
                    tax = (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
                }
                else
                {
                    tax = AnualIncome * 0.15;
                }
            }
            else if (AnualIncome > 20000.00)
            {
                if (HealthExpenditures != 0.00)
                {
                    tax = (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
                }
                else
                {
                    tax = AnualIncome * 0.25;
                }
            }

            return tax;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name + ": $" + Tax().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
