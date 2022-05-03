using BusinessLogic.Interfaces;
using DataAccess.Repositories;

namespace DataAccess
{
    public class RepositoryManager : IRepositoryManager
    {
        private MoviesContext _repositoryContext;
        private IUsersRepository usersRepository;
        private IMoviesRepository moviesRepository;

        public RepositoryManager(MoviesContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IUsersRepository Users => usersRepository != null ? usersRepository : new UsersRepository(_repositoryContext);
        public IMoviesRepository Movies => moviesRepository != null ? moviesRepository : new MoviesRepository(_repositoryContext);
        public void Save() => _repositoryContext.SaveChanges();
    }
}
