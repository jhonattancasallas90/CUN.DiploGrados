using CUN.DiploGrados.Infrastructure.Interface;

namespace CUN.DiploGrados.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IStudentsRepository Students { get; }

        public IUsersRepository Users { get; }

        public UnitOfWork(IStudentsRepository students, IUsersRepository users)
        {
            Students = students;
            Users = users;
        }
        public void Dispose()
        {
            System.GC.SuppressFinalize(this);
        }
    }
}
