using System.ComponentModel.DataAnnotations;

namespace FoodHUB.Models
{
    public class FoodItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        /// <summary>Category slug: starters, mains, pasta, grill, desserts, drinks</summary>
        public string Category { get; set; }

        /// <summary>CSS class used to apply a background image to the card</summary>
        public string ImageClass { get; set; }

        public bool IsPopular { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsSpicy { get; set; }
    }
}
