using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebBotModule.DTO;

namespace WebBotModule.DBI
{
    public interface IMessageDBI : IRepositoryDBI<MessageDTO>
    {
        new MessageDTO Get(Int64 id);
        new MessageDTO FirstOrDefault(Expression<Func<MessageDTO, bool>> predicate);

        new IEnumerable<MessageDTO> GetAll();
        new IEnumerable<MessageDTO> Find(Expression<Func<MessageDTO, bool>> predicate);

        new void Add(MessageDTO Message);
        new void AddRange(IEnumerable<MessageDTO> Messages);

        new void Remove(MessageDTO Message);
        new void RemoveRange(IEnumerable<MessageDTO> Messages);
    }
}
