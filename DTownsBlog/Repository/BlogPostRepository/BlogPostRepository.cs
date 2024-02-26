using DTownsBlog.Data;
using DTownsBlog.Model;

namespace DTownsBlog.Repository.BlogPostRepository
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ApplicationDbContext _Db;

        public BlogPostRepository(ApplicationDbContext Db)
        {
            _Db = Db;
        }
        public bool CreatePost(BlogPost blogPost)
        {
            _Db.BlogPosts.Add(blogPost);
            return Save();
        }

        public bool DeletePost(BlogPost post)
        {
            _Db.BlogPosts.Remove(post);
            return Save();
        }

        public List<BlogPost> GetAllPosts()
        {
            return _Db.BlogPosts.ToList();
        }

        public BlogPost GetPostById(int BlogPostid)
        {
            return _Db.BlogPosts.FirstOrDefault(p => p.Id == BlogPostid);
        }

        public bool Save()
        {
            return _Db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdatePost(BlogPost post)
        {
            _Db.BlogPosts.Update(post);
            return Save();
        }
    }
}

