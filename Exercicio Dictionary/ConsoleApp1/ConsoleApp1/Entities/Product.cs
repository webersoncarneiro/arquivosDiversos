using System.Globalization;

namespace ConsoleApp1.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return "ID: "
                + Id
                + " NAME: "
                + Name
                + " PRICE: "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " Category: "
                + Category.Name
                + Category.Tier;
        }
    }
}
