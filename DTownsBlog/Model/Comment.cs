namespace DTownsBlog.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public string UserId1 { get; set; }
        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }
    }
}
