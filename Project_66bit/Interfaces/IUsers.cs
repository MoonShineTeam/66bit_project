using System.Collections.Generic;
using Project_66bit.Models;

namespace Project_66bit.Interfaces
{
    public interface IUsers
    {
        IEnumerable<User> AllUsers { get; }
        User GetUserById(long id);
    }
}