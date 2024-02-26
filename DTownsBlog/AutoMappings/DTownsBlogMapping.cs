using DTownsBlog.Model.Dto.BlogPostDto;
using DTownsBlog.Model.Dto.CategoryDto;
using DTownsBlog.Model.Dto.CommentDto;
using DTownsBlog.Model;
using AutoMapper;

namespace DTownsBlog.AutoMappings
{
    public class DTownsBlogMappings : Profile
    {
        public DTownsBlogMappings()
        {
            CreateMap<BlogPost, BlogPostDto>().ReverseMap();
            CreateMap<BlogPost, DeleteBlogPostDto>().ReverseMap();
            CreateMap<BlogPost, CreateBlogPostDto>().ReverseMap();
            CreateMap<BlogPost, UpdateBlogPostDto>().ReverseMap();
            CreateMap<Comment, CommentDto>().ReverseMap();
            CreateMap<Comment, CreateCommentDto>().ReverseMap();
            CreateMap<Comment, UpdateCommentDto>().ReverseMap();
            CreateMap<Comment, DeleteCommentDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, DeleteCategoryDto>().ReverseMap();
        }
    }
}
