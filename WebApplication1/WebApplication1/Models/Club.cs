﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PlayerFootball> playerFootballs { get;}
    }
}
