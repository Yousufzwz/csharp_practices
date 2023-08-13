using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event;

public class ImageProcessor
{
    public delegate void ImageProcessorEndTrigger();

    public event ImageProcessorEndTrigger EndProcess;

    public void ProcessImage()
    {
        for(int i = 0; i <30;  i++)
        {
            Console.WriteLine($"Processing Image {i}");
        }
        EndProcess.Invoke();
    }

}
