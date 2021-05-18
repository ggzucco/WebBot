using System;
using System.Collections.Generic;
using System.Text;

namespace WebBotModule.DTO
{
    /// <summary>
    /// Data Transfer Object o entity GroupUSer
    /// This entity registry the relational table between Users and Groups
    /// </summary>
    public class GroupUserDTO
    {
        public Boolean boolActive { get; set; }
        public Boolean boolBanned { get; set; }
        public Boolean boolMutted { get; set; }
        public Boolean boolIsAdmin { get; set; }

        public DateTime dateEntryDate { get; set; }
        public DateTime dateLastUpdate { get; set; }

        public Int64 idUserGroup { get; set; }        
        public Int64 numIdUser { get; set; }        
        public Int64 numIdGroup { get; set; }
                
        public virtual ICollection<CaptchaDTO> Captchas { get; set; }
        public UserDTO User { get; set; }
        public GroupDTO Group { get; set; }
    }
}
