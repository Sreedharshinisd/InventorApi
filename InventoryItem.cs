using System.ComponentModel.DataAnnotations;

namespace InventoryApi.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string SKU { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be non-negative.")]
        public int QuantityInStock { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Reorder level must be non-negative.")]
        public int ReorderLevel { get; set; }

        [Range(0.0, double.MaxValue, ErrorMessage = "Unit price must be non-negative.")]
        public decimal UnitPrice { get; set; }
    }
}