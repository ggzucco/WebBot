using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebBotModule.DTO;

namespace WebBotModule.DBC.EFCorePostGres
{
    public class PostgresContext : DbContext
    {
        #region DbSet
        public DbSet<BotDTO> Bot { get; set; }
        public DbSet<CaptchaDTO> Captcha { get; set; }
        public DbSet<GroupDTO> Group { get; set; }
        public DbSet<CommandDTO> HelpCommand { get; set; }
        public DbSet<LanguageDTO> Language { get; set; }
        public DbSet<MessageDTO> Message { get; set; }
        public DbSet<UserDTO> User { get; set; }

        #endregion DbSet

        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options)
        {           
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Here UseConfiguration is any IEntityTypeConfiguration
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BotConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CapchaConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CommandConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GroupConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GroupUserDTOConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LanguageConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MessageConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
        }
    }
}
