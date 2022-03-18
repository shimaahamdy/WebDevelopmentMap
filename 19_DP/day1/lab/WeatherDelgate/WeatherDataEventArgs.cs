using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDelgate
{
    public class WeatherDataEventArgs : EventArgs
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherDataEventArgs(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
        }

        public float Temperature
        {
            get
            {
                return _temperature;
            }

            set
            {
                _temperature = value;
            }
        }

        public float Humidity
        {
            get
            {
                return _humidity;
            }

            set
            {
                _humidity = value;
            }
        }

        public float Pressure
        {
            get
            {
                return _pressure;
            }

            set
            {
                _pressure = value;
            }
        }
    }

}
