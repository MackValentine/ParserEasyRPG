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

        public String attributeEffects;

        public String states;

        public int affectHP;
        public int affectMP;
        public int affectAtk;
        public int affectDef;
        public int affectMag;
        public int affectAgi;

        public int power;
        public int variance;
        public int magical_rate;
        public int physical_rate;
        public int successRate;

        public int inflictStates;

        public int animation_id;
        public int absorb_damage;
        public int ignore_defense;

        public Skill(int i)
        {
            id = i;
        }
    }
}
