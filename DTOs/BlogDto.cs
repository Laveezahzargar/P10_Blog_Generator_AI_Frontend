namespace P10_Blog_Generator_AI_Frontend.DTOs
{
    public class BlogDto
    {
        public int BlogId { get; set; }
        public int BlogRequestId { get; set; }

        public string Title { get; set; }

        public string Topic { get; set; }

        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}