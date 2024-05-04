using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAH.Arena.Domain.Foundation
{
    public struct Stats
    {
        public Stats(int hitPoints, int attack, int defense, int specialAttack, int specialDefense, int initiative)
        {
            HitPoints = hitPoints;
            Attack = attack;    
            Defense = defense;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            Initiative = initiative;
        }

        public int HitPoints { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int SpecialAttack { get; set; }

        public int SpecialDefense { get; set; }

        public int Initiative { get; set; }

    }
}
