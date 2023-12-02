using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    class EnemyAction
    {
        public int id;

        public int condition;
        public int priotity;
        public int switch_id;
        public int parameter1;
        public int parameter2;
        public int switchOn;
        public int switchOff;
        public int kind;
        public int basic;
        public int skill_id;
        public int enemy_id;

        public EnemyAction(int i)
        {
            id = i;
        }
    }
}
