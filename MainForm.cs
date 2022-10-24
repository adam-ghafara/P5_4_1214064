using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_1214064
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            var Nama = fillName;
            var Kelamin = fillGender;
            var kelahiran = fillBirth;
            string kelas = "";
            string jadwal = "";

            if (Sch1.Checked)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (Sch2.Checked)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (Sch3.Checked)
            {
                jadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }
            else if (Sch4.Checked)
            {
                jadwal = "Minggu, 14.00 - 17.00";
            }

            if (cbBiola.Checked)
            {
                kelas = kelas + "Biola, ";
            }
            if (cbDrum.Checked)
            {
                kelas = kelas + "Drum, ";
            }
            if (cbGitar.Checked)
            {
                kelas = kelas + "Gitar, ";
            }
            if (cbKmp.Checked)
            {
                kelas = kelas + "Komposer, ";
            }
            if (cbKdk.Checked)
            {
                kelas = kelas + "Konduktor, ";
            }
            if (cbPiano.Checked)
            {
                kelas = kelas + "Piano, ";
            }
            if (cbSax.Checked)
            {
                kelas = kelas + "Saxophone, ";
            }
            if (cbVokal.Checked)
            {
                kelas = kelas + "Vokal, ";
            }
        }

        private void btDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
