using GuildRosterApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GuildRosterApp.Models
{
    public class Character
    {
        //private int id { get; set; }  
        public string Name { get; set; } //this serves as the unique id for the Character
        public string CharClass { get; set; }
        public int Level { get; set; }
        public string MainSpec { get; set; }
        public string OffSpec { get; set; }

        public Character(string name, string charClass, int level, string mainSpec, string offSpec)
        {
            this.Name = name;
            this.CharClass = charClass;
            this.Level = level;
            this.MainSpec = mainSpec;
            this.OffSpec = offSpec;
        }

        public Character() 
        {
            this.Name = "";
            this.CharClass = "";
            this.Level = 0;
            this.MainSpec = "";
            this.OffSpec = "";
        }

    }
}
