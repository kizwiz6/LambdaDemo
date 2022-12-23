﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    /// <summary>
    /// Open-Closed Principle - the class should be open for extension, but closed for modification
    /// </summary>
    interface IUserRepository
    {
        void Add(User user);
        User GetById(int id);
    }
}
