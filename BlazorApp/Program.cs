using BlazorApp.Components;
using BlazorApp.Components.Data;
using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddHttpClient();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
using (var context = new LearningDbContext())
{
    var john = new AuthorEntity { UserName = "John T. Author", Email = "john@example.com" };
    context.Authors.Add(john);

    var jane = new AuthorEntity { UserName = "Jane Q. Hacker", Email = "jane@example.com" };
    context.Authors.Add(jane);

    var post = new LessonEntity { Title = "Hello World", LessonText = "I wrote an app using EF Core!", Author = jane };
    context.Lessons.Add(post);
    post = new LessonEntity { Title = "How to use EF Core", LessonText = "It's pretty easy", Author = john };
    context.Lessons.Add(post);

    context.SaveChanges();
}

using (var context = new LearningDbContext())
{
    var posts = context.Lessons
        .Include(p => p.Author)
        .ToList();

    foreach (var post in posts)
    {
        Console.WriteLine($"{post.Title} by {post.Author.UserName}");
        Console.WriteLine(post.LessonText); 
    }
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
