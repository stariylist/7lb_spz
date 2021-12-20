using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using SPZ_Lab7.Model;
using SPZ_Lab7.View;

namespace SPZ_Lab7
{
    public partial class Form1 : Form
    {
        SQLClass sQL = new SQLClass();
        public Form1()
        {
            InitializeComponent();
            dataGridView.Columns[0].HeaderText = "StudentID";
            dataGridView.Columns[1].HeaderText = "LastName";
            dataGridView.Columns[2].HeaderText = "FirstName";
            dataGridView.Columns[3].HeaderText = "GroupName";
            dataGridViewGroups.Columns[0].HeaderText = "GroupId";
            dataGridViewGroups.Columns[1].HeaderText = "GroupName";

            UpdateForm();
            UpdateGroups();
        }
        private void UpdateForm()
        {
            dataGridView.Rows.Clear();
            List<List<string>> lst = sQL.GetStudents();
            foreach (List<string> item in lst)
            {
                dataGridView.Rows.Add(item[0], item[1], item[2], item[3]);
            }
        }
        private void UpdateGroups()
        {
            dataGridViewGroups.Rows.Clear();
            List<List<string>>  lst = sQL.GetGroups();
            foreach (List<string> item in lst)
            {
                dataGridViewGroups.Rows.Add(item[0], item[1]);
            }
        }
        private void studentEditor_button_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell.ColumnIndex == 0)
            {
                string item = null;
                if (dataGridView.CurrentCell.Value != null)
                {
                    item = dataGridView.CurrentCell.Value.ToString();
                }
                StudentEditor studentEditor;
                if (item != null)
                {
                    studentEditor = new StudentEditor(sQL, item);
                }
                else studentEditor = new StudentEditor(sQL);
                studentEditor.ShowDialog();
                UpdateForm();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.CurrentCell.ColumnIndex == 0)
            { 
                string item = null;
            if (dataGridViewGroups.CurrentCell.Value != null)
            {
                item = dataGridViewGroups.CurrentCell.Value.ToString();
            }   
            GroupEditor groupEditor;
            if (item != null)
            {
                groupEditor = new GroupEditor(sQL, item);
            }
            else groupEditor = new GroupEditor(sQL);
            groupEditor.ShowDialog();
            UpdateGroups();
            UpdateForm();
            }
        }
    }
}


