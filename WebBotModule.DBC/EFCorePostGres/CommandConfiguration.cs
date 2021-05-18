using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.DBC.EFCorePostGres
{
    public class CommandConfiguration : IBotEntityTypeConfiguration<CommandDTO>
    {
        public void Configure(EntityTypeBuilder<CommandDTO> commandBuilder)
        {
            commandBuilder.HasKey(command => command.idCommand);
            commandBuilder.HasIndex(command => command.idCommand);
            
            commandBuilder.Property(command => command.idCommand).IsRequired().ValueGeneratedOnAdd();
            commandBuilder.Property(command => command.numIdBot).IsRequired();
            commandBuilder.Property(command => command.vcharDescription).IsRequired();
            commandBuilder.Property(command => command.vcharHelpCommand).IsRequired();
        }
    }
}
