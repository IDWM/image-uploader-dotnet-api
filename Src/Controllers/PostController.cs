using image_uploader_dotnet_api.Src.Data;
using image_uploader_dotnet_api.Src.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace image_uploader_dotnet_api.Src.Controllers;

public class PostController : BaseApiController
{
    private readonly DataContext _dataContext;

    public PostController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    [HttpGet]
    public async Task<ActionResult<List<Post>>> GetPosts()
    {
        return await _dataContext.Posts.ToListAsync();
    }
}