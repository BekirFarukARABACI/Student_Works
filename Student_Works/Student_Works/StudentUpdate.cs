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
    public partial class StudentUpdate : Form
    {
        String studentName;
        String studentSurname;
        String studentSchoolNumber;
        public MySqlConnection connection;


        public StudentUpdate()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=localhost;Database=studentworks;Uid=root;Pwd='BeFAr.456852!;';");
            connection.Open();

            studentSchoolNumber = schoolNumberArea.Text;
            studentName = nameArea.Text;
            studentSurname = surnameArea.Text;

            string query = $"UPDATE students SET StudentsName = '{studentName}', StudentsSurname = '{studentSurname}' WHERE StudentNo = {studentSchoolNumber}";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                cmd.ExecuteNonQuery();
                label4.Text = "Öğrenci Düzenlendi";
            }
            catch (Exception ex)
            {
                label4.Text = "Öğrenci Düzenlenemedi " + ex.Message;

            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
