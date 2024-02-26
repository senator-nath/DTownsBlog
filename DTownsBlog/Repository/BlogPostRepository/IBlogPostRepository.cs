using DTownsBlog.Model;

namespace DTownsBlog.Repository.BlogPostRepository
{
    public interface IBlogPostRepository
    {
        BlogPost GetPostById(int id);
        List<BlogPost> GetAllPosts();
        bool CreatePost(BlogPost post);
        bool UpdatePost(BlogPost post);
        bool DeletePost(BlogPost post);
        public bool Save();
    }
}
