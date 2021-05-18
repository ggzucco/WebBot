using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebBotModule.DBI;
using WebBotModule.DTO;

namespace WebBotModule.DBC.EFCorePostGres
{
    public class GroupUserDTOConfiguration : IBotEntityTypeConfiguration<GroupUserDTO>
    {
        public void Configure(EntityTypeBuilder<GroupUserDTO> groupUserBuilder)
        {
            groupUserBuilder.HasKey(groupUser => groupUser.idUserGroup);

            groupUserBuilder.HasIndex(groupUser =>  new {   groupUser.idUserGroup, 
                                                            groupUser.numIdGroup, 
                                                            groupUser.numIdUser });

            groupUserBuilder.HasMany(groupUser => groupUser.Captchas)
                    .WithOne(captcha => captcha.GroupUser)
                    .HasForeignKey(captcha => captcha.numIdUserGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupUser_Captcha");

            groupUserBuilder.Property(groupUser => groupUser.idUserGroup).IsRequired().ValueGeneratedOnAdd();
            groupUserBuilder.Property(groupUser => groupUser.numIdGroup).IsRequired();
            groupUserBuilder.Property(groupUser => groupUser.numIdUser).IsRequired();
            groupUserBuilder.Property(groupUser => groupUser.dateEntryDate).IsRequired().ValueGeneratedOnAdd();
        }
    }
}
