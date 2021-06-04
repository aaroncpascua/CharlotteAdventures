using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_COOKOUT_TRAY = 1;
        public const int ITEM_ID_NO_FRIENDS = 2;
        public const int ITEM_ID_EX_GIRLFRIEND = 3;
        public const int ITEM_ID_GRADUATION_CORD = 4;
        public const int ITEM_ID_LAB_KIT = 5;
        public const int ITEM_ID_RACQUET = 6;
        public const int ITEM_ID_GAINS = 7;
        public const int ITEM_ID_CROWN_FOOD = 8;
        public const int ITEM_ID_BEAM = 10;
        public const int ITEM_ID_DEPRESSION = 11;
        public const int ITEM_ID_TICKETS = 12;
        public const int ITEM_ID_KNOWLEDGE = 13;
        public const int ITEM_ID_TI84 = 14;
        public const int ITEM_ID_CURSE = 15;
        public const int ITEM_ID_SOVI_FOOD = 16;
        public const int ITEM_ID_FREE_SHIRT = 17;
        public const int ITEM_ID_DEGREE = 18;
        public const int ITEM_ID_CROSBY_TI84 = 19;

        public const int MONSTER_ID_LEO = 1;
        public const int MONSTER_ID_RANAE = 2;
        public const int MONSTER_ID_YOLANDA = 3;
        public const int MONSTER_ID_LAB_TA = 4;
        public const int MONSTER_ID_TYLER = 5;
        public const int MONSTER_ID_LATTA = 6;
        public const int MONSTER_ID_DEPRESSION = 7;
        public const int MONSTER_ID_GYM_FREAK = 8;
        public const int MONSTER_ID_FINALS = 9;
        public const int MONSTER_ID_CROSBY = 10;
        public const int MONSTER_ID_BONNIE = 11;
        public const int MONSTER_ID_PAIGE = 12;

        public const int QUEST_ID_DEFEAT_ALL_MONSTERS = 1;
        public const int QUEST_ID_FINISH_LABS = 2;
        public const int QUEST_ID_GET_ALL_ITEMS = 3;

        public const int LOCATION_ID_LIGHTRAIL = 1;
        public const int LOCATION_ID_COOKOUT = 2;
        public const int LOCATION_ID_WALLIS_HALL = 3;
        public const int LOCATION_ID_ELM_HALL = 4;
        public const int LOCATION_ID_HAWTHORN_HALL = 5;
        public const int LOCATION_ID_EPIC = 6;
        public const int LOCATION_ID_TENNIS_COURTS = 7;
        public const int LOCATION_ID_UREC = 8;
        public const int LOCATION_ID_STUDENT_UNION = 9;
        public const int LOCATION_ID_SMITH = 10;
        public const int LOCATION_ID_ORIENTAL_GARDEN = 11;
        public const int LOCATION_ID_BELK_GYM = 12;
        public const int LOCATION_ID_SAC = 13;
        public const int LOCATION_ID_LIBRARY = 14;
        public const int LOCATION_ID_FRETWELL = 15;
        public const int LOCATION_ID_BOTANNICAL_GARDEN = 16;
        public const int LOCATION_ID_HUNT_HALL = 17;
        public const int LOCATION_ID_SOVI = 18;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateLocations();
            PopulateQuests();
        }

        private static void PopulateItems()
        {
            Items.Add(new HealingPotion(ITEM_ID_COOKOUT_TRAY, "Cookout Tray", "Cookout Trays", 10));
            Items.Add(new Item(ITEM_ID_NO_FRIENDS, "No Friend", "No Friends"));
            Items.Add(new Item(ITEM_ID_EX_GIRLFRIEND, "Ex-Girlfriend", "Ex-Girlfriends"));
            Items.Add(new Item(ITEM_ID_GRADUATION_CORD, "Graduation Cord", "Graduation Cords"));
            Items.Add(new Weapon(ITEM_ID_LAB_KIT, "Lab Kit", "Lab Kits", 0, 7));
            Items.Add(new Weapon(ITEM_ID_RACQUET, "Tennis Racquet", "Tennis Racquets", 0, 15));
            Items.Add(new Weapon(ITEM_ID_GAINS, "Gain", "Gains", 0, 10));
            Items.Add(new HealingPotion(ITEM_ID_CROWN_FOOD, "Crown Commons Food", "Crown Commons Food", 5));
            Items.Add(new Weapon(ITEM_ID_BEAM, "Beam Project Beam", "Beam Project Beam", 0, 3));
            Items.Add(new Weapon(ITEM_ID_DEPRESSION, "Depression", "Depression", 0, 10));
            Items.Add(new Item(ITEM_ID_TICKETS, "Sports Ticket", "Sports Tickets"));
            Items.Add(new Weapon(ITEM_ID_KNOWLEDGE, "Knowledge", "Knowledge", 0, 30));
            Items.Add(new Weapon(ITEM_ID_TI84, "TI-84 Plus", "TI-84 Pluses", 0 , 5));
            Items.Add(new Item(ITEM_ID_CROSBY_TI84, "Dr. Crosby's TI-84 Plus", "Dr. Crosby's TI-84 Pluses"));
            Items.Add(new Weapon(ITEM_ID_CURSE, "Curse", "Curses", 0, 30));
            Items.Add(new HealingPotion(ITEM_ID_SOVI_FOOD, "SoVi Food", "SoVi Food", 5));
            Items.Add(new Item(ITEM_ID_FREE_SHIRT, "Free UNCC Apparel", "Free UNCC Apparel"));
        }

        private static void PopulateMonsters()
        {
            Monster Leo = new Monster(MONSTER_ID_LEO, "Leo Lim", 1, 5, 10, 3, 3);
            Leo.LootTable.Add(new LootItem(ItemByID(ITEM_ID_NO_FRIENDS), 100, false));
            Leo.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FREE_SHIRT), 80, true));

            Monster Ranae = new Monster(MONSTER_ID_RANAE, "Ranae Tuttle", 1, 5, 10, 3, 3);
            Ranae.LootTable.Add(new LootItem(ItemByID(ITEM_ID_EX_GIRLFRIEND), 100, false));
            Ranae.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FREE_SHIRT), 80, true));

            Monster Yolanda = new Monster(MONSTER_ID_YOLANDA, "Yolanda McIlwaine", 3, 10, 20, 6, 6);
            Yolanda.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GRADUATION_CORD), 100, false));
            Yolanda.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FREE_SHIRT), 80, true));

            Monster Lab_TA = new Monster(MONSTER_ID_LAB_TA, "ECGR LAB TA", 3, 7, 15, 5, 5);
            Lab_TA.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LAB_KIT), 100, false));
            Lab_TA.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FREE_SHIRT), 80, true));

            Monster Tyler = new Monster(MONSTER_ID_TYLER, "Tyler Burke", 1, 1, 30, 1, 1);
            Tyler.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RACQUET), 100, false));
            Tyler.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FREE_SHIRT), 80, true));

            Monster Latta = new Monster(MONSTER_ID_LATTA, "Professor Latta", 5, 15, 40, 10, 10);
            Latta.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BEAM), 100, false));
            Latta.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FREE_SHIRT), 80, true));

            Monster Depression = new Monster(MONSTER_ID_DEPRESSION, "Depression", 10, 100, 10, 30, 30);
            Depression.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DEPRESSION), 100, false));
            Depression.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FREE_SHIRT), 80, true));

            Monster Gym_Freak = new Monster(MONSTER_ID_GYM_FREAK, "Gym Freak", 8, 5, 10, 15, 15);
            Gym_Freak.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GAINS), 100, false));
            Gym_Freak.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FREE_SHIRT), 80, true));

            Monster Finals = new Monster(MONSTER_ID_FINALS, "Finals", 5, 100, 0, 30, 30);
            Finals.LootTable.Add(new LootItem(ItemByID(ITEM_ID_KNOWLEDGE), 100, false));
            Finals.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FREE_SHIRT), 80, true));

            Monster Crosby = new Monster(MONSTER_ID_CROSBY, "Dr. Crosby", 7, 20, 50, 15, 15);
            Crosby.LootTable.Add(new LootItem(ItemByID(ITEM_ID_CROSBY_TI84), 100, false));
            Crosby.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FREE_SHIRT), 80, true));

            Monster Bonnie = new Monster(MONSTER_ID_BONNIE, "Chancellor Bonnie's Ghost", 0, 200, 20, 50, 50);
            Bonnie.LootTable.Add(new LootItem(ItemByID(ITEM_ID_CURSE), 100, false));
            Bonnie.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FREE_SHIRT), 80, true));

            Monster Paige = new Monster(MONSTER_ID_PAIGE, "Paige Fountain", 1, 5, 10, 3, 3);
            Paige.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DEPRESSION), 100, false));
            Paige.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FREE_SHIRT), 80, true));
        }

        private static void PopulateQuests()
        {
            Quest defeatAllMonsters = new Quest(QUEST_ID_DEFEAT_ALL_MONSTERS, "Defeat all enemies", "Find all enemies and defeat them", 1000, 1000);
            defeatAllMonsters.RewardItem = ItemByID(ITEM_ID_DEGREE);
            //needs completion requirement

            Quest finishLabs = new Quest(QUEST_ID_FINISH_LABS, "Finish your labs.", "Get two lab kits", 500, 50);
            finishLabs.RewardItem = ItemByID(ITEM_ID_FREE_SHIRT);
            finishLabs.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_LAB_KIT), 2));

            Quest getAllItems = new Quest(QUEST_ID_GET_ALL_ITEMS, "Get all items", "This is self-explanatory", 1000, 1000);
            getAllItems.RewardItem = ItemByID(ITEM_ID_FREE_SHIRT);
            //needs completion requirement

            Quests.Add(defeatAllMonsters);
            Quests.Add(finishLabs);
            Quests.Add(getAllItems);
        }

        private static void PopulateLocations()
        {
            Location Lightrail = new Location(LOCATION_ID_LIGHTRAIL, "Lightrail", "Parent's dropped you off at the lightrail. Finally free!");

            Location Cookout = new Location(LOCATION_ID_COOKOUT, "Cookout", "It smells like weed and beer. I thought this was a Cookout.");
            //add vendor
            
            Location Wallis_Hall = new Location(LOCATION_ID_WALLIS_HALL, "Wallis Hall", "Your sophomore year dorm. It reeks in the living room. It's Kyle's week to take out the trash...");
            Wallis_Hall.MonsterLivingHere = MonsterByID(MONSTER_ID_LEO);

            Location Elm_Hall = new Location(LOCATION_ID_ELM_HALL, "Elm Hall", "This dorm is brand-spanking-new. Smells fresh.");
            Elm_Hall.MonsterLivingHere = MonsterByID(MONSTER_ID_RANAE);

            Location Hawthorn_Hall = new Location(LOCATION_ID_HAWTHORN_HALL, "Hawthorn Hall", "The halls are so small I can touch the walls with my elbows. Is that a burn mark on the wall?");
            Hawthorn_Hall.MonsterLivingHere = MonsterByID(MONSTER_ID_YOLANDA);

            Location EPIC = new Location(LOCATION_ID_EPIC, "EPIC", "My real home. I can hear the robots running around the halls.");
            EPIC.MonsterLivingHere = MonsterByID(MONSTER_ID_LAB_TA);
            EPIC.QuestAvailableHere = QuestByID(QUEST_ID_FINISH_LABS);

            Location Tennis_Courts = new Location(LOCATION_ID_TENNIS_COURTS, "Halton-Wagner Tennis Complex", "There are some noobs playing on the court. I bet I could beat them.");
            Tennis_Courts.MonsterLivingHere = MonsterByID(MONSTER_ID_TYLER);

            Location UREC = new Location(LOCATION_ID_UREC, "UREC", "There's a ton of construction. I don't even remember how the hill looked before construction.");

            Location Student_Union = new Location(LOCATION_ID_STUDENT_UNION, "Popp Martin Student Union", "The Union is popping today. It smells like Starbucks and I can hear screams from the gaming club upstairs.");
            //add vendor

            Location Smith = new Location(LOCATION_ID_SMITH, "Smith", "The old and crusty engineering building. It kinda smells like an old textbook in here.");
            Smith.MonsterLivingHere = MonsterByID(MONSTER_ID_LATTA);

            Location Oriental_Garden = new Location(LOCATION_ID_ORIENTAL_GARDEN, "Oriental Garden", "The sounds of the mini-lake is sooo calming. There's the GORGEOUS red leaf tree, I can't take my eyes off of it.");
            Oriental_Garden.MonsterLivingHere = MonsterByID(MONSTER_ID_DEPRESSION);

            Location Belk_Gym = new Location(LOCATION_ID_BELK_GYM, "Belk Gym", "It's a quiet day for basketball. Downstairs smells like straigh blood, sweat, and GAINS.");
            Belk_Gym.MonsterLivingHere = MonsterByID(MONSTER_ID_GYM_FREAK);

            Location SAC = new Location(LOCATION_ID_SAC, "The SAC", "There's a game today. Maybe I should go watch it...");
            //add vendor

            Location Library = new Location(LOCATION_ID_LIBRARY, "J. Murrey Atkins Library", "The grind is here. Biology students shedding tears. Business students sleeping. The peace and quiet is killing me.");
            Library.MonsterLivingHere = MonsterByID(MONSTER_ID_FINALS);

            Location Fretwell = new Location(LOCATION_ID_FRETWELL, "Fretwell", "This spiral staircase is the only thing that makes this building cool. The benches are filled with test-crammers. Peet's coffee smells good.");
            Fretwell.MonsterLivingHere = MonsterByID(MONSTER_ID_CROSBY);

            Location Botannical_Garden = new Location(LOCATION_ID_BOTANNICAL_GARDEN, "Botannical Garden", "This place is huge! There's like no water in this creek wtf.");
            Botannical_Garden.MonsterLivingHere = MonsterByID(MONSTER_ID_BONNIE);

            Location Hunt_Hall = new Location(LOCATION_ID_HUNT_HALL, "Hunt Hall", "The halls are huge and dimly lit. I wanna just smash one of those EXIT signs.");
            Hunt_Hall.MonsterLivingHere = MonsterByID(MONSTER_ID_PAIGE);

            Location SoVi = new Location(LOCATION_ID_SOVI, "SoVi Dining Hall", "The space is so open, but ironically doesn't smell like food. The sweets look so good.");
            //add vendor

            Lightrail.LocationToSouth = Wallis_Hall;

            Cookout.LocationToSouth = EPIC;

            Wallis_Hall.LocationToNorth = Lightrail;
            Wallis_Hall.LocationToEast = Elm_Hall;
            Wallis_Hall.LocationToSouth = Student_Union;

            Elm_Hall.LocationToWest = Wallis_Hall;
            Elm_Hall.LocationToEast = Hawthorn_Hall;
            Elm_Hall.LocationToSouth = Smith;

            Hawthorn_Hall.LocationToWest = Elm_Hall;
            Hawthorn_Hall.LocationToSouth = Oriental_Garden;

            EPIC.LocationToNorth = Cookout;
            EPIC.LocationToEast = Tennis_Courts;

            Tennis_Courts.LocationToWest = EPIC;
            Tennis_Courts.LocationToEast = UREC;

            UREC.LocationToWest = Tennis_Courts;
            UREC.LocationToEast = Student_Union;
            UREC.LocationToSouth = Belk_Gym;

            Student_Union.LocationToNorth = Wallis_Hall;
            Student_Union.LocationToWest = UREC;
            Student_Union.LocationToSouth = SAC;
            Student_Union.LocationToEast = Smith;

            Smith.LocationToNorth = Elm_Hall;
            Smith.LocationToWest = Student_Union;
            Smith.LocationToEast = Oriental_Garden;
            Smith.LocationToSouth = Library;

            Oriental_Garden.LocationToNorth = Hawthorn_Hall;
            Oriental_Garden.LocationToWest = Smith;
            Oriental_Garden.LocationToSouth = Fretwell;

            Belk_Gym.LocationToNorth = UREC;
            Belk_Gym.LocationToEast = SAC;
            Belk_Gym.LocationToSouth = Hunt_Hall;

            SAC.LocationToNorth = Student_Union;
            SAC.LocationToWest = Belk_Gym;
            SAC.LocationToEast = Library;
            SAC.LocationToSouth = SoVi;

            Library.LocationToNorth = Smith;
            Library.LocationToWest = SAC;
            Library.LocationToEast = Fretwell;

            Fretwell.LocationToNorth = Oriental_Garden;
            Fretwell.LocationToWest = Library;
            Fretwell.LocationToEast = Botannical_Garden;

            Botannical_Garden.LocationToWest = Fretwell;

            Hunt_Hall.LocationToEast = SoVi;
            Hunt_Hall.LocationToNorth = Belk_Gym;

            SoVi.LocationToWest = Hunt_Hall;
            SoVi.LocationToNorth = SAC;

            Locations.Add(Lightrail);
            Locations.Add(Cookout);
            Locations.Add(Wallis_Hall);
            Locations.Add(Elm_Hall);
            Locations.Add(Hawthorn_Hall);
            Locations.Add(EPIC);
            Locations.Add(Tennis_Courts);
            Locations.Add(UREC);
            Locations.Add(Student_Union);
            Locations.Add(Smith);
            Locations.Add(Oriental_Garden);
            Locations.Add(Belk_Gym);
            Locations.Add(SAC);
            Locations.Add(Library);
            Locations.Add(Fretwell);
            Locations.Add(Botannical_Garden);
            Locations.Add(Hunt_Hall);
            Locations.Add(SoVi);
    }

        public static Item ItemByID(int id)
        {
            foreach(Item item in Items)
            {
                if(item.ID == id){
                    return item;
                }
            }
            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach(Monster monster in Monsters)
            {
                if(monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach(Quest quest in Quests) {
                if (quest.ID == id)
                {
                    return quest;
                }
            }
            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach(Location location in Locations)
            {
               if(location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }
    }
}
