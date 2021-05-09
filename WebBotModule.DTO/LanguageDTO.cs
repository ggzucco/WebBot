using System;
using System.Collections.Generic;
using System.Text;

namespace WebBotModule.DTO
{
    /// <summary>
    /// Data Transfer Object o entity Languages
    /// This entity registry the Languages 
    /// </summary>
    public class LanguageDTO
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 idLanguage { get; set; }
        public String vcharLanguage { get; set; }
        public String vcharAbreveation { get; set; }
        //public virtual ICollection<MessageDTO> Message { get; set; }

        //public virtual ICollection<GroupDTO> Group { get; set; }

    }
}
