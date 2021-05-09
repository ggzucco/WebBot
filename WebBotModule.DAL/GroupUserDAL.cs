using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.BLL
{
    class GroupUserDAL : IGroupUserDBI
    {
        public void Add(GroupUserDTO GroupUser)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<GroupUserDTO> GroupUsers)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GroupUserDTO> Find(Expression<Func<GroupUserDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public GroupUserDTO FirstOrDefault(Expression<Func<GroupUserDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public GroupUserDTO Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GroupUserDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(GroupUserDTO GroupUser)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<GroupUserDTO> GroupUsers)
        {
            throw new NotImplementedException();
        }
    }
}
