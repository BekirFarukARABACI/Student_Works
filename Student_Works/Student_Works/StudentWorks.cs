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
    public partial class StudentWorks : Form
    {
        class DB
        {
            MySqlConnection connection;
            //Baglanti adında bir bağlantı oluşturdum

            public bool baglanti_kontrol()
            {
                try
                {
                    connection = new MySqlConnection("Server=localhost;Database=studentworks;Uid=root;Pwd='BeFAr.456852!;';");
                    connection.Open();
                    return true;
                    //Veritabanına bağlanırsa baglanti_kontrol fonksiyonu "true" değeri gönderecek
                }

                catch (Exception)
                {
                    return false;
                    //Veritabanına bağlanamazsa "false" değeri dönecek
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB _vt = new DB();

            if (_vt.baglanti_kontrol() == true)
            {
                label1.Text = "Bağlantı kuruldu.";
            }

            else
            {
                label1.Text = "Hata !!!";
            }
        }

        public StudentWorks()
        {
            InitializeComponent();
        }

       

        private void StudentAdd_Click(object sender, EventArgs e)
        {
            StudentAdd student = new StudentAdd();
            student.Show();
        }

        private void studentUpdate_Click(object sender, EventArgs e)
        {
            StudentUpdate student = new StudentUpdate();
            student.Show();
        }

        private void studentDelete_Click(object sender, EventArgs e)
        {
            StudentDelete student = new StudentDelete();
            student.Show();
        }

        private void StudentList_Click(object sender, EventArgs e)
        {
            StudentList student = new StudentList();
            student.Show();
        }
    }
}
