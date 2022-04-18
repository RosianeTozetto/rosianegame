using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rosianegame.entities
{
   

   
        public abstract class Samurai : Personagem
        {

            public Samurai(string name, int level, string heroType)
            {
                Name = name;
                Level = level;
                HeroType = heroType;


            }
            public override string Attack()

            {
                return $"{Name} atacou com sua espada";
            }
            public string Attack(int Bonus)
            {
                if (Bonus > 6)

                    return $"{Name} atacou com sua espada super poderosa com bonus de ataque de " + Bonus;

                else

                    return $"{Name} atacou com sua espada com bonus de" + Bonus;
            }





        }
    }


