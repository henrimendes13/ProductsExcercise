
namespace ProductsExcercise.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
        {
            base.Name = name;
            base.Price = price;
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (Used) $" + Price.ToString() + $" (Manufacture Date: {ManufactureDate.ToString()})";
        }
    }
        
}
