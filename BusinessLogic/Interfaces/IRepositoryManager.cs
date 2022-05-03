namespace BusinessLogic.Interfaces
{
    public interface IRepositoryManager
    {
        IUsersRepository Users { get; }
        IMoviesRepository Movies { get; }
        void Save();
    }

}
