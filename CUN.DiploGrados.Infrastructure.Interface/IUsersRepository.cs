using CUN.DiploGrados.Domain.Entity;

namespace CUN.DiploGrados.Infrastructure.Interface
{
    public interface IUsersRepository : IGenericRepository<Users>
    {
        Users Authenticate(string username, string password);
    }
}
