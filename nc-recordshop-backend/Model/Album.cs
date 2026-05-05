namespace nc_recordshop_backend.Model
{
    // public enum Genre { }

    public class Album
    {
        public int Id { get; set; }
        public int Quantity { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Artist { get; set; } = "";
        // string or enum
        public string Genre { get; set; } = "";
        // string or DateOnly
        public DateOnly ReleaseDate { get; set; }
        public List<string> TrackList { get; set; } = new();

        /*public Album(string name, string description, string artist, string genre, DateOnly date, List<string> trackList)
        {
            Name = name;
            Description = description;
            Artist = artist;
            Genre = genre;
            ReleaseDate = date;
            TrackList = trackList;
        }*/

    }
}
