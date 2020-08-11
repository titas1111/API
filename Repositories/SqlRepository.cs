using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class SqlRepository : IRepository
    {
        private readonly CurseContext curseContext;

        public SqlRepository(CurseContext curseContext)
        {
            this.curseContext = curseContext;
        }

        public IEnumerable<Curse> GetAllCurses()
        {
            return curseContext.Curses.ToList();
        }

        public Curse GetCurseById(int id)
        {
            return curseContext.Curses.FirstOrDefault(x => x.Id == id);
        }

        public Curse GetRandomCurse()
        {
            return curseContext.Curses.OrderBy(r => Guid.NewGuid()).FirstOrDefault();
        }
    }
}
