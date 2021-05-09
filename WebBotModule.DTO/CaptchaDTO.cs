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
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 idCaptcha { get; set; }
        //[ForeignKey("UserGroup")]
        public Int64 numIdUseGroup { get; set; }
        public Int64 numAction { get; set; }
        public String vcharCaptchaValue { get; set; }
        public DateTime dateGeneration { get; set; }        
        //public UserGrupDTO UserGroup { get; set; }
    }
}
