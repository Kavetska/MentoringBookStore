namespace AmazonCosplay.Model
{
    using System.Collections.Generic;
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int? ParentGenreId { get; set; }
        public Genre ParentGenre { get; set; }

        public List<BookGenre> BookGenres { get; set; }
        public Genre()
        {
            BookGenres = new List<BookGenre>();
        }
    }
}
