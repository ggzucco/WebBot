using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.BLL
{
    class CommandDAL : ICommandDBI
    {
        public void Add(CommandDTO Command)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<CommandDTO> Commands)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommandDTO> Find(Expression<Func<CommandDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public CommandDTO FirstOrDefault(Expression<Func<CommandDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public CommandDTO Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommandDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(CommandDTO Command)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<CommandDTO> Commands)
        {
            throw new NotImplementedException();
        }
    }
}
