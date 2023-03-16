using System.Globalization;

namespace Curso.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public double SubTotal()
        {
            return this.Quantity * this.Price;
        }
        public override string ToString()
        {
            return Product.Name
            + ", $"
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", Quantity: "
            + Quantity
            + ", Subtotal: $"
            + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
