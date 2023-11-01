using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    class Troop
    {
        public int id;

        public String name;
        public int[] enemy_id;
        public int[] enemy_x;
        public int[] enemy_y;
        public String[] enemy_invisible;


        public Troop(int i)
        {
            id = i;
            enemy_id = new int[8];
            enemy_x = new int[8];
            enemy_y = new int[8];
            enemy_invisible = new string[8];
        }

        public string get_enemy_id()
        {
            String s = "";
            foreach (int e in enemy_id)
            {
                if (e != 0)
                    s += e + " ";
            }
            return s;
        }
        public string get_enemy_x()
        {
            String s = "";
            foreach (int e in enemy_x)
            {
                if (e != 0)
                    s += e + " ";
            }
            return s;
        }
        public string get_enemy_y()
        {
            String s = "";
            foreach (int e in enemy_y)
            {
                if (e != 0)
                    s += e + " ";
            }
            return s;
        }
        public string get_enemy_invisible()
        {
            String s = "";
            foreach (String e in enemy_invisible)
            {
                s += e + " ";
            }
            return s;
        }
    }
}
