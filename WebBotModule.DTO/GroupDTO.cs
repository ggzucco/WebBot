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
        public Boolean boolActive { get; set; }

        public Int64 idGroup { get; set; }        
        public Int64 idTelegramGroup { get; set; }        
        public Int64 numIdLanguage { get; set; }

        public String vcharCountryName { get; set; }
        public String vcharGroupName { get; set; }
        public String vcharGroupAdress { get; set; }

        public virtual ICollection<GroupUserDTO> GroupUsers { get; set; }
        public LanguageDTO Language { get; set; }
    }
}
