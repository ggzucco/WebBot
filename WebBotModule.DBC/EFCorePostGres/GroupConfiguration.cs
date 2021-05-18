using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.DBC.EFCorePostGres
{
    public class GroupConfiguration : IBotEntityTypeConfiguration<GroupDTO>
    {
        public void Configure(EntityTypeBuilder<GroupDTO> groupBuilder)
        {
            groupBuilder.HasKey(group => group.idGroup);

            groupBuilder.HasIndex(group => new { group.idGroup, 
                                                 group.idTelegramGroup });

            groupBuilder.HasMany(group => group.GroupUsers)
                        .WithOne(groupUser => groupUser.Group)
                        .HasForeignKey(groupUser => groupUser.numIdGroup)
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Group_GroupUser");

            groupBuilder.Property(group => group.idGroup).IsRequired().ValueGeneratedOnAdd();
            groupBuilder.Property(group => group.idTelegramGroup).IsRequired();
            groupBuilder.Property(group => group.numIdLanguage).IsRequired();
            groupBuilder.Property(group => group.vcharCountryName).IsRequired();
            groupBuilder.Property(group => group.vcharGroupName).IsRequired();
            groupBuilder.Property(group => group.vcharGroupAdress).IsRequired();
        }
    }
}
