using System.Text;
using System.Globalization;

namespace PaymentProject.Entities {
    internal class Installment {
        public DateTime DueDate { get; private set; }
        public double Amount { get; private set; }

        public Installment(DateTime duedate, double amount) {
            DueDate = duedate;
            Amount = amount;
        }

        public override string ToString() { 
            StringBuilder sb = new StringBuilder();
            sb.Append(DueDate.ToString("dd/MM/yyyy") + " - " + Amount.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
