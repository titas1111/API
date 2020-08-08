using API.Models;
using System.Collections.Generic;
using System.Linq;

namespace API.Repositories
{
    public class MockRepository : IRepository
    {
        public IEnumerable<Curse> GetAllCurses()
        {
            return new List<Curse>
            {
                new Curse {Id = 0, Text = "Po šimts pypkių!" },
                new Curse {Id = 1, Text = "Rupūs miltai!" },
                new Curse {Id = 2, Text = "Kad tau grybai ausis užkištų!" }
            };
        }

        public Curse GetCurseById(int id)
        {
            return GetAllCurses().FirstOrDefault(x => x.Id == id);
        }
    }
}
