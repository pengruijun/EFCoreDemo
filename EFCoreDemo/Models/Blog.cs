namespace EFCoreDemo.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Name { get; set; }= null!;
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
