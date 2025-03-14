using System.ComponentModel.DataAnnotations;

namespace Grossery
{
    public class Product
    {
        public Product()
        {
        }

        public Product(string name, string image, float price, string barcode, int type)
        {
            Name = name;
            Image = image;
            Price = price;
            Parcode = barcode;
            Type = type;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public string Parcode { get; set; }
        public int Type { get; set; }

      
    }
}
