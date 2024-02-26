namespace DTownsBlog.Model.Dto.BlogPostDto
{
    public class BlogPostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int UserId { get; set; }

        public int CategoryId { get; set; }

        public string Message { get; set; }
    }
}
