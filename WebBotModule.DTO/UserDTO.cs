using System;
using System.Collections.Generic;
using System.Text;

namespace WebBotModule.DTO
{
    /// <summary>
    /// Data Transfer Object o entity User
    /// This entity registry the users
    /// </summary>
    public class UserDTO
    {       
        public Int64 idUser { get; set; }
        public Int64 idTelegramUser { get; set; }
        
        public String vcharFirstName { get; set; }
        public String vcharLastName { get; set; }
        public String vcharUser { get; set; }

        public virtual ICollection<GroupUserDTO> GroupUsers { get; set; }
        public BotDTO Bot { get; set; }

    }
}
