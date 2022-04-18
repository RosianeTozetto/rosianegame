using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace rosianegame.entities

{
    public abstract class Villian : Personagem
    {

        public Villian(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;


        }
        public override string Attack()

        {
            return $"{Name} lançou magia";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)

                return $"{Name} lançou magia super poderosa com bonus de ataque de " + Bonus;

            else

                return $"{Name} lançou magia com força fraca com bonus de" + Bonus;
        }
            
           
       

        
    }
}
