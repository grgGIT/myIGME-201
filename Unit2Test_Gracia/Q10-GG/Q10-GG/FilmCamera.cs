using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_GG
{
    public class FilmCamera: IFocusable
    {
        private string FilmType
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

        public void Focus()
        {
            throw new NotImplementedException();
        }

        public void DeFocus()
        {
            throw new NotImplementedException();
        }
    }
}
