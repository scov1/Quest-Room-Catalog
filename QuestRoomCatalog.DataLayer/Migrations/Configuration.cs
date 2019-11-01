namespace QuestRoomCatalog.DataLayer.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuestRoomCatalog.DataLayer.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QuestRoomCatalog.DataLayer.Model1 context)
        {
        
            List<Roles> roles = new List<Roles>();

            roles.Add(new Roles { Id = 1, RoleName = "admin"});
            roles.Add(new Roles { Id = 2, RoleName = "user" });
            context.Roles.AddRange(roles);

            List<Users> users = new List<Users>();

            users.Add(new Users { Id = 1, RoleId = 1, UserName = "admin2" });
            users.Add(new Users { Id = 2, RoleId = 2, UserName = "user2" });
            context.Users.AddRange(users);
                                    
            base.Seed(context);
        }
    }
}
