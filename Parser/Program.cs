using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;

namespace Parser
{
    class Program
    {

        static void Main(string[] args)
        {

            bool useSubDir = false;
            if (args.Length > 0)
            {
                useSubDir = true;
            }

            bool exists = System.IO.File.Exists("RPG_RT.edb");

            if (exists)
            {

                ArrayList skills = new ArrayList();
                ArrayList items = new ArrayList();
                ArrayList actors = new ArrayList();
                ArrayList states = new ArrayList();
                ArrayList enemies = new ArrayList();
                ArrayList attributes = new ArrayList();
                ArrayList terrains = new ArrayList();
                ArrayList troops = new ArrayList();

                XmlDocument doc = new XmlDocument();

                StreamReader reader = new StreamReader("RPG_RT.edb");
                doc.Load(reader);
                reader.Close();
                //doc.Load("RPG_RT.edb");

                foreach (XmlNode node in doc.DocumentElement)
                {
                    foreach (XmlNode no in node.ChildNodes)
                    {
                        foreach (XmlNode no2 in no.ChildNodes)
                        {

                            if (no2.Name == "Enemy")
                            {
                                if (no2.Attributes[0] != null)
                                {
                                    int i = int.Parse(no2.Attributes[0].Value);

                                    Enemy e = new Enemy(i);
                                    foreach (XmlNode no3 in no2.ChildNodes)
                                    {
                                        if (no3.Name == "gold")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.gold = n;
                                        }
                                        else if (no3.Name == "exp")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.exp = n;
                                        }
                                        else if (no3.Name == "state_ranks")
                                        {
                                            String n = no3.InnerText;
                                            e.states_rate = n;
                                        }
                                        else if (no3.Name == "attribute_ranks")
                                        {
                                            String n = no3.InnerText;
                                            e.attributes_rate = n;
                                        }
                                        else if (no3.Name == "battler_name")
                                        {
                                            String n = no3.InnerText;
                                            e.battler_name = n;
                                        }
                                        else if (no3.Name == "drop_id")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.loot_id = n;
                                        }
                                        else if (no3.Name == "drop_prob")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.loot_rate = n;
                                        }
                                        else if (no3.Name == "maniac_unarmed_animation")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.animation_id = n;
                                        }
                                        else if (no3.Name == "max_hp")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.maxHP = n;
                                        }
                                        else if (no3.Name == "max_sp")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.maxMP = n;
                                        }
                                        else if (no3.Name == "attack")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.atk = n;
                                        }
                                        else if (no3.Name == "defense")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.def = n;
                                        }
                                        else if (no3.Name == "spirit")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.mind = n;
                                        }
                                        else if (no3.Name == "agility")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.agi = n;
                                        }
                                    }
                                    enemies.Add(e);
                                }
                            }
                            else if (no2.Name == "Terrain")
                            {
                                if (no2.Attributes[0] != null)
                                {
                                    int i = int.Parse(no2.Attributes[0].Value);

                                    Terrain e = new Terrain(i);
                                    foreach (XmlNode no3 in no2.ChildNodes)
                                    {
                                        if (no3.Name == "background_name")
                                        {
                                            String n = no3.InnerText;
                                            e.battleback_name = n;
                                        }
                                    }
                                    terrains.Add(e);
                                }
                            }
                            else if (no2.Name == "Actor")
                            {
                                if (no2.Attributes[0] != null)
                                {
                                    int i = int.Parse(no2.Attributes[0].Value);

                                    Actor e = new Actor(i);
                                    foreach (XmlNode no3 in no2.ChildNodes)
                                    {
                                        if (no3.Name == "face_index")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.face_index = n;
                                        }
                                        else if (no3.Name == "face_name")
                                        {
                                            String n = no3.InnerText;
                                            e.face_name = n;
                                        }
                                        else if (no3.Name == "exp_base")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.expBasic = n;
                                        }
                                        else if (no3.Name == "exp_inflation")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.expExtra = n;
                                        }
                                        else if (no3.Name == "exp_correction")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.expAcc = n;
                                        }
                                        else if (no3.Name == "title")
                                        {
                                            String n = no3.InnerText;
                                            e.nickname = n;
                                        }
                                        else if (no3.Name == "class_id")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.class_id = n;
                                        }
                                        else if (no3.Name == "state_ranks")
                                        {
                                            String n = no3.InnerText;
                                            e.states_rate = n;
                                        }
                                        else if (no3.Name == "attribute_ranks")
                                        {
                                            String n = no3.InnerText;
                                            e.attributes_rate = n;
                                        }
                                    }
                                    actors.Add(e);
                                }
                            }
                            else if (no2.Name == "Item")
                            {
                                int i = int.Parse(no2.Attributes[0].Value);
                                Item e = new Item(i);
                                foreach (XmlNode no3 in no2.ChildNodes)
                                {
                                    if (no3.Name == "description")
                                    {
                                        String n = no3.InnerText;
                                        e.desc = n;
                                    }
                                    else if (no3.Name == "type")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.type = n;
                                    }
                                    else if (no3.Name == "recover_hp_rate")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.hp_recover_rate = n;
                                    }
                                    else if (no3.Name == "recover_hp")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.hp_recover = n;
                                    }
                                    else if (no3.Name == "recover_sp_rate")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.sp_recover_rate = n;
                                    }
                                    else if (no3.Name == "recover_sp")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.sp_recover = n;
                                    }
                                    else if (no3.Name == "entire_party")
                                    {
                                        int n = 1;
                                        if (no3.InnerText == "F")
                                            n = 0;
                                        e.entire_party = n;
                                    }
                                    else if (no3.Name == "ko_only")
                                    {
                                        int n = 1;
                                        if (no3.InnerText == "F")
                                            n = 0;
                                        e.ko_only = n;
                                    }
                                    else if (no3.Name == "cursed")
                                    {
                                        int n = 1;
                                        if (no3.InnerText == "F")
                                            n = 0;
                                        e.cursed = n;
                                    }
                                    else if (no3.Name == "occasion_field1")
                                    {
                                        if (e.type == 6)
                                        {
                                            String n = no3.InnerText;
                                            if (n == "T")
                                                e.usable_in_battle = "F";
                                            else
                                                e.usable_in_battle = "T";
                                        }
                                    }
                                    else if (no3.Name == "entire_party")
                                    {
                                        if (e.type == 10)
                                        {
                                            String n = no3.InnerText;
                                            if (n == "F")
                                                e.scope = 0;
                                            else
                                                e.scope = 1;
                                        }
                                    }
                                    else if (no3.Name == "occasion_battle")
                                    {
                                        if (e.type == 10)
                                        {
                                            String n = no3.InnerText;
                                            e.usable_in_battle = n;
                                        }
                                    }
                                    else if (no3.Name == "animation_id")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.animation_id = n;
                                    }
                                    else if (no3.Name == "switch_id")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.switch_id = n;
                                    }
                                    else if (no3.Name == "state_set")
                                    {
                                        String n = no3.InnerText;
                                        e.state_set = n;
                                    }
                                    else if (no3.Name == "use_skill")
                                    {
                                        if (no3.InnerText == "F")
                                            e.useSkill = false;
                                        else
                                            e.useSkill = true;
                                    }
                                    else if (no3.Name == "skill_id")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.skill_id = n;
                                    }
                                    else if (no3.Name == "animation_data")
                                    {
                                        foreach (XmlNode no4 in no3.ChildNodes)
                                        {
                                            if (no4.Name == "BattlerAnimationItemSkill")
                                            {
                                                foreach (XmlNode no5 in no4.ChildNodes)
                                                {
                                                    if (no5.Name == "battle_animation_id")
                                                    {
                                                        String n = no5.InnerText;
                                                        e.weapon_animation_id += " " + n;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (no3.Name == "max_hp_points")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.hp_up = n;
                                    }
                                    else if (no3.Name == "max_sp_points")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.mp_up = n;
                                    }
                                    else if (no3.Name == "atk_points2")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.atk_up = n;
                                    }
                                    else if (no3.Name == "def_points2")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.def_up = n;
                                    }
                                    else if (no3.Name == "spi_points2")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.mag_up = n;
                                    }
                                    else if (no3.Name == "agi_points2")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.agi_up = n;
                                    }
                                    else if (no3.Name == "uses")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.consumption_limit = n;
                                    }
                                    else if (no3.Name == "price")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.price = n;
                                    }
                                    else if (no3.Name == "attribute_set")
                                    {
                                        String n = no3.InnerText;
                                        e.attributes_rate = n;
                                    }
                                    else if (no3.Name == "reverse_state_effect")
                                    {
                                        String n = no3.InnerText;
                                        if (n == "T")
                                            e.state_resist = "F";
                                        else
                                            e.state_resist = "T";
                                    }
                                    else if (no3.Name == "atk_points1")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.eq_atk_up = n;
                                    }
                                    else if (no3.Name == "def_points1")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.eq_def_up = n;
                                    }
                                    else if (no3.Name == "spi_points1")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.eq_mag_up = n;
                                    }
                                    else if (no3.Name == "agi_points1")
                                    {
                                        int n = int.Parse(no3.InnerText);
                                        e.eq_agi_up = n;
                                    }
                                    else if (no3.Name == "actor_set")
                                    {
                                        String n = no3.InnerText;
                                        e.actorEquipable = n;
                                    }
                                    else if (no3.Name == "class_set")
                                    {
                                        String n = no3.InnerText;
                                        e.classEquipable = n;
                                    }
                                }
                                items.Add(e);
                            }
                            else if (no2.Name == "Skill")
                            {
                                if (no2.Attributes[0] != null)
                                {
                                    int i = int.Parse(no2.Attributes[0].Value);
                                    Skill e = new Skill(i);
                                    foreach (XmlNode no3 in no2.ChildNodes)
                                    {
                                        if (no3.Name == "sp_cost")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.cost = n;
                                        }
                                        else if (no3.Name == "scope")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.scope = n;
                                        }
                                        else if (no3.Name == "sp_percent")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.sp_percent = n;
                                        }
                                        else if (no3.Name == "description")
                                        {
                                            String n = no3.InnerText;
                                            e.desc = n;
                                        }
                                        else if (no3.Name == "type")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.typeSk = n;
                                        }
                                        else if (no3.Name == "magical_rate")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.magical_rate = n;
                                        }
                                        else if (no3.Name == "physical_rate")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.physical_rate = n;
                                        }
                                        else if (no3.Name == "attribute_effects")
                                        {
                                            String n = no3.InnerText;
                                            e.attributeEffects = n;
                                        }
                                        else if (no3.Name == "power")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.power = n;
                                        }
                                        else if (no3.Name == "affect_hp")
                                        {
                                            int n = 1;
                                            if (no3.InnerText == "F")
                                                n = 0;
                                            e.increaseHP = n;
                                        }
                                        else if (no3.Name == "affect_sp")
                                        {
                                            int n = 1;
                                            if (no3.InnerText == "F")
                                                n = 0;
                                            e.increaseMP = n;
                                        }
                                        else if (no3.Name == "state_effects")
                                        {
                                            String n = no3.InnerText;
                                            e.states = n;
                                        }
                                        else if (no3.Name == "reverse_state_effect")
                                        {
                                            int n = 1;
                                            if (no3.InnerText == "F")
                                                n = 0;
                                            e.inflictStates = n;
                                        }
                                        else if (no3.Name == "animation_id")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.animation_id = n;
                                        }

                                    }
                                    skills.Add(e);
                                }
                            }
                            else if (no2.Name == "State")
                            {
                                if (no2.Attributes[0] != null)
                                {
                                    int i = int.Parse(no2.Attributes[0].Value);
                                    State e = new State(i);
                                    foreach (XmlNode no3 in no2.ChildNodes)
                                    {
                                        if (no3.Name == "restrict_skill")
                                        {
                                            String n = no3.InnerText;
                                            e.restricted_physical = n;
                                        }
                                        else if (no3.Name == "restrict_skill_level")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.physical_rate = n;
                                        }
                                        else if (no3.Name == "restrict_magic")
                                        {
                                            String n = no3.InnerText;
                                            e.restricted_magical = n;
                                        }
                                        else if (no3.Name == "restrict_magic_level")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.magical_rate = n;
                                        }
                                        else if (no3.Name == "type")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.type = n;
                                        }
                                        else if (no3.Name == "a_rate")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.a_rate = n;
                                        }
                                        else if (no3.Name == "b_rate")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.b_rate = n;
                                        }
                                        else if (no3.Name == "c_rate")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.c_rate = n;
                                        }
                                        else if (no3.Name == "d_rate")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.d_rate = n;
                                        }
                                        else if (no3.Name == "e_rate")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.e_rate = n;
                                        }
                                    }
                                    states.Add(e);
                                }
                            }
                            else if (no2.Name == "Attribute")
                            {
                                if (no2.Attributes[0] != null)
                                {
                                    int i = int.Parse(no2.Attributes[0].Value);
                                    Attribute e = new Attribute(i);
                                    foreach (XmlNode no3 in no2.ChildNodes)
                                    {

                                        if (no3.Name == "a_rate")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.a_rate = n;
                                        }
                                        else if (no3.Name == "b_rate")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.b_rate = n;
                                        }
                                        else if (no3.Name == "c_rate")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.c_rate = n;
                                        }
                                        else if (no3.Name == "d_rate")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.d_rate = n;
                                        }
                                        else if (no3.Name == "e_rate")
                                        {
                                            int n = int.Parse(no3.InnerText);
                                            e.e_rate = n;
                                        }
                                    }
                                    attributes.Add(e);
                                }
                            }
                            else if (no2.Name == "Troop")
                            {
                                if (no2.Attributes[0] != null)
                                {
                                    int i = int.Parse(no2.Attributes[0].Value);
                                    Troop t = new Troop(i);
                                    foreach (XmlNode no3 in no2.ChildNodes)
                                    {
                                        if (no3.Name == "name")
                                        {
                                            String n = no3.InnerText;
                                            t.name = n;
                                        }
                                        else if (no3.Name == "members")
                                        {
                                            foreach (XmlNode no4 in no3.ChildNodes)
                                            {
                                                if (no4.Attributes[0] != null)
                                                {
                                                    int i2 = int.Parse(no4.Attributes[0].Value) - 1;
                                                    foreach (XmlNode no5 in no4.ChildNodes)
                                                    {
                                                        if (no5.Name == "enemy_id")
                                                        {
                                                            int n = int.Parse(no5.InnerText);
                                                            t.enemy_id[i2] = n;
                                                        }
                                                        else if (no5.Name == "x")
                                                        {
                                                            int n = int.Parse(no5.InnerText);
                                                            t.enemy_x[i2] = n;
                                                        }
                                                        else if (no5.Name == "y")
                                                        {
                                                            int n = int.Parse(no5.InnerText);
                                                            t.enemy_y[i2] = n;
                                                        }
                                                        else if (no5.Name == "invisible")
                                                        {
                                                            String n = no5.InnerText;
                                                            t.enemy_invisible[i2] = n;
                                                        }
                                                    }
                                                }
                                            }
                                        }

                                    }
                                    troops.Add(t);
                                }
                            }

                        }
                    }
                }


                String text;
                String subDir = "";

                exists = System.IO.Directory.Exists("Text/");

                if (!exists)
                    System.IO.Directory.CreateDirectory("Text/");

                Encoding utf8WithoutBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);

                /*
                *  Actors
                */
                {
                    subDir = "";
                    if (useSubDir)
                    {
                        subDir = "actors/";
                        exists = System.IO.Directory.Exists("Text/" + subDir);

                        if (!exists)
                            System.IO.Directory.CreateDirectory("Text/" + subDir);
                    }

                    text = "";
                    foreach (Actor s in actors)
                    {
                        String n = s.face_name;
                        int i = s.face_index;
                        text += n + "/" + i + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "actors_faceset.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Actor s in actors)
                    {
                        int i = s.expBasic;
                        text += i + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "actors_expBasic.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Actor s in actors)
                    {
                        int i = s.expExtra;
                        text += i + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "actors_expExtra.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Actor s in actors)
                    {
                        int i = s.expAcc;
                        text += i + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "actors_expAcc.txt", text, utf8WithoutBom);


                    text = "";
                    foreach (Actor s in actors)
                    {
                        String i = s.nickname;
                        text += i + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "actors_nickname.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Actor s in actors)
                    {
                        int i = s.class_id;
                        text += i + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "actors_classID.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Actor s in actors)
                    {
                        String n = s.attributes_rate;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "actors_attribute_rate.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Actor s in actors)
                    {
                        String n = s.states_rate;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "actors_states_rate.txt", text, utf8WithoutBom);

                }
                /*
                 *  Skills
                 */
                {
                    subDir = "";
                    if (useSubDir)
                    {
                        subDir = "skills/";
                        exists = System.IO.Directory.Exists("Text/" + subDir);

                        if (!exists)
                            System.IO.Directory.CreateDirectory("Text/" + subDir);
                    }

                    text = "";
                    foreach (Skill s in skills)
                    {
                        int sp = s.cost;
                        text += sp + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_cost.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Skill s in skills)
                    {
                        int n = s.sp_percent;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_cost_rate.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Skill s in skills)
                    {
                        String n = s.desc;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_desc.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Skill s in skills)
                    {
                        int n = s.scope;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_scope.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Skill s in skills)
                    {
                        int n = s.typeSk;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_type.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Skill s in skills)
                    {
                        int n = s.magical_rate;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_magical_rate.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Skill s in skills)
                    {
                        int n = s.physical_rate;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_physical_rate.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Skill s in skills)
                    {
                        String n = s.attributeEffects;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_attribute_effects.txt", text, utf8WithoutBom);


                    text = "";
                    foreach (Skill s in skills)
                    {
                        int n = s.power;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_power.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Skill s in skills)
                    {
                        int n = s.increaseHP;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_increaseHP.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Skill s in skills)
                    {
                        int n = s.increaseMP;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_increaseMP.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Skill s in skills)
                    {
                        int n = s.inflictStates;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_inflictStates.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Skill s in skills)
                    {
                        String n = s.states;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_states.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Skill s in skills)
                    {
                        int n = s.animation_id;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "skills_animation_id.txt", text, utf8WithoutBom);

                }
                /*
                *  Items
                */
                {
                    subDir = "";
                    if (useSubDir)
                    {
                        subDir = "items/";
                        exists = System.IO.Directory.Exists("Text/" + subDir);

                        if (!exists)
                            System.IO.Directory.CreateDirectory("Text/" + subDir);
                    }

                    text = "";
                    foreach (Item s in items)
                    {
                        String n = s.desc;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_description.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.type;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_type.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.hp_recover;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_hp_recover.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.hp_recover_rate;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_hp_recover_rate.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.sp_recover;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_sp_recover.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.sp_recover_rate;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_sp_recover_rate.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.entire_party;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_entire_party.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.ko_only;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_ko_only.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.cursed;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_cursed.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.switch_id;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_switch_id.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.animation_id;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_animation_id.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        String n = s.usable_in_battle;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_usableInBattle.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.entire_party;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_scope.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        String n = s.state_set;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_state_set.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.skill_id;
                        if (s.useSkill == false && s.type != 9 && s.type != 7)
                            n = 0;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_skill_id.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        String n = s.weapon_animation_id;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_weapon_animation_id.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.hp_up;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_hp_up.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.mp_up;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_mp_up.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.atk_up;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_atk_up.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.def_up;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_def_up.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.mag_up;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_mag_up.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.agi_up;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_agi_up.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.consumption_limit;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_consumption_limit.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.price;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_price.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        String n = s.attributes_rate;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_attributes_rate.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        String n = s.state_resist;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_state_resist.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.eq_atk_up;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_equipment_atk.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.eq_def_up;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_equipment_def.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.eq_mag_up;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_equipment_mag.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        int n = s.eq_agi_up;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_equipment_agi.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        String n = s.actorEquipable;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_actor_equipable.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Item s in items)
                    {
                        String n = s.classEquipable;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "items_class_equipable.txt", text, utf8WithoutBom);
                }
                /*
               *  States
               */
                {
                    subDir = "";
                    if (useSubDir)
                    {
                        subDir = "states/";
                        exists = System.IO.Directory.Exists("Text/" + subDir);

                        if (!exists)
                            System.IO.Directory.CreateDirectory("Text/" + subDir);
                    }

                    text = "";
                    foreach (State s in states)
                    {
                        String n = s.restricted_physical;
                        if (n == "T")
                        {
                            int i = s.physical_rate;
                            text += i + "\n";
                        }
                        else
                        {
                            text += 0 + "\n";
                        }
                    }
                    File.WriteAllText("Text/" + subDir + "state_restricted_physical.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (State s in states)
                    {
                        String n = s.restricted_magical;
                        if (n == "T")
                        {
                            int i = s.magical_rate;
                            text += i + "\n";
                        }
                        else
                        {
                            text += 0 + "\n";
                        }
                    }
                    File.WriteAllText("Text/" + subDir + "state_restricted_magical.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (State s in states)
                    {
                        int n = s.type;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "state_type.txt", text, utf8WithoutBom);


                    text = "";
                    foreach (State s in states)
                    {
                        String n = s.a_rate + " " + s.b_rate + " " + s.c_rate + " " + s.d_rate + " " + s.e_rate;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "state_rate.txt", text, utf8WithoutBom);
                }

                /*
              *  Attribute
              */
                {
                    subDir = "";
                    if (useSubDir)
                    {
                        subDir = "attributes/";
                        exists = System.IO.Directory.Exists("Text/" + subDir);

                        if (!exists)
                            System.IO.Directory.CreateDirectory("Text/" + subDir);
                    }

                    text = "";
                    foreach (Attribute s in attributes)
                    {
                        String n = s.a_rate + " " + s.b_rate + " " + s.c_rate + " " + s.d_rate + " " + s.e_rate;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "attribute_rate.txt", text, utf8WithoutBom);
                }

                /*
              *  Enemies
              */
                {
                    subDir = "";
                    if (useSubDir)
                    {
                        subDir = "enemies/";
                        exists = System.IO.Directory.Exists("Text/" + subDir);

                        if (!exists)
                            System.IO.Directory.CreateDirectory("Text/" + subDir);
                    }

                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        int n = s.gold;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "enemies_gold.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        String n = s.states_rate;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "enemies_state_rate.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        String n = s.attributes_rate;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "enemies_attribute_rate.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        String n = s.battler_name;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "enemies_battler_name.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        int n = s.loot_id;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "enemies_loot_id.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        int n = s.loot_rate;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "enemies_loot_rate.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        int n = s.animation_id;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "enemies_animation_id.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        int n = s.exp;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "enemies_exp.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        int n = s.maxHP;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "enemies_maxHP.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        int n = s.maxMP;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "enemies_maxMP.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        int n = s.atk;
                        text += n + "\n";
                    }

                    File.WriteAllText("Text/" + subDir + "enemies_atk.txt", text, utf8WithoutBom);
                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        int n = s.def;
                        text += n + "\n";
                    }

                    File.WriteAllText("Text/" + subDir + "enemies_def.txt", text, utf8WithoutBom);
                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        int n = s.mind;
                        text += n + "\n";
                    }

                    File.WriteAllText("Text/" + subDir + "enemies_mind.txt", text, utf8WithoutBom);
                    text = "";
                    foreach (Enemy s in enemies)
                    {
                        int n = s.agi;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "enemies_agi.txt", text, utf8WithoutBom);
                }
                /*
                 *  Terrains
                 */
                {
                    subDir = "";
                    if (useSubDir)
                    {
                        subDir = "terrains/";
                        exists = System.IO.Directory.Exists("Text/" + subDir);

                        if (!exists)
                            System.IO.Directory.CreateDirectory("Text/" + subDir);
                    }

                    text = "";
                    foreach (Terrain s in terrains)
                    {
                        String n = s.battleback_name;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "terrains_battleback.txt", text, utf8WithoutBom);
                }
                /*
                *  Troops
                */
                {
                    subDir = "";
                    if (useSubDir)
                    {
                        subDir = "troops/";
                        exists = System.IO.Directory.Exists("Text/" + subDir);

                        if (!exists)
                            System.IO.Directory.CreateDirectory("Text/" + subDir);
                    }

                    text = "";
                    foreach (Troop s in troops)
                    {
                        String n = s.name;
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "troops_name.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Troop s in troops)
                    {
                        String n = s.get_enemy_id();
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "troops_enemy_id.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Troop s in troops)
                    {
                        String n = s.get_enemy_x();
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "troops_enemy_x.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Troop s in troops)
                    {
                        String n = s.get_enemy_y();
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "troops_enemy_y.txt", text, utf8WithoutBom);

                    text = "";
                    foreach (Troop s in troops)
                    {
                        String n = s.get_enemy_invisible();
                        text += n + "\n";
                    }
                    File.WriteAllText("Text/" + subDir + "troops_enemy_invisible.txt", text, utf8WithoutBom);
                }
            }
        }
    }
}
