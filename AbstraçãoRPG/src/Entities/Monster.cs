using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraçãoRPG.src.Entities
{
    public abstract class Monster
    {

        public Monster(string name, int level, string monsterType, int health)
        {
            Name = name;
            Level = level;
            MonsterType = monsterType;
            Health = health;
        }
        public string Name { get; set; }
        public int Level { get; set; }
        public string MonsterType { get; set; }
        public int Health { get; set; }

        public override string ToString()
        {
            return $"Nome: {Name} \nLevel: {Level} \nMonsterType: {MonsterType} \nHealth: {Health}";
        }

        public virtual string Attack(int damage, Monster monster)
        {
            return $"{Name} atacou {monster.Name} Causando {damage} de dano!";
            monster.Health -= damage;
        }
        public virtual string Attack(int? bonus)
        {
            if (bonus < 25) return $"{Name} fez um ataque fraco com {bonus}% de bonus!";
            else return $"{Name} te atacou fortemente! Com um bônus de ataque de {bonus}%";
        }
    }
}
