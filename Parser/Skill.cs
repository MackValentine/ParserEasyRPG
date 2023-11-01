using System;

namespace Parser
{
    class Skill
    {
        public int id;

        public int cost;
        public int sp_percent;

        public int typeSk = 1;

        public String desc = "";

        public int scope = 0;

        public int magical_rate;

        public int physical_rate;

        public String attributeEffects;

        public String states;

        public int increaseHP;

        public int increaseMP;

        public int power;

        public int inflictStates;

        public int animation_id;

        public Skill(int i)
        {
            id = i;
        }
    }
}
