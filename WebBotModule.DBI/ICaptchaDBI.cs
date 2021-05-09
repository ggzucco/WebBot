using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebBotModule.DTO;

namespace WebBotModule.DBI
{
    public interface ICaptchaDBI : IRepositoryDBI<CaptchaDTO>
    {
        new CaptchaDTO Get(Int64 id);
        new CaptchaDTO FirstOrDefault(Expression<Func<CaptchaDTO, bool>> predicate);

        new IEnumerable<CaptchaDTO> GetAll();
        new IEnumerable<CaptchaDTO> Find(Expression<Func<CaptchaDTO, bool>> predicate);

        new void Add(CaptchaDTO Captcha);
        new void AddRange(IEnumerable<CaptchaDTO> Captchas);

        new void Remove(CaptchaDTO Captcha);
        new void RemoveRange(IEnumerable<CaptchaDTO> Captchas);
    }
}
