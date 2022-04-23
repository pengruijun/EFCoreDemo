namespace EFCoreDemo.Dtos;

public class BlogDto
{
    public int ID { get; set; }
    public string Name { get; set; }= null!;
    public ICollection<PostDto> Posts { get; set; }= null!;
}

public class PostDto
{
    public int ID { get; set; } 
    public string Title { get; set; }= null!;
}