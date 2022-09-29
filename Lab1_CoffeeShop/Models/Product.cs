using Dapper.Contrib.Extensions;

namespace Lab1_CoffeeShop.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }

        public override string ToString()
        {
            return $"{name} - {description} ({price}";
        }
    }
}
