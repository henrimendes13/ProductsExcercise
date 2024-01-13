

namespace ProductsExcercise.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() 
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
        {
            base.Name = name;
            this.Price = price;
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name + " $" + TotalPrice().ToString() + $" (Customs Fee: ${CustomsFee.ToString()})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
