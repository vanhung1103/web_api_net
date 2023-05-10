using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PlayerFootball> Footballs { get; set;}
    }
}
