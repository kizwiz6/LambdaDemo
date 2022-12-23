using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    /// <summary>
    /// This class is open for extension (we can add more methods to the interface and implement them here)
    /// But it's clsoed for modification (we don't need to change the existing implementation of the Add and GetById methods).
    /// </summary>
    internal class UserRepository : IUserRepository
    {
        public void Add(User user)
        {
            // Add the user to the database
        }

        public User GetById(int id)
        {
            // retrieve the user from the database
            return new User();
        }
    }
}
