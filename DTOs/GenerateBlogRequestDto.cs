namespace P10_Blog_Generator_AI_Frontend.DTOs
{
    public class GenerateBlogRequestDto
    {
        public string Topic { get; set; }
        public string Category { get; set; }
        public string Audience { get; set; }
        public string Tone { get; set; }
        public string WordCount { get; set; }
    }
}