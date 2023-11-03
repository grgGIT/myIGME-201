using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_GG
{
    public class DigitalCamera: IZoomable
    {
        private int Resolution
        {
            get;
            set;
        }
        public void CaptureImage()
        {

        }
        public void SaveImage()
        {

        }
        public void DisplayImage()
        {

        }

        public void ZoomIn()
        {
            throw new NotImplementedException();
        }

        public void ZoomOut()
        {
            throw new NotImplementedException();
        }
    }
}
