﻿using System;
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

        private void GenerateNames()
        {
            Random random = new Random();

            
                int number = random.Next(0, 49);

                FirstNameTextBox.Text = FirstNameListBox.Items[number].ToString();
                LastNameTextBox.Text = LastNameListBox.Items[number].ToString();
            

        }
        
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }


        private void GenerateButton_Click_1(object sender, EventArgs e)
        {
            GenerateNames();
            Character character = Program.character;
            character.FirstName = FirstNameTextBox.Text;
            character.LastName = LastNameTextBox.Text;
        }

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            Program.abilityGenerator.Show();
            this.Hide();
        }
    }
}
