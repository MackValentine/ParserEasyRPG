using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    class State
    {
        public int id;

        public String restricted_magical;
        public int magical_rate;

        public String restricted_physical;
        public int physical_rate;

        public int type;

        public int a_rate;
        public int b_rate;
        public int c_rate;
        public int d_rate;
        public int e_rate;

        public State(int i)
        {
            id = i;
        }
    }
}
