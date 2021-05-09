using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebBotModule.DTO;

namespace WebBotModule.DBI
{
    public interface IGroupUserDBI : IRepositoryDBI<GroupUserDTO>
    {
        new GroupUserDTO Get(Int64 id);
        new GroupUserDTO FirstOrDefault(Expression<Func<GroupUserDTO, bool>> predicate);

        new IEnumerable<GroupUserDTO> GetAll();
        new IEnumerable<GroupUserDTO> Find(Expression<Func<GroupUserDTO, bool>> predicate);

        new void Add(GroupUserDTO GroupUser);
        new void AddRange(IEnumerable<GroupUserDTO> GroupUsers);

        new void Remove(GroupUserDTO GroupUser);
        new void RemoveRange(IEnumerable<GroupUserDTO> GroupUsers);
    }
}
