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
using System.Diagnostics;
using System.Windows.Forms;
namespace ragnarok
{
    partial class frmRagnarok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tmrBlink = new System.Windows.Forms.Timer(this.components);
            this.btnSat = new System.Windows.Forms.Button();
            this.btnFri = new System.Windows.Forms.Button();
            this.btnThu = new System.Windows.Forms.Button();
            this.btnWed = new System.Windows.Forms.Button();
            this.btnTue = new System.Windows.Forms.Button();
            this.btnMon = new System.Windows.Forms.Button();
            this.chk2000 = new System.Windows.Forms.CheckBox();
            this.chk1900 = new System.Windows.Forms.CheckBox();
            this.btnSun = new System.Windows.Forms.Button();
            this.chk1800 = new System.Windows.Forms.CheckBox();
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.grpDay = new System.Windows.Forms.GroupBox();
            this.grpCenturies = new System.Windows.Forms.GroupBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblDay = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrSec = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.grpDay.SuspendLayout();
            this.grpCenturies.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("DejaVu Sans Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(8, 331);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(633, 179);
            this.txtLog.TabIndex = 35;
            this.txtLog.WordWrap = false;
            // 
            // tmrBlink
            // 
            this.tmrBlink.Interval = 1000;
            this.tmrBlink.Tick += new System.EventHandler(this.tmrBlink_Tick);
            // 
            // btnSat
            // 
            this.btnSat.Location = new System.Drawing.Point(23, 209);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(90, 26);
            this.btnSat.TabIndex = 14;
            this.btnSat.Tag = "5";
            this.btnSat.Text = "&Saturday";
            this.btnSat.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnFri
            // 
            this.btnFri.Location = new System.Drawing.Point(23, 172);
            this.btnFri.Name = "btnFri";
            this.btnFri.Size = new System.Drawing.Size(90, 26);
            this.btnFri.TabIndex = 13;
            this.btnFri.Tag = "4";
            this.btnFri.Text = "&Friday";
            this.btnFri.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnThu
            // 
            this.btnThu.Location = new System.Drawing.Point(23, 135);
            this.btnThu.Name = "btnThu";
            this.btnThu.Size = new System.Drawing.Size(90, 27);
            this.btnThu.TabIndex = 12;
            this.btnThu.Tag = "3";
            this.btnThu.Text = "T&hursday";
            this.btnThu.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnWed
            // 
            this.btnWed.Location = new System.Drawing.Point(23, 98);
            this.btnWed.Name = "btnWed";
            this.btnWed.Size = new System.Drawing.Size(90, 27);
            this.btnWed.TabIndex = 11;
            this.btnWed.Tag = "2";
            this.btnWed.Text = "&Wednesday";
            this.btnWed.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnTue
            // 
            this.btnTue.Location = new System.Drawing.Point(23, 61);
            this.btnTue.Name = "btnTue";
            this.btnTue.Size = new System.Drawing.Size(90, 27);
            this.btnTue.TabIndex = 10;
            this.btnTue.Tag = "1";
            this.btnTue.Text = "&Tuesday";
            this.btnTue.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnMon
            // 
            this.btnMon.Location = new System.Drawing.Point(23, 24);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(90, 27);
            this.btnMon.TabIndex = 9;
            this.btnMon.Tag = "DayOfWeek.Monday";
            this.btnMon.Text = "&Monday";
            this.btnMon.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // chk2000
            // 
            this.chk2000.Checked = true;
            this.chk2000.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk2000.Location = new System.Drawing.Point(19, 83);
            this.chk2000.Name = "chk2000";
            this.chk2000.Size = new System.Drawing.Size(77, 28);
            this.chk2000.TabIndex = 19;
            this.chk2000.Text = "&2000";
            this.chk2000.CheckedChanged += new System.EventHandler(this.chkCent_CheckedChanged);
            // 
            // chk1900
            // 
            this.chk1900.Checked = true;
            this.chk1900.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1900.Location = new System.Drawing.Point(19, 55);
            this.chk1900.Name = "chk1900";
            this.chk1900.Size = new System.Drawing.Size(77, 28);
            this.chk1900.TabIndex = 18;
            this.chk1900.Text = "1&900";
            this.chk1900.CheckedChanged += new System.EventHandler(this.chkCent_CheckedChanged);
            // 
            // btnSun
            // 
            this.btnSun.Location = new System.Drawing.Point(23, 246);
            this.btnSun.Name = "btnSun";
            this.btnSun.Size = new System.Drawing.Size(90, 26);
            this.btnSun.TabIndex = 15;
            this.btnSun.Tag = "6";
            this.btnSun.Text = "S&unday";
            this.btnSun.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // chk1800
            // 
            this.chk1800.Checked = true;
            this.chk1800.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1800.Location = new System.Drawing.Point(19, 28);
            this.chk1800.Name = "chk1800";
            this.chk1800.Size = new System.Drawing.Size(77, 27);
            this.chk1800.TabIndex = 17;
            this.chk1800.Text = "1&800";
            this.chk1800.CheckedChanged += new System.EventHandler(this.chkCent_CheckedChanged);
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Location = new System.Drawing.Point(8, 304);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(54, 21);
            this.chkLog.TabIndex = 34;
            this.chkLog.Text = "&Log";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // grpDay
            // 
            this.grpDay.Controls.Add(this.btnSun);
            this.grpDay.Controls.Add(this.btnSat);
            this.grpDay.Controls.Add(this.btnFri);
            this.grpDay.Controls.Add(this.btnThu);
            this.grpDay.Controls.Add(this.btnWed);
            this.grpDay.Controls.Add(this.btnTue);
            this.grpDay.Controls.Add(this.btnMon);
            this.grpDay.Enabled = false;
            this.grpDay.Location = new System.Drawing.Point(344, 3);
            this.grpDay.Name = "grpDay";
            this.grpDay.Size = new System.Drawing.Size(134, 295);
            this.grpDay.TabIndex = 32;
            this.grpDay.TabStop = false;
            this.grpDay.Text = "Day";
            // 
            // grpCenturies
            // 
            this.grpCenturies.Controls.Add(this.chk2000);
            this.grpCenturies.Controls.Add(this.chk1900);
            this.grpCenturies.Controls.Add(this.chk1800);
            this.grpCenturies.Location = new System.Drawing.Point(8, 3);
            this.grpCenturies.Name = "grpCenturies";
            this.grpCenturies.Size = new System.Drawing.Size(105, 123);
            this.grpCenturies.TabIndex = 31;
            this.grpCenturies.TabStop = false;
            this.grpCenturies.Text = "Centuries";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(171, 160);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 36);
            this.lblRes.TabIndex = 30;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(171, 104);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(77, 36);
            this.lblYear.TabIndex = 29;
            this.lblYear.Text = "Year";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(171, 58);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(99, 36);
            this.lblMonth.TabIndex = 28;
            this.lblMonth.Text = "Month";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.Enabled = false;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.Location = new System.Drawing.Point(8, 271);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(96, 27);
            this.btnStop.TabIndex = 27;
            this.btnStop.Text = "St&op";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(171, 12);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(67, 36);
            this.lblDay.TabIndex = 26;
            this.lblDay.Text = "Day";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(8, 238);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 27);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "St&art";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTime.Location = new System.Drawing.Point(171, 233);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTime.Size = new System.Drawing.Size(63, 69);
            this.lblTime.TabIndex = 24;
            this.lblTime.Text = "0";
            // 
            // tmrSec
            // 
            this.tmrSec.Interval = 1000;
            this.tmrSec.Tick += new System.EventHandler(this.tmrSec_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(484, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 316);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyright (C) 2005, 2015  Oddbjørn Norstrand and Oddbjørn By.\r\nhttps://github.com" +
    "/gardintrapp/ragnarok";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmRagnarok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 522);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.grpDay);
            this.Controls.Add(this.grpCenturies);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTime);
            this.Name = "frmRagnarok";
            this.Text = "Ragnarok";
            this.Load += new System.EventHandler(this.frmRagnarok_Load);
            this.grpDay.ResumeLayout(false);
            this.grpCenturies.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Timer tmrBlink;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.Button btnFri;
        private System.Windows.Forms.Button btnThu;
        private System.Windows.Forms.Button btnWed;
        private System.Windows.Forms.Button btnTue;
        private System.Windows.Forms.Button btnMon;
        private System.Windows.Forms.CheckBox chk2000;
        private System.Windows.Forms.CheckBox chk1900;
        private System.Windows.Forms.Button btnSun;
        private System.Windows.Forms.CheckBox chk1800;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.GroupBox grpDay;
        private System.Windows.Forms.GroupBox grpCenturies;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrSec;

        private DateTime rnd_date;
        private int num_dates;	//Total number of generted dates
        private int num_correct; //Numver of correct dates
        private int time_sec = 0;	//Atall sekunder btukt
        //Timer
        private Stopwatch stopWatch = new Stopwatch();
        private Random rnd = new Random();

        private Button[] btnDay = new Button[7];

        private String version = "1.1";

        //Log
        string logfilepath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\ragnaroklog.txt";
        private LinkLabel linkLabel1;
    }
}

