using API.Models;
using System.Collections.Generic;

namespace API.Repositories
{
    public interface IRepository
    {
        IEnumerable<Curse> GetAllCurses();
        Curse GetCurseById(int id);
    }
}
