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
    public partial class StudentDelete : Form
    {
        String studentSchoolNumber;
        public MySqlConnection connection;

        public StudentDelete()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection("Server=localhost;Database=studentworks;Uid=root;Pwd='BeFAr.456852!;';");
            connection.Open();

            studentSchoolNumber = schoolNumberArea.Text;

            string query = $"DELETE FROM students WHERE studentNo = {studentSchoolNumber}";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                cmd.ExecuteNonQuery();
                label4.Text = "Öğrenci Silindi";
            }
            catch (Exception ex)
            {
                label4.Text = "Öğrenci Silinemedi " + ex.Message;

            }
            schoolNumberArea.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void schoolNumberArea_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
