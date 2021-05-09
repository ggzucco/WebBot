using System;
using System.Collections.Generic;
using System.Text;

namespace WebBotModule.DTO
{
    /// <summary>
    /// Data Transfer Object o entity Group
    /// This entity registry the groups of Bot's domains
    /// </summary>
    public class GroupDTO
    {
        //[Key]
        //[Column(Order = 1)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 idGroup { get; set; }
        //[Key]
        //[Column(Order = 1)]
        public Int64 idTelegramGroup { get; set; }
        //[ForeignKey("Languages")]
        public Int64 numIdLanguage { get; set; }
        public String vcharCountryName { get; set; }
        public String vcharGroupName { get; set; }
        public String vcharGroupAdress { get; set; }
        public Boolean boolActive { get; set; }
        //public LanguageModel Language { get; set; }
    }
}
