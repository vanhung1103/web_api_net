using System.ComponentModel.DataAnnotations;

namespace hungpvph28127.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        [Range(0, 100)]
        public int Quantity { get; set; }
    }
}

