using System.Globalization;
using System.Text;


namespace Products.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) 
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) ${Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(PriceTag());
            return sb.ToString();
        }
    }
}
