using System.Linq;
using RepositoryPatternWithNinjectDependency.core.Data;

namespace RepositoryPatternWithNinjectDependency.Service
{
    public interface IUserService
    {
        IQueryable<User> GetUsers();
        User GetUser(long id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
