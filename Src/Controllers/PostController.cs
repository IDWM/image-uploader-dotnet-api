using image_uploader_dotnet_api.Src.Data;
using image_uploader_dotnet_api.Src.DTOs;
using image_uploader_dotnet_api.Src.Interfaces;
using image_uploader_dotnet_api.Src.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace image_uploader_dotnet_api.Src.Controllers;

public class PostController : BaseApiController
{
    private readonly DataContext _dataContext;
    private readonly IPhotoService _photoService;

    public PostController(DataContext dataContext, IPhotoService photoService)
    {
        _dataContext = dataContext;
        _photoService = photoService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Post>>> GetPosts()
    {
        return await _dataContext.Posts.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult> CreatePost(CreatePostDto createPostDto)
    {
        var result = await _photoService.AddPhotoAsync(createPostDto.Image);

        if (result.Error != null)
        {
            return BadRequest(result.Error.Message);
        };

        var post = new Post
        {
            Title = createPostDto.Title,
            Description = createPostDto.Description,
            Url = result.SecureUrl.AbsoluteUri,
            PublicId = result.PublicId,
        };

        await _dataContext.Posts.AddAsync(post);
        await _dataContext.SaveChangesAsync();

        return Ok();
    }
}