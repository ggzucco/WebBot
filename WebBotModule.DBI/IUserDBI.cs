using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebBotModule.DTO;

namespace WebBotModule.DBI
{
    public interface IUserDBI : IRepositoryDBI<UserDTO>
    {
        new UserDTO Get(Int64 id);
        new UserDTO FirstOrDefault(Expression<Func<UserDTO, bool>> predicate);

        new IEnumerable<UserDTO> GetAll();
        new IEnumerable<UserDTO> Find(Expression<Func<UserDTO, bool>> predicate);

        new void Add(UserDTO User);
        new void AddRange(IEnumerable<UserDTO> Users);

        new void Remove(UserDTO User);
        new void RemoveRange(IEnumerable<UserDTO> Users);
    }
}
