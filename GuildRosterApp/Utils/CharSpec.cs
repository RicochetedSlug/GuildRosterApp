using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildRosterApp.Utils
{
    public class CharSpec
    {
        private string [] PriestSpec = ["Holy", "Discipline", "Shadow"];
        private List<string> PriestSpecList = new List<string>();

        private string[] WarriorSpec = ["Deep Prot", "Fury Prot", "Fury"];
        private List<string> WarriorSpecList = new List<string>();

        private string[] MageSpec = ["Fire", "Frost", "Arcane"];
        private List<string> MageSpecList = new List<string>();

        public List<string> getPriestSpecList()
        {
            PriestSpecList.AddRange(PriestSpec);
            return PriestSpecList;
        }

        public List<string> getWarriorSpecList()
        {
            WarriorSpecList.AddRange (WarriorSpec);
            return WarriorSpecList;
        }

        public List<string> getMageSpecList()
        {
            MageSpecList.AddRange (MageSpec);
            return MageSpecList;
        }
        
    }
}
