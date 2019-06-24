namespace AmazonCosplay.Model
{
    using System.Collections.Generic;
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PublishYear { get; set; }
        public double Price { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public List<BookGenre> BookGenres { get; set; }
        public List<BookPlatform> BookPlatforms { get; set; }
        public Book()
        {
            BookGenres = new List<BookGenre>();
            BookPlatforms = new List<BookPlatform>();
        }

        //TODO MANY PLATFORMS
        public List<Comment> Comments { get; set; }

    }
}
