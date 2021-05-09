using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.BLL
{
    class GroupDAL : IGroupDBI
    {
        public void Add(GroupDTO Group)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<GroupDTO> Groups)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GroupDTO> Find(Expression<Func<GroupDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public GroupDTO FirstOrDefault(Expression<Func<GroupDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public GroupDTO Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GroupDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(GroupDTO Group)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<GroupDTO> Groups)
        {
            throw new NotImplementedException();
        }
    }
}
