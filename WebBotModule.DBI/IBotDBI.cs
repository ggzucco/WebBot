using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebBotModule.DTO;

namespace WebBotModule.DBI
{
    public interface IBotDBI :IRepositoryDBI<BotDTO>
    {
        new BotDTO Get(Int64 id);
        new BotDTO FirstOrDefault(Expression<Func<BotDTO, bool>> predicate);

        new IEnumerable<BotDTO> GetAll();
        new IEnumerable<BotDTO> Find(Expression<Func<BotDTO, bool>> predicate);

        new void Add(BotDTO Bot);
        new void AddRange(IEnumerable<BotDTO> Bots);

        new void Remove(BotDTO Bot);
        new void RemoveRange(IEnumerable<BotDTO> Bots);
    }
}
