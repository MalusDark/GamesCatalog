namespace BlazorApp.Models
{
    public class AuthorEntity
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<LessonEntity> Lessons { get; set; } = new List<LessonEntity>();
    }
}
