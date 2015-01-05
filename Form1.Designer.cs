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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRagnarok));
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
            resources.ApplyResources(this.txtLog, "txtLog");
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            // 
            // tmrBlink
            // 
            this.tmrBlink.Interval = 1000;
            this.tmrBlink.Tick += new System.EventHandler(this.tmrBlink_Tick);
            // 
            // btnSat
            // 
            resources.ApplyResources(this.btnSat, "btnSat");
            this.btnSat.Name = "btnSat";
            this.btnSat.Tag = "5";
            this.btnSat.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnFri
            // 
            resources.ApplyResources(this.btnFri, "btnFri");
            this.btnFri.Name = "btnFri";
            this.btnFri.Tag = "4";
            this.btnFri.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnThu
            // 
            resources.ApplyResources(this.btnThu, "btnThu");
            this.btnThu.Name = "btnThu";
            this.btnThu.Tag = "3";
            this.btnThu.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnWed
            // 
            resources.ApplyResources(this.btnWed, "btnWed");
            this.btnWed.Name = "btnWed";
            this.btnWed.Tag = "2";
            this.btnWed.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnTue
            // 
            resources.ApplyResources(this.btnTue, "btnTue");
            this.btnTue.Name = "btnTue";
            this.btnTue.Tag = "1";
            this.btnTue.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnMon
            // 
            resources.ApplyResources(this.btnMon, "btnMon");
            this.btnMon.Name = "btnMon";
            this.btnMon.Tag = "DayOfWeek.Monday";
            this.btnMon.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // chk2000
            // 
            resources.ApplyResources(this.chk2000, "chk2000");
            this.chk2000.Checked = true;
            this.chk2000.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk2000.Name = "chk2000";
            this.chk2000.CheckedChanged += new System.EventHandler(this.chkCent_CheckedChanged);
            // 
            // chk1900
            // 
            resources.ApplyResources(this.chk1900, "chk1900");
            this.chk1900.Checked = true;
            this.chk1900.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1900.Name = "chk1900";
            this.chk1900.CheckedChanged += new System.EventHandler(this.chkCent_CheckedChanged);
            // 
            // btnSun
            // 
            resources.ApplyResources(this.btnSun, "btnSun");
            this.btnSun.Name = "btnSun";
            this.btnSun.Tag = "6";
            this.btnSun.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // chk1800
            // 
            resources.ApplyResources(this.chk1800, "chk1800");
            this.chk1800.Checked = true;
            this.chk1800.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1800.Name = "chk1800";
            this.chk1800.CheckedChanged += new System.EventHandler(this.chkCent_CheckedChanged);
            // 
            // chkLog
            // 
            resources.ApplyResources(this.chkLog, "chkLog");
            this.chkLog.Checked = true;
            this.chkLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLog.Name = "chkLog";
            this.chkLog.UseVisualStyleBackColor = true;
            // 
            // grpDay
            // 
            resources.ApplyResources(this.grpDay, "grpDay");
            this.grpDay.Controls.Add(this.btnSun);
            this.grpDay.Controls.Add(this.btnSat);
            this.grpDay.Controls.Add(this.btnFri);
            this.grpDay.Controls.Add(this.btnThu);
            this.grpDay.Controls.Add(this.btnWed);
            this.grpDay.Controls.Add(this.btnTue);
            this.grpDay.Controls.Add(this.btnMon);
            this.grpDay.Name = "grpDay";
            this.grpDay.TabStop = false;
            // 
            // grpCenturies
            // 
            resources.ApplyResources(this.grpCenturies, "grpCenturies");
            this.grpCenturies.Controls.Add(this.chk2000);
            this.grpCenturies.Controls.Add(this.chk1900);
            this.grpCenturies.Controls.Add(this.chk1800);
            this.grpCenturies.Name = "grpCenturies";
            this.grpCenturies.TabStop = false;
            // 
            // lblRes
            // 
            resources.ApplyResources(this.lblRes, "lblRes");
            this.lblRes.Name = "lblRes";
            // 
            // lblYear
            // 
            resources.ApplyResources(this.lblYear, "lblYear");
            this.lblYear.Name = "lblYear";
            // 
            // lblMonth
            // 
            resources.ApplyResources(this.lblMonth, "lblMonth");
            this.lblMonth.Name = "lblMonth";
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblDay
            // 
            resources.ApplyResources(this.lblDay, "lblDay");
            this.lblDay.Name = "lblDay";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTime.Name = "lblTime";
            // 
            // tmrSec
            // 
            this.tmrSec.Interval = 1000;
            this.tmrSec.Tick += new System.EventHandler(this.tmrSec_Tick);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmRagnarok
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
		string logfilepath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "//ragnaroklog.txt";
        private LinkLabel linkLabel1;
    }
}

