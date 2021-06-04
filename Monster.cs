using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxDmg { get; set; }
        public int RewardEXP { get; set; }
        public int RewardDB { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monster(int id, string name, int maxDmg, int rewardEXP, int rewardDB, int currentHP, int maxHP) : base(currentHP, maxHP)
        {
            ID = id;
            Name = name;
            MaxDmg = maxDmg;
            RewardEXP = rewardEXP;
            RewardDB = rewardDB;

            LootTable = new List<LootItem>();
        }
    }
}
