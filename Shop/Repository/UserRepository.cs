using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Repository
{
    public class UserRepository
    {
        private readonly AppDbContent appDbContent;

        public UserRepository(AppDbContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<UserModel> Users => appDbContent.user;
        public UserModel GetUser(int userId) => appDbContent.user.FirstOrDefault(c => c.id == userId);
    } 
}
