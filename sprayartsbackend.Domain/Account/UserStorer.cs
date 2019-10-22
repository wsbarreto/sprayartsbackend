using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sprayartsbackend.Domain.Account
{
    public class UserStorer
    {
        private readonly IRepository<User> _userRepository;

        public UserStorer(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public void Store(Guid id, string userName, string email, string password)
        {
            var user = _userRepository.GetById(id);

            if (user == null)
            {
                user = new User(userName, email, password);
                _userRepository.Save(user);
            }
            else
            {
                user.Update(userName, email, password);
            }
        }


        public List<User> GetUsers()
        {
            // quando houver a tabela de usuário é utilizar esse método
            // para retornar todos os usuários
            //_userRepository.All();

            //var users = new List<User>();
            //users.Add(new User("Douglas","douglas@teste.com","a1b2c3"));
            //users.Add(new User("Rafael","rafael@teste.com","a1b2c3"));
            //users.Add(new User("Wil","wil@teste.com","a1b2c3"));
            //users.Add(new User("Silas","silas@teste.com","a1b2c3"));

            var users = this.GetList();

            return users;
        }

        public User GetUser(Func<User, bool> predicate)
        {
            var users = this.GetList();

            var user = users.Where(predicate).FirstOrDefault();

            return user;

        }

        private List<User> GetList()
        {
            // quando houver a tabela de usuário é utilizar esse método
            // para retornar todos os usuários
            //_userRepository.All();

            var users = new List<User>();
            users.Add(new User("Douglas", "douglas@teste.com", "a1b2c3"));
            users.Add(new User("Rafael", "rafael@teste.com", "a1b2c3"));
            users.Add(new User("Wil", "wil@teste.com", "a1b2c3"));
            users.Add(new User("Silas", "silas@teste.com", "a1b2c3"));

            return users;
        }

    }
}
