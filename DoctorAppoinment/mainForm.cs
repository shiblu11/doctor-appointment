using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoctorAppoinment
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prescriptionInfo p = new prescriptionInfo();
            p.Show();
        }

        private void addScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctoeSchedule d = new doctoeSchedule();
            d.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doctorInfo d = new doctorInfo();
            d.Show();
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            patientinfo p = new patientinfo();
            p.Show();
        }
    }
}
