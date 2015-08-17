using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureDetector
{
    class Thermometer
    {
        // enums
        public enum UnitsType { Celsius, Farenheit };
        public enum DirectionType {NoDirection, Decreasing, Increasing};

        // member variables
        DirectionType m_Direction = DirectionType.NoDirection;
        private DirectionType Direction
        {
            get { return m_Direction; }
            set { m_Direction = value; }
        }

        UnitsType m_Units = UnitsType.Celsius; // this defines the units of the new input temperatures, but our calculations will be in Celcius
        private UnitsType Units
        {
            get { return m_Units; }
            set { m_Units = value; }
        }

        // all calculations will be performed in Celsius
        private double m_CurrentTemperature = 0;
        public double CurrentTemperature
        {// all calculations should be in Celsius, convert the temperatures the user inputs and convert before outputting
            get {
                if (m_Units == UnitsType.Celsius)
                    return m_CurrentTemperature;
                else
                    return ConvertCToF(m_CurrentTemperature);
            }
            set { 
                if (m_Units == UnitsType.Celsius)
                    m_CurrentTemperature = value;
                else
                    m_CurrentTemperature = ConvertFToC(value);
            }
        }
        
        private double m_PreviousTemperatureInC = 0; // this is a temporary variable and should not be seen by users
        
        private double m_HysterisisThreshold = 0;
        public double HysterisisThreshold
        {// only give a setter, convert to Celsius
            set {
                if (m_Units == UnitsType.Celsius)
                    m_HysterisisThreshold = value;
                else
                    m_HysterisisThreshold = ConvertFToCNoOffset(value);
            }
        }

        private bool m_HysterisThresholdSatisfied = true;

        private double m_Threshold = 0;
        public double Threshold
        {// can only set thresholds
            set {
                if (m_Units == UnitsType.Celsius)
                    m_Threshold = value;
                else
                    m_Threshold = ConvertFToC(value);
            }
        }

        // methods
        // this converts Celsius to Farenheit with the +32
        public double ConvertCToF(double temperatureC)
        {
            return temperatureC * 9.0 / 5.0 + 32;
        }
        // this converts Celsius to Farenheit as incremental temperature
        public double ConvertCToFNoOffset(double temperatureC)
        {// this is to see how much 1C is in F
            return temperatureC * 9.0 / 5.0;
        }

        // this converts Farenheit to Celsius with the -32
        public double ConvertFToC(double temperatureF)
        {
            return (temperatureF -32)/9.0*5.0;
        }
        // this converts Farenheits to Celsius as incremental temperature
        public double ConvertFToCNoOffset(double temperatureF)
        {// this is if we want to see how much 1F is in C
            return (temperatureF) / 9.0 * 5.0;
        }

        // constructor
        public Thermometer(UnitsType units, DirectionType direction, double threshold, double hysterisis)
        {
            Units = units;
            Direction = direction;
            Threshold = threshold;
            HysterisisThreshold = hysterisis;
        }

        /// <summary>
        /// This function takes a new temperature and detects if the transition the user is looking for happened
        /// </summary>
        /// <returns></returns>
        public bool ReadNewTemperature(double temperature)
        {
            // shift the temperature in
            m_PreviousTemperatureInC = m_CurrentTemperature;

            // read the temperature in
            if (m_Units == UnitsType.Celsius)
                m_CurrentTemperature = temperature;
            else
                m_CurrentTemperature = ConvertFToC(temperature);

            bool crossing = false;
           
            // go through the list of temperatures
            
            // check if there is a threshold crossing, increasing
            if (m_PreviousTemperatureInC < m_Threshold && m_CurrentTemperature >= m_Threshold // crossed threshold increasing
                && (m_Direction == DirectionType.Increasing || m_Direction == DirectionType.NoDirection) // check direction is what is desired
                && m_HysterisThresholdSatisfied == true) // check that the hysterisis has been met
            {// there is a crossing in increasing direction, add the index to the list
                crossing = true;
                m_HysterisThresholdSatisfied = false;
            }// else check if there is a threshold crossing, decreasing
            else if (m_PreviousTemperatureInC > m_Threshold && m_CurrentTemperature <= m_Threshold // crossed threshold decreasing
                && (m_Direction == DirectionType.Decreasing || m_Direction == DirectionType.NoDirection) // check direction is what is desired
                && m_HysterisThresholdSatisfied == true) // check that the hysterisis has been met
            {// there is a crossing in decreasing direction, add the index to the list
                crossing = true;
                m_HysterisThresholdSatisfied = false;
            }

            // check if hysterisis was met in each of 3 situation
            switch (m_Direction)
            {
                case DirectionType.Decreasing:
                    if (m_CurrentTemperature >= (m_HysterisisThreshold + m_Threshold)) // check that temperature is higher than hysterisis amount
                    {
                        m_HysterisThresholdSatisfied = true;
                    }
                    break;
                case DirectionType.Increasing:
                    if (m_CurrentTemperature <= (m_Threshold - m_HysterisisThreshold)) // check that temperature is lower than hysterisis amount
                    {
                        m_HysterisThresholdSatisfied = true;
                    }
                    break;
                case DirectionType.NoDirection:
                    if (m_CurrentTemperature >= (m_HysterisisThreshold + m_Threshold)
                        || m_CurrentTemperature <= (m_Threshold - m_HysterisisThreshold)) // check that temperature far enough in either direction
                    {
                        m_HysterisThresholdSatisfied = true;
                    }
                    break;
            }
            return crossing;
        }
    }
}
