using DTownsBlog.Model;

namespace DTownsBlog.Repository.CommentRepository
{
    public interface ICommentRepository
    {
        Comment GetCommentById(int id);
        public List<Comment> GetAllComments();
        bool CreateComment(Comment comment);
        bool UpdateComment(Comment comment);
        bool DeleteComment(Comment comment);
        bool Save();
    }
}
