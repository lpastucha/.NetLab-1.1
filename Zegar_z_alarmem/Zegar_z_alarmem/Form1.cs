using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zegar_z_alarmem
{
    public partial class Form1 : Form
    {
        private bool isAlarm = false;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
        }

        private void clockDisplayer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setAlarm();
            alarmTimeLBL.Visible = true;
            bottomLBL.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            timeChanger();
            if (isAlarm)
            {
                if (alarmTimeLBL.Text.Equals(clockDisplayer.Text))
                {
                    showAlarm();
                }

            }
        }

        private void timeChanger()
        {
            clockDisplayer.Text = DateTime.Now.ToLongTimeString();
            dateLBL.Text = DateTime.Now.ToShortDateString();
        }

        private void setAlarm()
        {
            alarmTimeLBL.Text = dateTimePicker1.Value.ToLongTimeString();
            isAlarm = true;
        }

        private void showAlarm()
        {
            MessageBox.Show("Alarm: " + alarmTimeLBL.Text);
        }
    }
}
