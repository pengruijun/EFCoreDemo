using AutoMapper;
using AutoMapper.QueryableExtensions;
using EFCoreDemo.Dtos;
using EFCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly BlogContext _blogContext;
        private readonly IMapper _mapper;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger, 
            BlogContext blogContext,
            IMapper mapper)
        {
            _logger = logger;
            _blogContext = blogContext;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            //_logger.LogInformation("logging test");
            
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("Test")]
        public IActionResult Test()
        {
            var blog = _blogContext.Blogs.First();
            _blogContext.Entry(blog).Collection(b => b.Posts).Load();

            //var blogs = _blogContext.Blogs
            //    .Include(b => b.Posts);
            //return Ok(blogs.ToList());
            return Ok(blog);
        }

        [HttpGet("ProjectTo")]
        public async Task<IActionResult> ProjectTo()
        {
            var blogs = await _blogContext.Blogs
                .ProjectTo<BlogDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return Ok();
        }

        [HttpGet("Select")]
        public async Task<IActionResult> Select()
        {
            var blogs = _blogContext.Blogs;
            var blogFiltered = blogs.Where(b => b.ID > 2);

            foreach (var blog in blogFiltered)
            {
                var result = blog.Name;
            }
            
            //var results = await blogFiltered.ToListAsync();
             //var posts = blogs.Select(b => b.Posts);
             //var result = await posts.ToListAsync();
            
            return Ok();
        }

        [HttpGet("AddPost")]
        public async Task<IActionResult> AddPost()
        {
            var blog = _blogContext.Blogs.First();
            var post = new Post
            {
                Title = "post 1.6"
            };

            post.Blog = blog;
            _blogContext.Add(post);
            await _blogContext.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("AddBlog")]
        public async Task<IActionResult> AddBlog()
        {
            var blog = new Blog()
            {
                Name = "blog 2"
            };
            await _blogContext.AddAsync(blog);
            await _blogContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("AddBlogAndPost")]
        public async Task<IActionResult> AddBlogPost()
        {
            var blog = new Blog() { Name = "blog 5" };
            var post = new Post() { Title = "post 5.1" };

            post.Blog = blog;
            await _blogContext.AddAsync(blog);
            //blog.Posts.Add(post);
            //await _blogContext.AddAsync(blog);
            await _blogContext.SaveChangesAsync();
            return Ok();
        }
    }
}