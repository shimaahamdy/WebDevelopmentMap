using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDelgate
{
    public class WeatherData
    {
        public delegate void MeasurementsChanged(object sender, WeatherDataEventArgs e);
        public event MeasurementsChanged Changed;

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            WeatherDataEventArgs weatherArgs = new WeatherDataEventArgs(temperature, humidity, pressure);

            Changed(this, weatherArgs);
        }
    }
}
