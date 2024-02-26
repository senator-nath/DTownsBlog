namespace DTownsBlog.Model.Dto.CommentDto
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public string UserId { get; set; }
        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
        public string Message { get; set; }
    }
}
