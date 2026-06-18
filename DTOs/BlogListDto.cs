using System;
using System.Collections.Generic;
using System.Text;

namespace P10_Blog_Generator_AI_Frontend.DTOs
{
    public class BlogListDto
    {
        public int GeneratedBlogId { get; set; }
        public int BlogRequestId { get; set; }

        public string Title { get; set; }

        public string ContentPreview { get; set; }

        public string Category { get; set; }

        public string Audience { get; set; }

        public string Tone { get; set; }

        public DateTime GeneratedAt { get; set; }
    }
}
