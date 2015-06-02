using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OhmsLawCalcwf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Current_Click(object sender, EventArgs e)
        {
            double dblResistance = 0.0;
            double dblVoltage = 0.0;
            double dblCurrent = 0.0;
            bool bHasError = false;
            String strMsg = "";

            try
            {
                dblResistance = Double.Parse(Resistance_Box.Text);
                dblVoltage = Double.Parse(Voltage_Box.Text);

                dblCurrent = dblVoltage / dblResistance;

                Current_Box.Text = dblCurrent.ToString();
            }
            catch (Exception ex)
            {
                bHasError = true;
                strMsg = ex.Message;
            }

            if (bHasError)
            {
                MessageBox.Show(strMsg);
            }
        }

        private void Calc_Voltage_Click(object sender, EventArgs e)
        {
            double dblResistance = 0.0;
            double dblVoltage = 0.0;
            double dblCurrent = 0.0;
            bool bHasError = false;
            String strMsg = "";

            try
            {
                dblResistance = Double.Parse(Resistance_Box.Text);
                dblCurrent = Double.Parse(Current_Box.Text);

                dblVoltage = dblCurrent * dblResistance;

                Voltage_Box.Text = dblVoltage.ToString();
            }
            catch (Exception ex)
            {
                bHasError = true;
                strMsg = ex.Message;
            }

            if (bHasError)
            {
                MessageBox.Show(strMsg);
            }
        }

        private void Calc_Resistance_Click(object sender, EventArgs e)
        {
            double dblResistance = 0.0;
            double dblVoltage = 0.0;
            double dblCurrent = 0.0;
            bool bHasError = false;
            String strMsg = "";

            try
            {
                dblVoltage = Double.Parse(Voltage_Box.Text);
                dblCurrent = Double.Parse(Current_Box.Text);

                dblResistance = dblVoltage * dblCurrent;

                Resistance_Box.Text = dblResistance.ToString();
            }
            catch (Exception ex)
            {
                bHasError = true;
                strMsg = ex.Message;
            }

            if (bHasError)
            {
                MessageBox.Show(strMsg);
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Voltage_Box.Text = "";
            Current_Box.Text = "";
            Resistance_Box.Text = "";
        }
    }
}
