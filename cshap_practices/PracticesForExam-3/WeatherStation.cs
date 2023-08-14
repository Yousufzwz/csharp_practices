using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesForExam_3;

public delegate void WeatherEventHandler(string location, double temp);

public class WeatherStation
{
    public event WeatherEventHandler WeatherChanged;
    private double _currentTemp = 30.0;

    public double CurrentTemp
    {
        get { return _currentTemp; }
        set
        {

            if (value != _currentTemp)
            {
                _currentTemp = value;
                OnWeatherChanged(value);
            }
        }
    }
     protected virtual void OnWeatherChanged(double newTemp)
    {
        WeatherChanged?.Invoke("Main Station", newTemp);
    }

    }

