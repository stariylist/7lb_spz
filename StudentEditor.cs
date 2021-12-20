using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZ_Lab7.Model;
using MySql.Data.MySqlClient;

namespace SPZ_Lab7.View
{
    public partial class StudentEditor : Form
    {
        SQLClass sQL;
        int id;
        List<string> Student;
        public StudentEditor()
        {
            InitializeComponent();
        }
        public StudentEditor(SQLClass sQL)
        {
            InitializeComponent();
            var groupList = sQL.GetGroups();
            foreach (List<string> items in groupList)
            {
                group_comboBox.Items.Add(items[1]);
            }
            this.sQL = sQL;
        }
        public StudentEditor(SQLClass sQL, string item)
        {
            InitializeComponent();
            var groupList = sQL.GetGroups();
            foreach(List<string> items in groupList)
            {
                group_comboBox.Items.Add(items[1]);
            }
            this.sQL = sQL;
            id = int.Parse(item);
            Student = sQL.GetOneStudent(id);
            lastname_textBox.Text = Student[1];
            firstname_textBox.Text = Student[2];
            group_comboBox.SelectedItem = Student[3];
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if(Student != null)
            { 
                if (Student[1] != lastname_textBox.Text && !String.IsNullOrEmpty(lastname_textBox.Text))
            {
                sQL.UpdateStudentLastName(lastname_textBox.Text, int.Parse(Student[0]));
            }
            if (Student[2] != firstname_textBox.Text && !String.IsNullOrEmpty(firstname_textBox.Text))
            {
                sQL.UpdateStudentName(firstname_textBox.Text, int.Parse(Student[0]));
            }
            if (Student[3] != group_comboBox.SelectedItem.ToString())
            {
                sQL.UpdateStudentGroup(group_comboBox.SelectedItem.ToString(), int.Parse(Student[0]));
            }
            }
            this.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(lastname_textBox.Text) && !String.IsNullOrEmpty(firstname_textBox.Text))
            {
                sQL.AddStudent(lastname_textBox.Text, firstname_textBox.Text, group_comboBox.SelectedItem.ToString());
                this.Close();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lastname_textBox.Text) && !String.IsNullOrEmpty(firstname_textBox.Text))
            {
                sQL.DeleteStudent(Student[0]);
                this.Close();
            }
        }
    }
}
