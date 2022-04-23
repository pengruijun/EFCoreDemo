namespace EFCoreDemo.Models
{
    public class Post
    {
        public int ID { get; set; } 
        public string Title { get; set; }= null!;
        public int BlogId { get; set; }
        public Blog Blog { get; set; } = null!;
    }
}
