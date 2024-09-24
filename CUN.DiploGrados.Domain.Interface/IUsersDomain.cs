using CUN.DiploGrados.Domain.Entity;

namespace CUN.DiploGrados.Domain.Interface
{
    public interface IUsersDomain
    {
        Users Authenticate(string username, string password);
    }
}
