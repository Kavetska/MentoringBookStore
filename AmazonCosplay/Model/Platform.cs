namespace AmazonCosplay.Model
{
    using System.Collections.Generic;
    public class Platform
    {
        //todo enum
        //map enum to column
        public int Id { get; set; }
        public string Name { get; set; }

        public List<BookPlatform> BookPlatforms { get; set; }
        public Platform()
        {
            BookPlatforms = new List<BookPlatform>();
        }
    }
}
