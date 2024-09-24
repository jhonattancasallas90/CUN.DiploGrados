using CUN.DiploGrados.Domain.Entity;
using CUN.DiploGrados.Domain.Interface;
using CUN.DiploGrados.Infrastructure.Interface;

namespace CUN.DiploGrados.Domain.Core
{
    public class UsersDomain : IUsersDomain
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsersDomain(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Users Authenticate(string userName, string password)
        {
            return _unitOfWork.Users.Authenticate(userName, password);
        }
    }
}
