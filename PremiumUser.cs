using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    /// <summary>
    /// Liskov Substitution Principle - derived classes should be substitutable for their base classes
    /// </summary>
    class PremiumUser : User
    {
        public int Points { get; set; }
    }
}
