using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebBotModule.DTO;

namespace WebBotModule.DBI
{
    public interface ICommandDBI : IRepositoryDBI<CommandDTO>
    {
        new CommandDTO Get(Int64 id);
        new CommandDTO FirstOrDefault(Expression<Func<CommandDTO, bool>> predicate);

        new IEnumerable<CommandDTO> GetAll();
        new IEnumerable<CommandDTO> Find(Expression<Func<CommandDTO, bool>> predicate);

        new void Add(CommandDTO Command);
        new void AddRange(IEnumerable<CommandDTO> Commands);

        new void Remove(CommandDTO Command);
        new void RemoveRange(IEnumerable<CommandDTO> Commands);
    }
}
