using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace API.Models
{
    public class CurseSeed : IEntityTypeConfiguration<Curse>
    {
        public void Configure(EntityTypeBuilder<Curse> builder)
        {
            IEnumerable<Curse> SeedCurses = new List<Curse>
            {
                new Curse {Id = 1, Text = "Po šimts pypkių!" },
                new Curse {Id = 2, Text = "Rupūs miltai!" },
                new Curse {Id = 3, Text = "Kad tau grybai ausis užkištų!" }
            };

            builder.HasData(SeedCurses);

        }
    }
}
