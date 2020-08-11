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
                new Curse {Id = 3, Text = "Kad tau grybai ausis užkištų!" },
                new Curse {Id = 4, Text = "Kad tave šunys užmirštų" },
                new Curse {Id = 5, Text = "Eik tu balų degint" },
                new Curse {Id = 6, Text = "Po šimts gegučių!" },
                new Curse {Id = 7, Text = "Kad tave zuikis subadytų!" },
                new Curse {Id = 8, Text = "Žalčio koja pastaroji!" },
                new Curse {Id = 9, Text = "Papūsk dyglei į rankovę!" },
                new Curse {Id = 10, Text = "Ot tu šuns pasturgali" },
                new Curse {Id = 11, Text = "Apsišik aukštielninkas" },
                new Curse {Id = 12, Text = "Šliaušk tarybiniais vamzdžiais" },
                new Curse {Id = 13, Text = "Įsikąsk į stuburą" },
                new Curse {Id = 14, Text = "Elniaragį tau į subinę" },
                new Curse {Id = 15, Text = "Eik tu kiaulėms uodegas mazgoti" },
                new Curse {Id = 16, Text = "Papūsk šuniui į uodegą!" },
                new Curse {Id = 17, Text = "Ko prikibai kaip lapas prie užpakalio!" },
                new Curse {Id = 18, Text = "O tu šuns kumpi" },
                new Curse {Id = 19, Text = "Kramtyk mėšlą" },
                new Curse {Id = 20, Text = "Surūgsi kaip kisielius!" },
                new Curse {Id = 21, Text = "Pakasyk sliekui pažastį!" },
                new Curse {Id = 22, Text = "Kad tave varnos sulestų!" },
                new Curse {Id = 23, Text = "Snarglių kompotas!" },

            };

            builder.HasData(SeedCurses);

        }
    }
}
