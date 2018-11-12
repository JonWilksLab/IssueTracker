using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLibrary
{
    /// <summary>
    /// Defines a common interface for User management
    /// </summary>
    public interface IUsers
    {

        List<User> GetUsers();
        User CreateUser(User user);
        User UpdateUser(User user);
    }
}
