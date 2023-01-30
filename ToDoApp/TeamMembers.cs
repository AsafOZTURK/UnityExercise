using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
    class TeamMembers
    {
        public static Dictionary<int, string> members = new Dictionary<int, string>();
        public TeamMembers()
        {
            members.Add(12345, "xxx");
            members.Add(12346, "x");
            members.Add(12347, "xx");
            members.Add(12348, "xxxx");
            members.Add(12349, "xxxxx");
        }

        public enum importance
        {
            XS=1,S,M,L,XL
        }

        public static importance a;
    }
}