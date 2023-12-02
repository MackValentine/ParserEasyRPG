using System;
namespace Parser
{
    class Item
    {

        public int id;
        public String desc = "";

        public int type = 0;

        public int hp_recover_rate;
        public int hp_recover;

        public int sp_recover_rate;
        public int sp_recover;

        public int entire_party;

        public int ko_only;

        public int animation_id;

        public String usable_in_battle = "F";

        public String state_set;

        public int scope;

        public int switch_id;

        public int cursed;

        public int skill_id;

        public bool useSkill;

        public int hp_up;
        public int mp_up;
        public int atk_up;
        public int def_up;
        public int mag_up;
        public int agi_up;

        public int eq_atk_up;
        public int eq_def_up;
        public int eq_mag_up;
        public int eq_agi_up;

        public int consumption_limit;

        public int price;

        public String attributes_rate;
        public String state_resist;

        public String actorEquipable;
        public String classEquipable;

        public String weapon_animation_id = "";

        public int criticalRate;
        public int hitRate;


        public string preemptive;
        public string two_handed;
        public string no_terrain_damage;
        public string half_sp_cost;
        public string raise_evasion;
        public string prevent_critical;
        public string ignore_evasion;
        public string attack_all;
        public string dual_attack;

        public Item(int i)
        {
            id = i;
        }
    }
}
