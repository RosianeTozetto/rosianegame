using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rosianegame.entities
{
    public class Personagem
    {
        public string Name;
        public int Level;
        public string HeroType;

        public Personagem()
        {
        }

        public Personagem(string name, int level, string heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public override string ToString()
        {
            return Name + " " + Level + " " + HeroType;
        }
        public virtual string Attack()
        {
            return Name + " atacou com sua magia";
           
        }
        
        
       
         
    }
}
