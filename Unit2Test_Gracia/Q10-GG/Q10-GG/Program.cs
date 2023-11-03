using System;

namespace Q10_GG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DigitalCamera digitalCameraObj = new DigitalCamera();
            FilmCamera filmCameraObj = new FilmCamera();

            UseCamera(digitalCameraObj);
            UseCamera(filmCameraObj);

        }
        static void UseCamera(object obj)
        {
            

            if (obj is DigitalCamera digital)
            {
                digital.ZoomOut();
                digital.ZoomIn();   
                digital.CaptureImage();
                digital.SaveImage();
            }
            else if (obj is FilmCamera film)
            {
                film.DeFocus();
                film.Focus();
                film.CaptureImage();
                film.DisplayImage();
            }
        }
    }
}
