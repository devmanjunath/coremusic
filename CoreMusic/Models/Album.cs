namespace CoreMusic.Models
{
    public class Album
    {
        public int ID { get; set; }
        public int ArtistID { get; set; }
        public int SongID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }

        public Artist Artists { get; set; }
        public Song Songs { get; set; }
    }
}