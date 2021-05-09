using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.BLL
{
    class MessageDAL : IMessageDBI
    {
        public void Add(MessageDTO Message)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<MessageDTO> Messages)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MessageDTO> Find(Expression<Func<MessageDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public MessageDTO FirstOrDefault(Expression<Func<MessageDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public MessageDTO Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MessageDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(MessageDTO Message)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<MessageDTO> Messages)
        {
            throw new NotImplementedException();
        }
    }
}
