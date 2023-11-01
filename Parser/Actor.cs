using System;

namespace Parser
{
    class Actor
    {
        public int id;

        public String face_name;
        public int face_index;

        public String nickname;

        public int class_id;

        public int expBasic;
        public int expExtra;
        public int expAcc;

        public String attributes_rate;
        public String states_rate;

        public Actor(int i)
        {
            id = i;
        }
    }
}
