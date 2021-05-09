using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.BLL
{
    class LanguageBLL : ILanguageDBI
    {
        public void Add(LanguageDTO Language)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<LanguageDTO> Languages)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LanguageDTO> Find(Expression<Func<LanguageDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public LanguageDTO FirstOrDefault(Expression<Func<LanguageDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public LanguageDTO Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LanguageDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(LanguageDTO Language)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<LanguageDTO> Languages)
        {
            throw new NotImplementedException();
        }
    }
}
