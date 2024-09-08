namespace BlazorApp.Models
{
    public class LessonEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string LessonText { get; set; } = string.Empty;
        public AuthorEntity Author { get; set; }
    }
}
