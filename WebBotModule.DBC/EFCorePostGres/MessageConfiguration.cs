using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.DBC.EFCorePostGres
{
    public class MessageConfiguration : IBotEntityTypeConfiguration<MessageDTO>
    {
        public void Configure(EntityTypeBuilder<MessageDTO> messageBuilder)
        {
            messageBuilder.HasKey(message => message.idMessage);
            messageBuilder.HasIndex(message => message.idMessage);
            
            messageBuilder.Property(message => message.idMessage).IsRequired().ValueGeneratedOnAdd();            
            messageBuilder.Property(message => message.numIdLanguage).IsRequired();
            messageBuilder.Property(message => message.numType).IsRequired();
            messageBuilder.Property(message => message.vcharMessageText).IsRequired();
        }
    }
}
