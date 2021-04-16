using System;
using System.Collections.Generic;

namespace CoreMusic.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public DateTime ReleasedDate { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}