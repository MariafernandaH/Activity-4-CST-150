using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  private void CalculateButton_Click(object sender, EventArgs e)
        {
double seconds, SecinMins, SecinHours, SecinDays; 
            seconds = double.Parse(SecondsAns.Text);
            SecinMins = double.Parse(MinsAns.Text);
            SecinHours= double.Parse(HoursAns.Text);
            SecinDays = double.Parse(DaysAns.Text);
            
            
       if (seconds >= 60)
            {
                SecinMins = seconds / 60;
                MinsAns.Text = SecinMins.ToString();  
            }
          if (seconds >= 3600)
            {
               SecinHours = seconds / 3600; 
               HoursAns.Text = SecinHours.ToString();   
            }
          if (seconds >= 86400)
            {
            SecinDays = seconds / 86400;
            DaysAns.Text = SecinDays.ToString();
            }
            
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SecondsAns_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void MinsAns_TextChanged(object sender, EventArgs e)
        {
           
          
            
        }

        private void HoursAns_TextChanged(object sender, EventArgs e)
        {
       
        
        }

        private void DaysAns_TextChanged(object sender, EventArgs e)
        {
        
         
        }

      
    }
    }

