using AMRDb;
using AMRDb.Models;

namespace AMRServices.Services
{
    public class UserServices : IUserServices
    {
         private ApplicationDbContext DbContext { get; }

        public UserServices(ApplicationDbContext dbContext)
        {
            this.DbContext = dbContext;
        }


        public async Task<User> CreateNewUser(string name, int age)
        {
            if (name != null && age >= 0)
            {
                User user = new User();
                user.Name = name;
                user.Age = age;

                await this.DbContext.Users.AddAsync(user);
                await DbContext.SaveChangesAsync();

                return user;
            }
            throw new NotImplementedException();
        }
    }
}
