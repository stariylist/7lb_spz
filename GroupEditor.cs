using System;
using System.Windows.Forms;
using SPZ_Lab7.Model;

namespace SPZ_Lab7.View
{
    public partial class GroupEditor : Form
    {
        string idGroup;
        SQLClass sQL;
        public GroupEditor()
        {
            InitializeComponent();
        }
        public GroupEditor(SQLClass sQL)
        {
            InitializeComponent();
            this.sQL = sQL;
        }
        public GroupEditor(SQLClass sQL, string id)
        {
            InitializeComponent();
            idGroup = id;
            group_textBox.Text = sQL.GetGroupName(idGroup);
            this.sQL = sQL;
        }
        private void deleteGroup_button_Click(object sender, EventArgs e)
        { 
            if(idGroup !=null)
            { 
            sQL.DeleteGroup(idGroup);
            this.Close();
            }
        }

        private void rename_button_Click(object sender, EventArgs e)
        {
            if (idGroup != null)
            {
                if (!String.IsNullOrEmpty(newGroup_textBox.Text))
                    sQL.UpdateGroupName(newGroup_textBox.Text, idGroup);
            }
        }
        private void addGroup_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(newGroup_textBox.Text))
                sQL.AddGroup(newGroup_textBox.Text);
        }
    }
}
