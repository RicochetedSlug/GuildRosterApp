using GuildRosterApp.Models;

namespace GuildRosterApp
{
    public partial class FrmCharacter
    {
        private List<Character> charList { get; set; }
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
            LblName = new Label();
            txtName = new TextBox();
            LblClass = new Label();
            comboClass = new ComboBox();
            LblLevel = new Label();
            txtLevel = new TextBox();
            comboMainSpec = new ComboBox();
            LblMainSpec = new Label();
            LblOffSpec = new Label();
            comboOffSpec = new ComboBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnShowList = new Button();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblName.Location = new Point(63, 49);
            LblName.Name = "LblName";
            LblName.Size = new Size(62, 25);
            LblName.TabIndex = 0;
            LblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(201, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(120, 23);
            txtName.TabIndex = 1;
            // 
            // LblClass
            // 
            LblClass.AutoSize = true;
            LblClass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblClass.Location = new Point(63, 79);
            LblClass.Name = "LblClass";
            LblClass.Size = new Size(55, 25);
            LblClass.TabIndex = 2;
            LblClass.Text = "Class";
            // 
            // comboClass
            // 
            comboClass.FormattingEnabled = true;
            comboClass.Location = new Point(200, 81);
            comboClass.Name = "comboClass";
            comboClass.Size = new Size(121, 23);
            comboClass.TabIndex = 3;
            comboClass.SelectedIndexChanged += comboClass_SelectedIndexChanged;
            comboClass.SelectionChangeCommitted += comboClass_SelectionChangeCommit;
            // 
            // LblLevel
            // 
            LblLevel.AutoSize = true;
            LblLevel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblLevel.Location = new Point(63, 113);
            LblLevel.Name = "LblLevel";
            LblLevel.Size = new Size(55, 25);
            LblLevel.TabIndex = 4;
            LblLevel.Text = "Level";
            // 
            // txtLevel
            // 
            txtLevel.Location = new Point(200, 113);
            txtLevel.Name = "txtLevel";
            txtLevel.Size = new Size(60, 23);
            txtLevel.TabIndex = 5;
            // 
            // comboMainSpec
            // 
            comboMainSpec.FormattingEnabled = true;
            comboMainSpec.Location = new Point(200, 151);
            comboMainSpec.Name = "comboMainSpec";
            comboMainSpec.Size = new Size(121, 23);
            comboMainSpec.TabIndex = 6;
            // 
            // LblMainSpec
            // 
            LblMainSpec.AutoSize = true;
            LblMainSpec.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblMainSpec.Location = new Point(63, 151);
            LblMainSpec.Name = "LblMainSpec";
            LblMainSpec.Size = new Size(100, 25);
            LblMainSpec.TabIndex = 7;
            LblMainSpec.Text = "Main Spec";
            // 
            // LblOffSpec
            // 
            LblOffSpec.AutoSize = true;
            LblOffSpec.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblOffSpec.Location = new Point(63, 189);
            LblOffSpec.Name = "LblOffSpec";
            LblOffSpec.Size = new Size(83, 25);
            LblOffSpec.TabIndex = 8;
            LblOffSpec.Text = "Off Spec";
            // 
            // comboOffSpec
            // 
            comboOffSpec.FormattingEnabled = true;
            comboOffSpec.Location = new Point(200, 191);
            comboOffSpec.Name = "comboOffSpec";
            comboOffSpec.Size = new Size(121, 23);
            comboOffSpec.TabIndex = 9;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ButtonShadow;
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(387, 49);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 35);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ButtonShadow;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(387, 103);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 35);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ButtonShadow;
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(387, 160);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 35);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnShowList
            // 
            btnShowList.BackColor = SystemColors.ButtonShadow;
            btnShowList.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowList.Location = new Point(150, 254);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(208, 35);
            btnShowList.TabIndex = 14;
            btnShowList.Text = "Show Roster";
            btnShowList.UseVisualStyleBackColor = false;
            btnShowList.Click += btnShowList_Click;
            // 
            // FrmCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(575, 319);
            Controls.Add(btnShowList);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(comboOffSpec);
            Controls.Add(LblOffSpec);
            Controls.Add(LblMainSpec);
            Controls.Add(comboMainSpec);
            Controls.Add(txtLevel);
            Controls.Add(LblLevel);
            Controls.Add(comboClass);
            Controls.Add(LblClass);
            Controls.Add(txtName);
            Controls.Add(LblName);
            Name = "FrmCharacter";
            Text = "Add Member";
            Load += AddCharacterFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox txtName;
        private Label LblClass;
        private ComboBox comboClass;
        private Label LblLevel;
        private TextBox txtLevel;
        private ComboBox comboMainSpec;
        private Label LblMainSpec;
        private Label LblOffSpec;
        private ComboBox comboOffSpec;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnShowList;
    }
}