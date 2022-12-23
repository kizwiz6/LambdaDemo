using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    /// <summary>
    /// Single Responsibility Principle - the class should have only one reason to change.
    /// </summary>
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public int GetAge()
        {
            var currentYear = DateTime.Now.Year;
            return currentYear - BirthDate.Year;
        }
    }
}
