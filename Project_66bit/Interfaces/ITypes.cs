using System.Collections.Generic;
using Project_66bit.Models;

namespace Project_66bit.Interfaces
{
    public interface ITypes
    {
        IEnumerable<Type> AllTypes { get; }
        Type GetTypeById(int typeId);
    }
}