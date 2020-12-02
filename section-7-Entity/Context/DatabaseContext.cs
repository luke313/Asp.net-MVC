using section_7_Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace section_7_Entity.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Users> UsersEntity { get; set; }
        public DbSet<Addresses> AddressEntity { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new AddingDbForFirstTime());
        }
    }

    public class AddingDbForFirstTime : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                Users user = new Users();
                user.Name = FakeData.NameData.GetFirstName();
                user.Surname = FakeData.NameData.GetSurname();
                context.UsersEntity.Add(user);
            }
            context.SaveChanges();
            List<Users> userList = context.UsersEntity.ToList();
            foreach (var user in userList)
            {
                //db ye eklenen her bir kullanıcı için 1-15 arası adet adres eklenecek.
                for (int i = 0; i < FakeData.NumberData.GetNumber(1, 15); i++)
                {
                    Addresses address = new Addresses();
                    address.AddressDesc = FakeData.PlaceData.GetAddress();
                    address.User = user;
                    context.AddressEntity.Add(address);

                }
            }
            context.SaveChanges();
            
        }
    }
}