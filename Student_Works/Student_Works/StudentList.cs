using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Works
{
    public partial class StudentList : Form
    {

        public MySqlConnection connection;

        public StudentList()
        {
            InitializeComponent();
        }

        private void list_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=localhost;Database=studentworks;Uid=root;Pwd='BeFAr.456852!;';");
            connection.Open();


            try
            {

                // Öğrenci isimlerini çağır
                string studentName = getStudentName();
                string studentSurname = getStudentSurname();
                string studentNo = getStudentNo();


                // Label'a yazdır
                listName.Text = studentName;
                listSurname.Text = studentSurname;
                listNo.Text = studentNo;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }




        }

        private string getStudentName()
        {
            string query = "SELECT StudentsName FROM students";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    string ogrenciIsimleri = "\n";
                    while (reader.Read())
                    {
                        ogrenciIsimleri += reader["StudentsName"] + "\n";
                    }

                    return ogrenciIsimleri;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return string.Empty;
            }
        }


        private string getStudentSurname()
        {
            string query = "SELECT StudentsSurname FROM students";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    string studentSurname = "\n";
                    while (reader.Read())
                    {
                        studentSurname += reader["StudentsSurname"] + "\n";
                    }

                    return studentSurname;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return string.Empty;
            }
        }

        private string getStudentNo()
        {
            string query = "SELECT StudentNo FROM students";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    string studenetNo = "\n";
                    while (reader.Read())
                    {
                        studenetNo += reader["StudentNo"] + "\n";
                    }

                    return studenetNo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return string.Empty;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listSurname_Click(object sender, EventArgs e)
        {

        }
    }
}
