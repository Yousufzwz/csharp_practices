using Event;


ImageProcessor imageProcessor = new ImageProcessor();
imageProcessor.EndProcess += ImageProcessor_EndProcess;
imageProcessor.EndProcess -= ImageProcessor_EndProcess2;
imageProcessor.ProcessImage();

void ImageProcessor_EndProcess()
{
    Console.WriteLine("`````Image Processed```````");
}

void ImageProcessor_EndProcess2()
{
    Console.WriteLine("<<<<<<Image Processed>>>>>>");
}