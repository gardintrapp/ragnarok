//Copyright (C) 2005, 2015  Oddbjørn Norstrand and Oddbjørn By.

//Author: Oddbjørn Norstrand <oddbjorn@norstrand.priv.no>, Oddbjørn By
//Maintainer: Oddbjørn Norstrand <oddbjorn@norstrand.priv.no>

//This file is part of Ragnarok.

//Ragnarok is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//Ragnarok is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with Ragnarok.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ragnarok
{
    public partial class frmRagnarok : Form
    {
        public frmRagnarok()
        {
            InitializeComponent();
        }

        private void frmRagnarok_Load(object sender, EventArgs e)
        {
            btnDay[0] = btnMon;
            btnDay[1] = btnTue;
            btnDay[2] = btnWed;
            btnDay[3] = btnThu;
            btnDay[4] = btnFri;
            btnDay[5] = btnSat;
            btnDay[6] = btnSun;

            //Read log
            txtLog.AppendText(File.ReadAllText(logfilepath));
        }

        private void tmrSec_Tick(object sender, EventArgs e)
        {
            time_sec++;
            lblTime.Text = time_sec.ToString(); 
        }

        private void newDate()
        {
            int year = 1;	//Random year
            int month = rnd.Next(1, 13);	//Random month

            int day = 1;
            int century;

            //Random year
            while (true)
            {
                //First select century
                century = rnd.Next(3);

                if (century == 0) //Between 1800 and 1899
                {
                    year = rnd.Next(1800, 1900);
                    if (chk1800.Checked) //See if century is selected
                        break;
                }
                else if (century == 1) //Between 1900 and 1999
                {
                    year = rnd.Next(1900, 2000);
                    if (chk1900.Checked) //See if century is selected
                        break;	
                }
                else if (century == 2) //Mellom 2000 og 2099
                {
                    year = rnd.Next(2000, 2100);
                    if (chk2000.Checked) //See if century is selected
                        break;
                }
            }
            //Random day, 28(29), 30 og 31 days in a month.
            //TODO: Handle leap year
            switch (month)
            {
                //31 days
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = rnd.Next(1, 32);
                    break;
                //30 days
                case 4:
                case 6:
                case 9:
                case 11:
                    day = rnd.Next(1, 31);
                    break;
                //28(29) days
                case 2:
                    day = rnd.Next(1, 29);
                    break;
            }

            //Create a date
            rnd_date = new DateTime(year, month, day);
            //Increase number of generated dates
            num_dates++;

            //Print the date
            lblYear.Text = rnd_date.Year.ToString();
            switch (rnd_date.Month)
            {
                case 1:
                    lblMonth.Text = "January";
                    break;
                case 2:
                    lblMonth.Text = "February";
                    break;
                case 3:
                    lblMonth.Text = "March";
                    break;
                case 4:
                    lblMonth.Text = "April";
                    break;
                case 5:
                    lblMonth.Text = "May";
                    break;
                case 6:
                    lblMonth.Text = "June";
                    break;
                case 7:
                    lblMonth.Text = "July";
                    break;
                case 8:
                    lblMonth.Text = "August";
                    break;
                case 9:
                    lblMonth.Text = "September";
                    break;
                case 10:
                    lblMonth.Text = "October";
                    break;
                case 11:
                    lblMonth.Text = "November";
                    break;
                case 12:
                    lblMonth.Text = "Desember";
                    break;
            }
            lblDay.Text = rnd_date.Day.ToString() + '.';

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            grpCenturies.Enabled = false;
            //Reset
            time_sec = 0;
            lblTime.Text = "0";
            num_dates = 0;
            num_correct = 0;
            //Change what UI elements are enabled
            btnStop.Enabled = true;
            grpDay.Enabled = true;
            tmrSec.Enabled = true; //Start the timer
            stopWatch.Reset();
            stopWatch.Start();
            update_res();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            tmrSec.Enabled = false;	//Stop the timer
            btnStop.Enabled = false;
            grpDay.Enabled = false;
            if (this.chkLog.Checked)
            {
                string logLine = System.String.Format("{0} 1800={1} 1900={2} 2000={3} \"{4:D} correct of {5:D} tries\" \"time used {6:00}:{7:00}:{8:00}:{9:00}.\" {10:P}",
                    DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                    chk1800.Checked.ToString(), chk1900.Checked.ToString(), chk2000.Checked.ToString(),
                    this.num_correct, this.num_dates - 1, ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds,
                    (double)this.num_correct / ((double)this.num_dates - 1));

                txtLog.AppendText(logLine + "\n");
                grpCenturies.Enabled = true;
                using (StreamWriter sw = File.AppendText(logfilepath))
                {
                    sw.WriteLine(logLine);
                }
            }
        }

        private void update_res()
        {
            //Update the result lavel, and generate a new date.
            lblRes.Text = num_correct.ToString() + " of " + num_dates.ToString();
            tmrBlink.Enabled = true;	//Start the timer that returns the collor of the buttons to normal.
            tmrBlink.Start();
            newDate();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            int correct_day = (int)(rnd_date.DayOfWeek + 6) % 7;
            int answered_day;
            int.TryParse(b.Tag.ToString(), out answered_day);
            Console.WriteLine("{2} corr: {0:D}, ans: {1:D}", correct_day, answered_day, rnd_date.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            if (answered_day == correct_day)
            {
                b.BackColor = System.Drawing.Color.Green;
                num_correct++;
            }
            else
            {
                b.BackColor = System.Drawing.Color.Red;
                correctGreen();
            }
            update_res();
        }

        private void correctGreen()
        {
            switch (rnd_date.DayOfWeek.ToString())
            {
                case ("Monday"):
                    btnMon.BackColor = System.Drawing.Color.Green;
                    break;
                case ("Tuesday"):
                    btnTue.BackColor = System.Drawing.Color.Green;
                    break;
                case ("Wednesday"):
                    btnWed.BackColor = System.Drawing.Color.Green;
                    break;
                case ("Thursday"):
                    btnThu.BackColor = System.Drawing.Color.Green;
                    break;
                case ("Friday"):
                    btnFri.BackColor = System.Drawing.Color.Green;
                    break;
                case ("Saturday"):
                    btnSat.BackColor = System.Drawing.Color.Green;
                    break;
                case ("Sunday"):
                    btnSun.BackColor = System.Drawing.Color.Green;
                    break;
            }
        }

        private void chkCent_CheckedChanged(object sender, EventArgs e)
        {
            //Se if no century is selected
            if (!chk1800.Checked && !chk1900.Checked && !chk2000.Checked)
            {
                MessageBox.Show("At least one century must be selected.", "Ragnarok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chk1800.Checked = true;
            }
        }

        private void tmrBlink_Tick(object sender, EventArgs e)
        {
            //Reset all the buttons to their default color
            for (int i = 0; i < 7; i++)
            {
                btnDay[i].BackColor = System.Drawing.Color.Transparent;
            }
            tmrBlink.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/gardintrapp/ragnarok");
        }
    }
}
