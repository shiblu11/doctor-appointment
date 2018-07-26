using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoctorAppoinment
{
    public partial class doctorInfo : Form
    {
        public doctorInfo()
        {
            InitializeComponent();
        }

        private void doctorInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cns = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\DoctorAppoinment\DoctorAppoinment\Doctor.mdf;Integrated Security=True";

            SqlConnection cn1 = new SqlConnection(cns);
            cn1.Open();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO doctorInfo (id,name,sex,qualification,designation,department,mail,contact,contactserial) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "', '" + comboBox1.Text + "','" + textBox4.Text + "', '" + textBox5.Text + "', '" + comboBox2.Text + "', '" + textBox6.Text + "', '" + textBox3.Text + "', '" + textBox7.Text + "')", cn1);


            try
            {
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Successfully Saved");
            }
            catch
            {
                //Error when save data

                MessageBox.Show("Error to save on database");
                cn1.Close();


            }
        }
    }
}
