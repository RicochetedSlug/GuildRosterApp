
namespace GuildRosterApp
{
    public partial class FrmGuildRoster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            LabelRoster = new Label();
            BtnAdd = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.AutoArrange = false;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(13, 60);
            listView1.Name = "listView1";
            listView1.Size = new Size(662, 267);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Class";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Level";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Main Spec";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Off Spec";
            // 
            // LabelRoster
            // 
            LabelRoster.AutoSize = true;
            LabelRoster.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelRoster.Location = new Point(118, 9);
            LabelRoster.Name = "LabelRoster";
            LabelRoster.Size = new Size(400, 30);
            LabelRoster.TabIndex = 1;
            LabelRoster.Text = "Click on a character to view member form";
            // 
            // BtnAdd
            // 
            BtnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAdd.Location = new Point(704, 70);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(121, 53);
            BtnAdd.TabIndex = 2;
            BtnAdd.Text = "Add New Member";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // FrmGuildRoster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(855, 440);
            Controls.Add(BtnAdd);
            Controls.Add(LabelRoster);
            Controls.Add(listView1);
            Name = "FrmGuildRoster";
            Text = "Guild Roster";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private ListView listView1;
        private Label LabelRoster;
        private Button BtnAdd;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}