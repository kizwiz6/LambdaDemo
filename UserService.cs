using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    /// <summary>
    /// Dependency Inversion Principle - high-level modules should not depend on low-level modules. Both should depend on abstractions
    /// </summary>
    class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly INotificationService _notificationService;

        public UserService(IUserRepository userRepository, INotificationService notificationService)
        {
            _userRepository = userRepository;
            _notificationService = notificationService;
        }

        public void Register(string name, string email, DateTime birthDate)
        {
            var user = new User
            {
                Name = name,
                Email = email,
                BirthDate = birthDate
            };
        }
    }
}
