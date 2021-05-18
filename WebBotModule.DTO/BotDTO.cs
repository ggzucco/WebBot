using System;
using System.Collections.Generic;
using System.Text;

namespace WebBotModule.DTO
{
    /// <summary>
    /// Data Transfer Object o entity BOT
    /// This entity only goes to the Bot that controls that system
    /// </summary>
    public class BotDTO
    {        
        public Int64 idBot { get; set; }        
        public Int64 numIdUser { get; set; }

        public String vcharToken { get; set; }
       
        public ICollection<CommandDTO> Commands { get; set; }
        public UserDTO User { get; set; }
    }
}
