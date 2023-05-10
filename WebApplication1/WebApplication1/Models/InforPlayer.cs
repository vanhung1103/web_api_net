using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class InforPlayer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
    
        public int Numeber { get; set; }

        public PlayerFootball PlayerFootball { get; set; }
    }
}
