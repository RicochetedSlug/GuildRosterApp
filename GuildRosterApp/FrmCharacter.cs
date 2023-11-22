using GuildRosterApp.Utils;
using GuildRosterApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Reflection.Emit;

namespace GuildRosterApp
{
    public partial class FrmCharacter : Form
    {
        public List<Character> CharList { get; set; }
        public Character Karachter { get; set; }
        public string FormState { get; set; }

        public FrmGuildRoster guildRoster { get; set; }

        public FrmCharacter()
        {
            InitializeComponent();
            CharList = new List<Character>();
            Karachter = new Character();
            FormState = "";
            guildRoster = new FrmGuildRoster();
        }

        public FrmCharacter(Character character)
        {
            InitializeComponent();
            CharList = new List<Character>();
            Karachter = character;
            FormState = "";
            guildRoster = new FrmGuildRoster();

            txtName.Text = character.Name;
            txtLevel.Text = character.Level + "";
            comboClass.Text = character.CharClass;
            comboMainSpec.Text = character.MainSpec;
            comboOffSpec.Text = character.OffSpec;
        }

        private void AddCharacterFrm_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        public void setupClassList()
        {
            List<string> classList = new List<string>();
            classList.Add(CharClass.PRIEST);
            classList.Add(CharClass.WARRIOR);
            classList.Add(CharClass.MAGE);

            foreach (string klass in classList)
            {
                //ListViewItem item = new ListViewItem(klass);
                comboClass.Items.Add(klass);
            }
        }

        public void setupMainSpecList()
        {
            CharSpec spec = new CharSpec();
            List<string> mainSpecList = new List<string>();
            comboMainSpec.Items.Clear();



            if (comboClass.SelectedText.Equals(CharClass.PRIEST))
            {
                mainSpecList.AddRange(spec.getPriestSpecList());
            }
            else if (comboClass.SelectedText.Equals(CharClass.WARRIOR))
            {
                mainSpecList.AddRange(spec.getWarriorSpecList());
            }
            else if (comboClass.SelectedText.Equals(CharClass.MAGE))
            {
                mainSpecList.AddRange(spec.getMageSpecList());
            }

            foreach (string mainspec in mainSpecList)
            {
                comboMainSpec.Items.Add(mainspec);
            }

        }

        public void setupOffSpecList()
        {
            CharSpec spec = new CharSpec();
            List<string> offSpecList = new List<string>();
            comboOffSpec.Items.Clear();


            if (comboClass.SelectedText.Equals(CharClass.PRIEST))
            {
                offSpecList.AddRange(spec.getPriestSpecList());
            }
            else if (comboClass.SelectedText.Equals(CharClass.WARRIOR))
            {
                offSpecList.AddRange(spec.getWarriorSpecList());
            }
            else if (comboClass.SelectedText.Equals(CharClass.MAGE))
            {
                offSpecList.AddRange(spec.getMageSpecList());
            }

            foreach (string offspec in offSpecList)
            {
                comboOffSpec.Items.Add(offspec);
            }
        }

        public void setFormReadOnly()
        {
            txtName.ReadOnly = true;
            comboClass.Enabled = false;
            txtLevel.ReadOnly = true;
            comboMainSpec.Enabled = false;
            comboOffSpec.Enabled = false;

            btnEdit.Enabled = true;
            btnEdit.Text = "Edit";

            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnShowList.Enabled = true;

        }

        public void setFormEditMode()
        {
            txtName.ReadOnly = false;
            comboClass.Enabled = true;
            txtLevel.ReadOnly = false;
            comboMainSpec.Enabled = true;
            comboOffSpec.Enabled = true;

            btnEdit.Enabled = true;
            btnEdit.Text = "Cancel";
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnShowList.Enabled = false;

        }

        private string validateInput() //returns an error message if any is found.
        {
            string errorMsg = "";

            string name = txtName.Text;
            errorMsg = validateName(name);
            if (errorMsg.Length > 0)
            {
                showErrorMsg(errorMsg);
                return errorMsg;
            }

            string klass = comboClass.Text;
            errorMsg = validateClass(klass);
            if (errorMsg.Length > 0)
            {
                showErrorMsg(errorMsg);
                return errorMsg;
            }

            string level = txtLevel.Text;
            errorMsg = validateLevel(level);
            if (errorMsg.Length > 0)
            {
                showErrorMsg(errorMsg);
                return errorMsg;
            }

            string mainSpec = comboMainSpec.Text;
            errorMsg = validateMainSpec(mainSpec);
            if (errorMsg.Length > 0)
            {
                showErrorMsg(errorMsg);
                return errorMsg;
            }

            string offSpec = comboOffSpec.Text;
            errorMsg = validateOffSpec(mainSpec, offSpec);
            if (errorMsg.Length > 0)
            {
                showErrorMsg(errorMsg);
                return errorMsg;
            }

            return errorMsg;

        }

        private void showErrorMsg(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string validateName(string name)
        {
            if (name == null || name.Length == 0)
            {
                return Validation.NAME_EMPTY_MSG;
            }
            else if (!Regex.IsMatch(name, @"^[a-z,A-Z]*$"))
            {
                return Validation.NAME_HAS_NUM_OR_SPEC_CHAR;
            }
            else if (name.Length < 2)
            {
                return Validation.NAME_TOO_SHORT;
            }
            else
            {
                return "";
            }

        }

        private string validateClass(string klass)
        {
            if (klass.Length == 0)
            {
                return Validation.CLASS_EMPTY_MSG;
            }
            return "";
        }

        private string validateLevel(string level)
        {
            if (level == null || level.Length == 0)  //check if input is empty
            {
                return Validation.LEVEL_INCORRECT;
            }
            else if (!Regex.IsMatch(level, @"^[0-9]*$"))  //check if input is a number
            {
                return Validation.LEVEL_INCORRECT;
            }
            else if (!(Int32.Parse(level) > 0 && Int32.Parse(level) <= 60)) //check if input is within range
            {
                return Validation.LEVEL_INCORRECT;
            }
            return "";
        }

        private string validateMainSpec(string spec)
        {
            if (spec == null || spec.Length == 0)
            {
                return Validation.MAIN_SPEC_EMPTY;
            }
            return "";
        }

        private string validateOffSpec(string mainSpec, string offSpec)
        {
            if (mainSpec.Equals(offSpec))
            {
                return Validation.SPEC_IDENTICAL;
            }
            return "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (FormState.Equals(Validation.CHARACTER_READ_ONLY))
            {
                setFormEditMode();
                FormState = Validation.CHARACTER_EDIT;
               /* this.comboClass.Focus();
                string klass = this.comboClass.Text;*/
                setupClassList();
               /* this.comboClass.Text = klass;*/

                setupMainSpecList();
                setupOffSpecList();

            }
            else
            {
                setFormReadOnly();
                FormState = Validation.CHARACTER_READ_ONLY;
            }
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            FrmGuildRoster form = guildRoster;
            
            form.CharList = CharList;
            form.Show();
            form.updateListView();
            this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String errorMsg = validateInput();
            if (!errorMsg.Equals(""))
            {
                showErrorMsg(errorMsg);
                return;
            }

            if (FormState.Equals(Validation.CHARACTER_EDIT))
            {
                //hold values in temp Character so it doesn't mess up List values
                //before passing validation!
                Character tempChar = new Character();

                tempChar.Name = txtName.Text;
                tempChar.CharClass = comboClass.Text;
                tempChar.Level = Int32.Parse(txtLevel.Text);
                tempChar.MainSpec = comboMainSpec.Text;
                tempChar.OffSpec = comboOffSpec.Text;


                string errorMsg2 = validateDuplicateCharacter(tempChar);

                if (!errorMsg2.Equals(""))
                {
                    showErrorMsg(errorMsg2);
                    return;
                }

                Karachter.Name = txtName.Text;
                Karachter.CharClass = comboClass.Text;
                Karachter.Level = Int32.Parse(txtLevel.Text);
                Karachter.MainSpec = comboMainSpec.Text;
                Karachter.OffSpec = comboOffSpec.Text;

                setFormReadOnly();
                FormState = Validation.CHARACTER_READ_ONLY;
                return;

            }
            else if (FormState.Equals(Validation.CHARACTER_ADD))
            {
                //add the selected Character
                Karachter = new Character();
                Karachter.Name = txtName.Text;

                //comboClass.Focus();
                Karachter.CharClass = comboClass.Text;  
                //was comboClass.SelectedText before but this is better since no need to set Focus()

                Karachter.Level = Int32.Parse(txtLevel.Text);

                //comboMainSpec.Focus();
                Karachter.MainSpec = comboMainSpec.Text;

                //comboOffSpec.Focus(); 
                Karachter.OffSpec = comboOffSpec.Text;

                string errorMsg2 = validateDuplicateCharacter(Karachter);

                if (!errorMsg2.Equals(""))
                {
                    showErrorMsg(errorMsg);
                    return;
                }

                CharList.Add(Karachter);
                setFormReadOnly();
                FormState = Validation.CHARACTER_READ_ONLY;
            }
        }

        private string validateDuplicateCharacter(Character kar)
        {
            string errorMsg = "";

            foreach (Character c in CharList)
            {
                if (c.Name.Equals(kar.Name))
                {
                    return Validation.NAME_DUPLICATE;
                }
            }

            return errorMsg;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the member?", "Delete Member",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                string name = Karachter.Name;
                foreach (Character c in CharList)
                {
                    if (c.Name.Equals(txtName.Text))
                    {
                        CharList.Remove(c);
                        setFormReadOnly();
                        FormState = Validation.CHARACTER_READ_ONLY;
                        this.Close();
                        FrmGuildRoster form = new FrmGuildRoster();
                        form.CharList = CharList;
                        form.updateListView();
                        return;
                    }
                }
            }
        }



        private void comboClass_SelectionChangeCommit(object sender, EventArgs e)
        {
            setupMainSpecList();
            setupOffSpecList();
        }

        private void comboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
