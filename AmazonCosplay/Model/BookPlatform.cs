namespace AmazonCosplay.Model
{
    public class BookPlatform
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
}
