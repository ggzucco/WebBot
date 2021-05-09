using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.BLL
{
    class CaptchaBLL : ICaptchaDBI
    {
        public void Add(CaptchaDTO Captcha)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<CaptchaDTO> Captchas)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CaptchaDTO> Find(Expression<Func<CaptchaDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public CaptchaDTO FirstOrDefault(Expression<Func<CaptchaDTO, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public CaptchaDTO Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CaptchaDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(CaptchaDTO Captcha)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<CaptchaDTO> Captchas)
        {
            throw new NotImplementedException();
        }
    }
}
