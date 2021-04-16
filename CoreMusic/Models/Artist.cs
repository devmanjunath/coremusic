using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMusic.Models
{
    public class Artist
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ArtistID { get; set; }
        public string Name { get; set; }
        public int Genre { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}