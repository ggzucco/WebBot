using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.BLL
{
    class UserDAL : IUserDBI
    {
        public void Add(UserDTO User)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<UserDTO> Users)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> Find(Expression<Func<UserDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public UserDTO FirstOrDefault(Expression<Func<UserDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public UserDTO Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(UserDTO User)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<UserDTO> Users)
        {
            throw new NotImplementedException();
        }
    }
}
