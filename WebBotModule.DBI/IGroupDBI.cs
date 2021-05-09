using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebBotModule.DTO;

namespace WebBotModule.DBI
{
    public interface IGroupDBI : IRepositoryDBI<GroupDTO>
    {
        new GroupDTO Get(Int64 id);
        new GroupDTO FirstOrDefault(Expression<Func<GroupDTO, bool>> predicate);

        new IEnumerable<GroupDTO> GetAll();
        new IEnumerable<GroupDTO> Find(Expression<Func<GroupDTO, bool>> predicate);

        new void Add(GroupDTO Group);
        new void AddRange(IEnumerable<GroupDTO> Groups);

        new void Remove(GroupDTO Group);
        new void RemoveRange(IEnumerable<GroupDTO> Groups);
    }
}
