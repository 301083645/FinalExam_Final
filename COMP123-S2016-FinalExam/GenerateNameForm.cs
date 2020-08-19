using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        // method that pick FirstName and LastName randomly;
        private void GenerateNames()
        {
            // create random
            Random random = new Random();

                // from where to where // 50 items
                int number = random.Next(0, 49);
                // put randomly picked name into the text box.
                FirstNameTextBox.Text = FirstNameListBox.Items[number].ToString();
                LastNameTextBox.Text = LastNameListBox.Items[number].ToString();
            

        }
        
        // call the GenerateNames methods
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        // call the GenerateNames methods
        // save value
        private void GenerateButton_Click_1(object sender, EventArgs e)
        {
            GenerateNames();
            Character character = Program.character;
            character.FirstName = FirstNameTextBox.Text;
            character.LastName = LastNameTextBox.Text;
        }

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            //instantiate a new AbilityGeneratorForm
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            // move to abilityGeneratorForm
            abilityGeneratorForm.Show();

            //Program.abilityGenerator.Show();
            //hide this form
            this.Hide();
        }
    }
}
