using System;

namespace CUN.DiploGrados.Infrastructure.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentsRepository Students { get; }
        IUsersRepository Users { get; }
    }
}
