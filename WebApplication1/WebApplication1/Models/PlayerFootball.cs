using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PlayerFootball
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public ICollection<Position> Positions { get; set; }

    }
}
