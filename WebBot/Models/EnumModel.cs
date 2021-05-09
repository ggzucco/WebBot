using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBot.Models
{
    public class EnumModel
    {
        public enum EnCaptchaAction
        {
            Unsolved = 1,
            Solved = 2,
            NewRequest = 3,
        }
        public enum enTypeMessage
        {
            Welcome = 1,
            Rule = 2,
            Filter = 3
        }
        public enum enLanguage
        {
            Burmese = 1,
            Chinese = 2,
            English = 3,
            French = 4,
            German = 5,
            Italian = 6,
            Japanese = 7,
            Korean = 8,
            Malay = 9,
            Portuguese = 10,
            Russian = 11,
            Spanish = 12,
            Thai = 13,
            Vietnamese = 14,
        }
    }
}
