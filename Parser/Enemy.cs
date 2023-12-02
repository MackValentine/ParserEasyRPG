using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    class Enemy
    {
        public int id;

        public int gold;
        public int exp;

        public String attributes_rate;
        public String states_rate;

        public string battler_name;

        public int loot_id;
        public int loot_rate;

        public int animation_id;

        public int maxHP;
        public int maxMP;
        public int atk;
        public int def;
        public int mind;
        public int agi;


        public int criticalRate;
        public int criticalHit;

        public ArrayList actions;

        public Enemy(int i)
        {
            id = i;
            actions = new ArrayList();
        }
    }
}
