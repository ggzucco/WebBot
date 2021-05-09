using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.BLL
{
    class BotBLL : IBotDBI
    {
        public void Add(BotDTO Bot)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<BotDTO> Bots)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BotDTO> Find(Expression<Func<BotDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public BotDTO FirstOrDefault(Expression<Func<BotDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public BotDTO Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BotDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(BotDTO Bot)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<BotDTO> Bots)
        {
            throw new NotImplementedException();
        }
    }
}
