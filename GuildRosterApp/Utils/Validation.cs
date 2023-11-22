using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildRosterApp.Utils
{
    public class Validation
    {
        public const string NAME_EMPTY_MSG = "Please enter the name of the Member!";
        public const string NAME_DUPLICATE = "There is a duplicate name on the list.";
        public const string NAME_TOO_SHORT = "Please specify a name with 2 or more characters.";
        public const string NAME_HAS_NUM_OR_SPEC_CHAR = "Please specify a name with no numbers or special characters.";
        public const string CLASS_EMPTY_MSG = "Please specify the class of the Member!";
        public const string LEVEL_INCORRECT = "Please specify a number between 1 to 60.";
        public const string SPEC_IDENTICAL = "Please specify a different spec for main spec and off-spec.";
        public const string MAIN_SPEC_EMPTY = "Please specify a main spec.";

        //Character form display status
        public const string CHARACTER_ADD = "Add";
        public const string CHARACTER_EDIT = "Edit";
        public const string CHARACTER_DELETE = "Delete";
        public const string CHARACTER_READ_ONLY = "ReadOnly";

    }
}
