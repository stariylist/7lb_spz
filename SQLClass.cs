using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SPZ_Lab7.Model
{
    public class SQLClass
    {
        private MySqlConnection connection = new MySqlConnection();
        Random random = new Random();
        public SQLClass()
        {
            connection.ConnectionString = "server=localhost;port=3306;username=root;database=lb7_spz;SSL Mode=None";
            connection.Open();  
        }
        public void AddStudent(string lastname, string firstname, string gropname)
        {
            int id = random.Next(0,10000);
            Query("INSERT INTO students(`id_student`, `last_name`, `first_name`, `id_group`) " +
                "VALUES(\'"+ id + "\', \'" + lastname + "\', \'" + firstname+ "\', (SELECT id_group FROM groups " +
                                                                                "WHERE groups.group_name = \'" + gropname + "\'))");
        }
        public void AddGroup(string groupname)
        {
            int id = random.Next(0, 10000);
            Query("INSERT INTO groups(`id_group`, `group_name`) " +
               "VALUES(\'" + id + "\', \'" + groupname + "\');");
        }
        public List<List<string>> GetStudents()
        {
            MySqlCommand command = new MySqlCommand("SELECT s.id_student, s.last_name, s.first_name, g.group_name " +
                "FROM students s INNER JOIN groups g ON s.id_group = g.id_group", connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<List<string>> result = new List<List<string>>();
            while (reader.Read())
            {
                result.Add(new List<string> { reader.GetString("id_student"), reader.GetString("last_name"),
                    reader.GetString("first_name"), reader.GetString("group_name")});
            }
            reader.Close();
            return result;
        }
        public List<List<string>> GetGroups()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM groups", connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<List<string>> result = new List<List<string>>();
            while (reader.Read())
            {
                result.Add(new List<string> { reader.GetString("id_group"), reader.GetString("group_name") });
            }
            reader.Close();
            return result;
        }
        public List<string> GetOneStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("SELECT a.id_student, a.last_name, a.first_name, b.group_name " +
                "FROM students a INNER JOIN groups b ON a.id_group = b.id_group " +
                "WHERE a.id_student = \'" + id + "\'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string> result = new List<string>();
            while (reader.Read())
            {
                result.Add(reader.GetString("id_student"));
                result.Add(reader.GetString("last_name"));
                result.Add(reader.GetString("first_name"));
                result.Add(reader.GetString("group_name"));
            }
            reader.Close();
            return result;
        }
        public void UpdateStudentName(string name, int id)
        {
            Query("UPDATE students SET first_name = \'" + name + "\'" +
                " WHERE id_student = \'" + id + "\'");
        }
        public void UpdateStudentLastName(string lastname, int id)
        {
            Query("UPDATE students SET last_name = \'" + lastname + "\'" +
                " WHERE id_student = \'" + id + "\'");
        }
        public void UpdateStudentGroup(string groupName, int id)
        {
            string idGroup = GetGroupId(groupName);
            Query("UPDATE students SET id_group = \'" + idGroup + "\'" +
                " WHERE id_student = \'" + id + "\'");
        }
        public void UpdateGroupName(string groupName, string id)
        {
           // string idGroup = GetGroupId(groupName);
            Query("UPDATE groups SET group_name = \'" + groupName + "\'" +
                " WHERE id_group = \'" + id + "\'");
        }
        public void DeleteStudent(string id)
        {
            Query("DELETE FROM students WHERE id_student = " + id);
        }
        public void DeleteGroup(string id)
        {
            Query("DELETE FROM students WHERE id_group = " + id);
            Query("DELETE FROM groups WHERE id_group = " + id);
        }
        public string GetGroupName(string id)
        {
            MySqlCommand command = new MySqlCommand("SELECT group_name FROM groups WHERE id_group  = \'" + id + "\'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            string result = null;
            while (reader.Read())
            {
                result = reader.GetString("group_name");
            }
            reader.Close();
            return result;
        }
        public string GetGroupId(string groupName)
        {
            MySqlCommand command = new MySqlCommand("SELECT id_group FROM groups WHERE group_name = \'" + groupName + "\'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            string result = null;
            while (reader.Read())
            {
                result = reader.GetString("id_group");
            }
            reader.Close();
            return result;
        }
        void Query(string cmd)
        {
            MySqlCommand command = new MySqlCommand(cmd, connection);
            command.ExecuteNonQuery();
        }



        public void Close()
        {
            connection.Close();
        }

    }
}
