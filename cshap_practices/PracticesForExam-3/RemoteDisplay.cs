using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesForExam_3;

public class RemoteDisplay
{
    public void ShowWeather(string location, double temp)
    {
        Console.WriteLine($"Weather updated from {location}: Temperature is {temp}°C" );
    }
}
