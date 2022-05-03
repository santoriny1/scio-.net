using BusinessLogic.Extensions;
using BusinessLogic.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Services
{
    public class UsersService
    {
        private readonly IRepositoryManager _repositoryManager;

        public UsersService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public List<User> GetUsers()
        {
            return _repositoryManager.Users.GetAll().Select(x => new User()
            {
                Email = x.Email,
                Name = x.Name,
                UserId = x.UserId
            }).ToList();

        }

        public User CreateUser(UserSession user)
        {
            List<User> users = GetUsers();

            int cont = 0;

            foreach (User u in users)
            {
                if(u.Email == user.Email)
                {
                    cont++;
                    break;
                }
                    
            }

            //Valida que no exista otro usuario con el mismo Email a trvés de un contador
            if (cont == 0)
            {

                var domainUser = new DomainModels.User()
                {
                    Email = user.Email,
                    Name = user.Name,
                    Password = user.Password
                };

                var dbUser = _repositoryManager.Users.Add(domainUser);
                _repositoryManager.Save();
               
                return dbUser.ToDTO();

            } else
            {
                return null;
            }
            

        }

        public User Login(UserLogin login)
        {
            return null;
        }

    }
}
