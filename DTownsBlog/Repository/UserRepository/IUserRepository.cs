using DTownsBlog.Model;

namespace DTownsBlog.Repository.UserRepository
{
    public interface IUserRepository
    {
        bool isUniqueUser(string username, string Email);
        User Authenticate(string username, string password, string email);
        void Register(User registerDto);
        public int Save();
    }
}
