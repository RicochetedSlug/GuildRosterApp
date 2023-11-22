using GuildRosterApp.Models;
using GuildRosterApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuildRosterApp
{


    public partial class FrmGuildRoster : Form
    {
        public List<Character> CharList { get; set; } //property

        public FrmGuildRoster()
        {
            InitializeComponent();
            CharList = new List<Character>();
            //listView1.FullRowSelect = true;
            setColumnHeaders();
        }

        private void setColumnHeaders()
        {
            listView1.Clear();
            listView1.ResetText();
            listView1.View = View.Details;

            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();
            ColumnHeader columnHeader5 = new ColumnHeader();

            columnHeader1.Text = "Member Name";
            columnHeader1.Width = (int)(listView1.Font.Size) * 10;   
            columnHeader1.TextAlign = HorizontalAlignment.Center;

            listView1.Columns.Add(columnHeader1);


            columnHeader2.Text = "Class";
            columnHeader2.Width = (int)(listView1.Font.Size) * 8;
            columnHeader2.TextAlign = HorizontalAlignment.Center;

            listView1.Columns.Add(columnHeader2);

            columnHeader3.Text = "Level";
            columnHeader3.Width = (int)(listView1.Font.Size) * 8;
            columnHeader3.TextAlign = HorizontalAlignment.Center;

            listView1.Columns.Add(columnHeader3);

            columnHeader4.Text = "Main Spec";
            columnHeader4.Width = (int)(listView1.Font.Size) * 8;
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add(columnHeader4);

            columnHeader5.Text = "Off Spec";
            columnHeader5.Width = (int)(listView1.Font.Size) * 8;
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add(columnHeader5);

        }

        public void updateListView()
        {
            setColumnHeaders();

            foreach (Character character in CharList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = character.Name;
                item.SubItems.Add(character.CharClass);
                item.SubItems.Add(character.Level + "");
                item.SubItems.Add(character.MainSpec);
                item.SubItems.Add(character.OffSpec); 
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Select();
            this.listView1.Focus();
            string name = this.listView1.FocusedItem.Text;

            if(name == null || name.Equals(""))
            {
                return;
            }

            

            foreach (Character character in CharList)
            {
                if (character.Name.Equals(name))
                {
                    //initialize the Edit Member Form
                    FrmCharacter form = new FrmCharacter(character);
                    form.Karachter = character;
                    form.CharList = CharList;

                    form.FormState = Validation.CHARACTER_READ_ONLY;

                    
                    form.setFormReadOnly();
                    form.Show();
                    this.Hide();
                    return;
                }
            }
            
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CharList == null)
            {
                CharList = new List<Character>();
            }

            FrmCharacter form = new FrmCharacter();
            form.CharList = new List<Character>();
            foreach (Character character in CharList)
            {
                form.CharList.Add(character);
            }
            form.FormState = Validation.CHARACTER_ADD;
            form.setFormEditMode();

            form.setupClassList();
            //form.setupMainSpecList(); these should be setup upon selection of Character class.
            //form.setupOffSpecList();

            form.Karachter = new Character();
            form.guildRoster = this;
            form.Show();
            this.Hide();
            
        }
    }
}
