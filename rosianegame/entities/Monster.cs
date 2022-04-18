using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rosianegame.entities
{
    
         public abstract class Monster : Personagem
    {

        public Monster(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;


        }
        public override string Attack()

        {
            return $"{Name} + ficou invisivel";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)

                return $"{Name} ficou invisivel por 30 segundos com bonus de" + Bonus;

            else

                return $"{Name} ficou invisivel com bonus de" + Bonus;
        }





    }
}

