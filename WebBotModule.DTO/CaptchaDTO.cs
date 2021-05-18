using System;
using System.Collections.Generic;
using System.Text;

namespace WebBotModule.DTO
{
    /// <summary>
    /// Data Transfer Object o entity Captcha
    /// This entity resistry the Captchas generated
    /// </summary>
    public class CaptchaDTO
    {
        public DateTime dateGeneration { get; set; }

        public Int64 idCaptcha { get; set; }
        public Int64 numIdUserGroup { get; set; }
        public Int64 numAction { get; set; }
        
        public String vcharCaptchaValue { get; set; }
        
        public GroupUserDTO GroupUser { get; set; }
    }
}
