using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardEXP { get; set; }
        public int RewardDB { get; set; }
        public Item RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        public Quest(int id, string name, string description, int rewardEXP, int rewardDB)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardEXP = rewardEXP;
            RewardDB = rewardDB;

            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
