using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraçãoRPG.src.Entities
{
    internal class Humanoid : Monster
    {
        public Humanoid(string name, int level, string monsterType, int health) : base(name, level, monsterType, health)
        {
        }
        
    }
}
