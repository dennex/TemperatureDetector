using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureDetector
{
    public partial class TemperatureTester : Form
    {
        public TemperatureTester()
        {
            InitializeComponent();
            textBoxInput.Text += Environment.NewLine + "-100";
            textBoxInput.Text += Environment.NewLine + "0";
            textBoxInput.Text += Environment.NewLine + "5";
            textBoxInput.Text += Environment.NewLine + "0.5";
            textBoxInput.Text += Environment.NewLine + "0";
            textBoxInput.Text += Environment.NewLine + "-3";
            textBoxInput.Text += Environment.NewLine + "1";
            textBoxInput.Text += Environment.NewLine + "103";
            textBoxInput.Text += Environment.NewLine + "99";
            textBoxInput.Text += Environment.NewLine + "101";
            textBoxInput.Text += Environment.NewLine + "-23";
            
        }

        private Thermometer.UnitsType ReadUnits()
        {
            if (radioButtonCelsius.Checked == true)
            {
                return Thermometer.UnitsType.Celsius;
            }
            else
            {// decreasing is checked
                return Thermometer.UnitsType.Farenheit;
            }
        }

        private Thermometer.DirectionType ReadDirection()
        {
            if (radioButtonIncreasing.Checked == true)
            {
                return Thermometer.DirectionType.Increasing;
            }
            else
            {// decreasing is checked
                return Thermometer.DirectionType.Decreasing;
            }
        }

        public double [] ReadInputs()
        {
            double [] inputTemperatures = new double [textBoxInput.Lines.Count()];
            for (int i = 0; i < textBoxInput.Lines.Count(); i++)
            {
                Double.TryParse(textBoxInput.Lines[i], out inputTemperatures[i]);
            }

            return inputTemperatures;
        }

        public void WriteOutputs(bool [] ouputTemperatures)
        {
            textBoxOutput.Text = "";
            for (int i = 0; i < ouputTemperatures.Count(); i++)
            {
                textBoxOutput.Text += ouputTemperatures[i].ToString();
                textBoxOutput.Text += Environment.NewLine;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // initialize the thermometer with a direction of detection, a threshold, and a hysterisis
            // for example, here we set it for detecting freezing, only when the temperature is decreasing, and the temperature has to rise by 2degrees higher than 0 for a new detection to take place
            double threshold, hysterisis;
            Double.TryParse(textBoxThreshold.Text, out threshold);
            Double.TryParse(textBoxHysterisis.Text, out hysterisis);
            Thermometer thermometer = new Thermometer(ReadUnits(), ReadDirection(), threshold, hysterisis);

            double[] temperatures = ReadInputs();            
            bool [] crossings = new bool[temperatures.Count()];
            for (int i = 0; i < temperatures.Count(); i++)
            {
                crossings[i] = thermometer.ReadNewTemperature(temperatures[i]);
            }
            crossings[0] = false;
            WriteOutputs(crossings);
        }
    }
}
