using System;
using System.Windows.Forms;
using System.Diagnostics;


namespace LightsOut
{
    public partial class DifficultyPicker : Form
    {
        public string chosenDifficulty;
        public DifficultyPicker()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var radioButtons = difficultyGroupBox.Controls;

            foreach (RadioButton rb in radioButtons)
            {
                if(rb.Checked)
                {
                    chosenDifficulty = (string)rb.Tag;
                    Close();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
