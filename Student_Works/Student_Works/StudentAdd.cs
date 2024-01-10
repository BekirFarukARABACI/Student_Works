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
    public partial class StudentAdd : Form
    {
        String studentName;
        String studentSurname;
        String studentSchoolNumber;
        public MySqlConnection connection;



 

        public StudentAdd()
        {
            InitializeComponent();
        }



        private void SaveStudent_Click(object sender, EventArgs e)
        {
            

            connection = new MySqlConnection("Server=localhost;Database=studentworks;Uid=root;Pwd='BeFAr.456852!;';");
            connection.Open();

            studentSchoolNumber = schoolNumberArea.Text;
            studentName = nameArea.Text;
            studentSurname = surnameArea.Text;

            string query = $"INSERT INTO students (studentNo, StudentsName, StudentsSurname) VALUES ('{studentSchoolNumber}','{studentName}','{studentSurname}')";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                cmd.ExecuteNonQuery();
                label4.Text = "Öğrenci Eklendi";
            }
            catch (Exception ex)
            {
                label4.Text = "Öğrenci eklenemedi " + ex.Message;

            }

            nameArea.Text = "";
            surnameArea.Text = "";
            schoolNumberArea.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
