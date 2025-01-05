using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SEU_IS_18_ICT_044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFaculty.Items.AddRange(new string[] { "Faculty of Science", "Faculty of Arts", "Faculty of Engineering","Faculty of Techonology","Faculty of Management" });
            cmbGame.Items.AddRange(new string[] { "Cricket", "Volleyball", "Basketball", "Rugby","Carrom","Badminton" });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Length != 10 || !System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, @"^\d{9}[Vv]$"))
                errorMessage += "Invalid NIC (should be in 123456789V format).\n";

            
            if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text.Length > 20 || !System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, @"^[a-zA-Z0-9 ]+$"))
                errorMessage += "Invalid Team Name (max 20 characters, no special symbols).\n";

            
            if (cmbFaculty.SelectedIndex == -1)
                errorMessage += "Please select a Faculty.\n";

            
            if (string.IsNullOrWhiteSpace(textBox3.Text) || !System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"^[a-zA-Z ]+$"))
                errorMessage += "Invalid Department (should only contain text).\n";

            
            if (string.IsNullOrWhiteSpace(textBox5.Text) || textBox5.Text.Length != 10 || !System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, @"^\d{10}$"))
                errorMessage += "Invalid Contact Number (10 digits only).\n";

            
            if (string.IsNullOrWhiteSpace(textBox6.Text) || textBox6.Text.Length > 30 || !System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, @"^[a-zA-Z ]+$"))
                errorMessage += "Invalid Group Leader Name (max 30 characters, no special symbols).\n";

            
            if (cmbGame.SelectedIndex == -1)
                errorMessage += "Please select a Game.\n";

            
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string details = $"NIC: {textBox1.Text}\n" +
                                 $"Team Name: {textBox2.Text}\n" +
                                 $"Faculty: {cmbFaculty.SelectedItem}\n" +
                                 $"Department: {textBox3.Text}\n" +
                                 $"Contact Number: {textBox5.Text}\n" +
                                 $"Group Leader: {textBox6.Text}\n" +
                                 $"Game: {cmbGame.SelectedItem}";
                MessageBox.Show("Registration Successful!\n\n" + details, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
