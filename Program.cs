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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ragnarok
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("nn");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("nn");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmRagnarok());
        }
    }
}
