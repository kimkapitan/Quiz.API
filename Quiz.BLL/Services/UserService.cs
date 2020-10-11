using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Quiz.DAL.EF;
using Quiz.DAL.Entities;
using System.Threading.Tasks;

namespace Quiz.BLL.Services
{
    /// <summary>
    /// Simple service for store users and get them by IP
    /// </summary>
    public class UserService : ServiceBase
    {
        public UserService(IMapper mapper, ApplicationContext context) : base(mapper, context)
        {
        }
        /// <summary>
        /// Get user by IP
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public async Task<User> GetUserByIPAsync(string ip)
        {
            return (await Context.Users.FirstOrDefaultAsync(x => x.IPAddress == ip)) ?? await AddUserAsync(ip);
        }

        /// <summary>
        /// Add user if it does not exist
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        private async Task<User> AddUserAsync(string ip)
        {
            var user = new User
            {
                IPAddress = ip
            };
            Context.Users.Add(user);
            await Context.SaveChangesAsync();
            return user;
        }
    }
}
