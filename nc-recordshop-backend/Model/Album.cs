namespace nc_recordshop_backend.Model
{
    // public enum Genre { }

    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public string Artist { get; set; } = "";
        // string or enum
        public string Genre { get; set; } = "";
        // string or DateTime
        public DateTime ReleaseDate { get; set; }
    }
}
