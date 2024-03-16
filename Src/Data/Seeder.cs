using System.Text.Json;
using image_uploader_dotnet_api.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace image_uploader_dotnet_api.Src.Data;

public class Seeder
{
    public static async Task SeedPosts(DataContext dataContext)
    {
        if (await dataContext.Posts.AnyAsync())
        {
            return;
        }

        var postsData = await File.ReadAllTextAsync("Src/Data/PostsData.json");
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var posts = JsonSerializer.Deserialize<List<Post>>(postsData, options);

        if (posts is null)
        {
            return;
        }

        await dataContext.AddRangeAsync(posts);
        await dataContext.SaveChangesAsync();
    }
}