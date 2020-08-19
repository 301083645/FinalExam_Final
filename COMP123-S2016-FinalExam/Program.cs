using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 */

namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        //public static
        public static SplashForm splashForm;
        public static GenerateNameForm generateNameForm;
        //public static AbilityGeneratorForm abilityGenerator;
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //make form
            splashForm = new SplashForm();
            generateNameForm = new GenerateNameForm();
            //abilityGenerator = new AbilityGeneratorForm();

            // start with splashForm
            Application.Run(splashForm);
        }
    }
}
