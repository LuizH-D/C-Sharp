using System.Globalization;
using System.Text;

namespace TaxPayment.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = 0.00;
            if (NumberOfEmployees > 10)
            {
                tax = AnualIncome * 0.14;
            }
            else
            {
                tax = AnualIncome * 0.16;
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
