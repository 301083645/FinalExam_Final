﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        public static SplashForm splashForm;
        public static GenerateNameForm generateNameForm;
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            splashForm = new SplashForm();
            generateNameForm = new GenerateNameForm();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(splashForm);
        }
    }
}
