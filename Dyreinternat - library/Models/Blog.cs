namespace dyreinternat___library.Models
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public Blog(int blogID, string title, string description, string author)
        {
            BlogID = blogID;
            Title = title;
            Description = description;
            Author = author;
        }
        public Blog() 
        {

        }
    }
}
