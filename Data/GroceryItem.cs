using System.ComponentModel.DataAnnotations;

namespace ShoppingList.Data
{
    public class GroceryItem
    {
        [Required]
        [StringLength(20, ErrorMessage = "Name must contain less than 20 characters.")]
        [MinLength(2, ErrorMessage = "Name must contain at least 2 characters.")]
        public string Name { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Valid price range is (1-1000)")]
        public decimal Price { get; set; }
    }
}
