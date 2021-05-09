using System;
using System.Collections.Generic;
using System.Text;

namespace WebBotModule.DTO
{
    /// <summary>
    /// Data Transfer Object o entity Message
    /// This entity registry the custom messages of the bot
    /// </summary>
    public class MessageDTO
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 idMessage { get; set; }
        //[ForeignKey("Languages")]
        public Int64 numIdLanguage { get; set; }
        public Int64 numType { get; set; }
        public String vcharMessageText { get; set; }        
        //public LanguageModel Language { get; set; }
    }
}
