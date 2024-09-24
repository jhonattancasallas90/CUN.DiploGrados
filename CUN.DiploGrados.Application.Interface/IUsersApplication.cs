using CUN.DiploGrados.Application.DTO;
using CUN.DiploGrados.Transversal.Common;

namespace CUN.DiploGrados.Application.Interface
{
    public interface IUsersApplication
    {
        Response<UsersDto> Authenticate(string username, string password);
    }
}
