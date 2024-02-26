namespace DTownsBlog.Model.Dto.CommentDto
{
    public class CreateCommentDto
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public string UserId { get; set; }
        public int BlogPostId { get; set; }
        
        public string Message { get; set; }
    }
}
