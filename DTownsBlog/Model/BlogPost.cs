using System.ComponentModel.DataAnnotations;

namespace DTownsBlog.Model
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int UserId { get; set; }

        public int CategoryId { get; set; }
        public List<Comment> Comment { get; set; }
    }
}
