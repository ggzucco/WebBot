using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebBotModule.DTO;

namespace WebBotModule.DBI
{
    public interface ILanguageDBI : IRepositoryDBI<LanguageDTO>
    {
        new LanguageDTO Get(Int64 id);
        new LanguageDTO FirstOrDefault(Expression<Func<LanguageDTO, bool>> predicate);

        new IEnumerable<LanguageDTO> GetAll();
        new IEnumerable<LanguageDTO> Find(Expression<Func<LanguageDTO, bool>> predicate);

        new void Add(LanguageDTO Language);
        new void AddRange(IEnumerable<LanguageDTO> Languages);

        new void Remove(LanguageDTO Language);
        new void RemoveRange(IEnumerable<LanguageDTO> Languages);
    }
}
