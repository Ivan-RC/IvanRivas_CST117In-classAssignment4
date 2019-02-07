using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IvanRivas_CST117In_classAssignment4
{
    public partial class secondsConverter : Form
    {
        public secondsConverter()
        {
            InitializeComponent();
        }


        //Ivan Rivas. This is my own work.
        private void btn2_Calculate_Click(object sender, EventArgs e)
        {
            try {
                int secondsEntered, minutesOutput, hoursOutput, daysOutput;
                secondsEntered = int.Parse(textBox1_input.Text);


                if (secondsEntered >= 60 && secondsEntered <= 3600) {

                    minutesOutput = secondsEntered / 60;
                    label2_secondsTominutes.Text = secondsEntered + " seconds converts to " + minutesOutput + " minute(s).";
                }
                else if (secondsEntered >= 3600 && secondsEntered <= 86400) {

                    minutesOutput = secondsEntered / 60;
                    label5_secondsTominutes.Text = secondsEntered + " seconds converts to " + minutesOutput + " minute(s).";
                    hoursOutput = secondsEntered / 3600;
                    label3_secondsTohours.Text = secondsEntered + " seconds converts to " + hoursOutput + " hour(s).";
                    

                }
                else if (secondsEntered >= 86400) {
                    minutesOutput = secondsEntered / 60;
                    label6_secondsTominutes.Text = secondsEntered + " seconds converts to " + minutesOutput + " minute(s).";
                    hoursOutput = secondsEntered / 3600;
                    label7_secondsTohours.Text = secondsEntered + " seconds converts to " + hoursOutput + " hour(s).";
                    daysOutput = secondsEntered / 86400;
                    label4_secondsTodays.Text = secondsEntered + " seconds converts to " + daysOutput + " day(s).";

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Input must be a number.");
            }

        }
            

        private void btn1_Clear_Click(object sender, EventArgs e)
        {
            textBox1_input.Text = "";
            label2_secondsTominutes.Text = "";
            label3_secondsTohours.Text = "";
            label4_secondsTodays.Text = "";
            label5_secondsTominutes.Text = "";
            label6_secondsTominutes.Text = "";
            label7_secondsTohours.Text = "";
        }

        private void btn3_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
