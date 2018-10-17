namespace Linq
{
    public class Film
    {
        public string Name { get; set; }
        public int ReleaseYear {get; set; }
        public string Director { get; set; }

        public Film(string name, int releaseYear, string director)
        {
            Name = name;
            ReleaseYear = releaseYear;
            Director = director;
        }
    }
}